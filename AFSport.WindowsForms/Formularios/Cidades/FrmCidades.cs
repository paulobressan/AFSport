using AFSport.Service.Model;
using AFSport.Service.Repository;
using AFSport.WindowsForms.Formularios.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.WindowsForms.Formularios.Cidades
{
    public partial class FrmCidades : FrmCadastroBase
    {
        Cidade cidade;
        public FrmCidades()
        {
            InitializeComponent();
        }

        protected override async void FrmCadastroBase_Load(object sender, EventArgs e)
        {
            GridPesq.AutoGenerateColumns = false;
            await CarregarGrid();
            base.FrmCadastroBase_Load(sender, e);
        }

        protected override async void BtnNovo_Click(object sender, EventArgs e)
        {
            using (EstadoRepository repository = new EstadoRepository())
            {
                if (await repository.TotalRegistros() > 0)
                    using (FrmFormCidade frm = new FrmFormCidade(new Cidade()))
                    {
                        using (FrmModal frmModal = new FrmModal(frm))
                            frmModal.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                            await CarregarGrid();
                    }
                else
                    MessageBox.Show("Por favor, antes de cadastrar uma cidade, cadastre um estado para suas cidades.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            base.BtnNovo_Click(sender, e);
        }

        protected override async void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (cidade != null)
                using (FrmFormCidade frm = new FrmFormCidade(cidade))
                {
                    using (FrmModal frmModal = new FrmModal(frm))
                        frmModal.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                        await CarregarGrid();
                }
            else
                MessageBox.Show("Seleciona uma cidade para altera-la.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);

            base.BtnAlterar_Click(sender, e);
        }

        protected override async void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (cidade != null && MessageBox.Show($"Confirma a remoção da cidade {cidade.Nome}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                await Remover();
            }
            base.BtnDeletar_Click(sender, e);
        }

        private async Task CarregarGrid()
        {
            GridPesq.DataSource = await SelecionarTodasCidades();
        }

        private async Task Remover()
        {
            if (await ExisteDependencia())
            {
                if (MessageBox.Show($"A cidade {cidade.Nome} não pode ser excluida, por que existe dependencias. Deseja inativar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cidade.IsAtivo = false;
                    cidade.IdEstado = cidade.Estado.IdEstado;
                    using (CidadeRepository repository = new CidadeRepository())
                    {
                        var cidadeInativada = await repository.Salvar(cidade);
                        MessageBox.Show($"A cidade {cidadeInativada.Nome} foi inativada com sucesso", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CarregarGrid();
                    }
                }
            }
            else
            {
                using (CidadeRepository repository = new CidadeRepository())
                {
                    await repository.Remover(cidade);
                    MessageBox.Show($"A cidade {cidade.Nome} foi removida com sucesso", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CarregarGrid();
                }
            }
        }

        private async Task<bool> ExisteDependencia()
        {
            using (ClienteRepository repository = new ClienteRepository())
            {
                var clientes = await repository.SelecionarPorCidade(cidade.IdCidade);
                if (clientes.Count > 0)
                    return true;
                else
                    return false;
            }
        }

        private async Task<List<Cidade>> SelecionarTodasCidades()
        {
            using (CidadeRepository repository = new CidadeRepository())
            {
                return await repository.SelecionarTodos(true);
            }
        }

        private void GridPesq_SelectionChanged(object sender, EventArgs e)
        {
            if (GridPesq.SelectedRows.Count > 0)
                cidade = (Cidade)GridPesq.SelectedRows[0].DataBoundItem;
        }
    }
}
