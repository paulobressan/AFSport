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

namespace AFSport.WindowsForms.Formularios.Estoques
{
    public partial class FrmEstoque : FrmCadastroBase
    {
        Estoque estoque;
        public FrmEstoque()
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
            using (FrmFormEstoque frm = new FrmFormEstoque(new Estoque()))
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
            if(estoque != null) 
            using (FrmFormEstoque frm = new FrmFormEstoque(estoque))
            {
                using (FrmModal frmModal = new FrmModal(frm))
                    frmModal.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                    await CarregarGrid();
            }
            else
                MessageBox.Show("Seleciona um estoque para altera-lo.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            base.BtnAlterar_Click(sender, e);
        }

        protected override async void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (estoque != null && MessageBox.Show($"Confirma a remoção do estoque do produto {estoque.Produto}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                await Remover();
            }
            base.BtnDeletar_Click(sender, e);
        }

        private async Task CarregarGrid()
        {
            GridPesq.DataSource = await SelecionarTodosEstoque();
        }

       private async Task Remover()
        {
            using (EstoqueRepository repository = new EstoqueRepository())
            {
                repository.Remover(estoque);
                MessageBox.Show($"O Estoque do Produto {estoque.Produto} foi removido com sucesso", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CarregarGrid();
            }
        }

        private async Task<List<Estoque>> SelecionarTodosEstoque()
        {
            using (EstoqueRepository repository = new EstoqueRepository())
            {
                return await repository.SelecionarTodos(true);
            }
        }

        private void GridPesq_SelectionChanged(object sender, EventArgs e)
        {
            if (GridPesq.SelectedRows.Count > 0)
                estoque = (Estoque)GridPesq.SelectedRows[0].DataBoundItem;
        }
    }
}
