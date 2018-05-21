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

namespace AFSport.WindowsForms.Formularios.Estados
{
    public partial class FrmEstados : FrmCadastroBase
    {
        Estado estado;
        public FrmEstados()
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
            using (FrmFormEstado frm = new FrmFormEstado(new Estado()))
            {
                using (FrmModal frmModal = new FrmModal(frm))
                    frmModal.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                    await CarregarGrid();
            }
            base.BtnNovo_Click(sender, e);
        }

        protected override async void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (estado != null)
                using (FrmFormEstado frm = new FrmFormEstado(estado))
                {
                    using (FrmModal frmModal = new FrmModal(frm))
                        frmModal.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                        await CarregarGrid();
                }
            else
                MessageBox.Show("Seleciona um estado para altera-lo.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);

            base.BtnAlterar_Click(sender, e);
        }

        protected override async void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (estado != null && MessageBox.Show($"Confirma a remoção do estado {estado.Nome}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                await Remover();
            }
            base.BtnDeletar_Click(sender, e);
        }

        private async Task CarregarGrid()
        {
            GridPesq.DataSource = await SelecionarTodosEstados();
        }

        private async Task Remover()
        {
            if (await ExisteDependencia())
            {
                if (MessageBox.Show($"O estado {estado.Nome} não pode ser excluido, por que existe dependencias. Deseja inativar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    estado.IsAtivo = false;
                    using (EstadoRepository repository = new EstadoRepository())
                    {
                        var estadoInativado = await repository.Salvar(estado);
                        MessageBox.Show($"O estado {estadoInativado.Nome} foi inativado com sucesso", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CarregarGrid();
                    }
                }
            }
            else
            {
                using (EstadoRepository repository = new EstadoRepository())
                {
                    repository.Remover(estado);
                    MessageBox.Show($"O estado {estado.Nome} foi removida com sucesso", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CarregarGrid();
                }
            }
        }

        private async Task<bool> ExisteDependencia()
        {
            using (CidadeRepository repository = new CidadeRepository())
            {
                var cidades = await repository.SelecionarTodosPorEstado(estado.IdEstado);
                if (cidades.Count > 0)
                    return true;
                else
                    return false;
            }
        }

        private async Task<List<Estado>> SelecionarTodosEstados()
        {
            using (EstadoRepository repository = new EstadoRepository())
            {
                return await repository.SelecionarTodos(true);
            }
        }

        private void GridPesq_SelectionChanged(object sender, EventArgs e)
        {
            if (GridPesq.SelectedRows.Count > 0)
                estado = (Estado)GridPesq.SelectedRows[0].DataBoundItem;
        }
    }
}
