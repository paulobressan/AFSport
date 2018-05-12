using AFSport.DAO.Model;
using AFSport.Service.DAO;
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

namespace AFSport.WindowsForms.Formularios.Produtos
{
    public partial class FrmProdutos : FrmCadastroBase
    {
        Produto produto;
        public FrmProdutos()
        {
            InitializeComponent();
        }

        protected override void BtnNovo_Click(object sender, EventArgs e)
        {
            using (FrmFormulario frm = new FrmFormulario(new Produto()))
            {
                using (FrmModal frmModal = new FrmModal(frm))
                    frmModal.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                    CarregarGrid();
            }
            base.BtnNovo_Click(sender, e);
        }

        protected override void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (produto != null)
                using (FrmFormulario frm = new FrmFormulario(produto))
                {
                    using (FrmModal frmModal = new FrmModal(frm))
                        frmModal.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                        CarregarGrid();
                }
            else
                MessageBox.Show("Seleciona um produto para altera-lo.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            base.BtnAlterar_Click(sender, e);
        }

        protected override void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (produto != null && MessageBox.Show($"Confirma a remoção do produto {produto.Nome}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Remover();
            }
            base.BtnDeletar_Click(sender, e);
        }

        protected override async void CarregarGrid()
        {
            GridPesq.DataSource = await ListarTodosProdutos();
        }

        private async Task<List<Produto>> ListarTodosProdutos()
        {
            using (ProdutoDAO dao = new ProdutoDAO())
            {
                return await dao.SelecionarTodos(true);
            }
        }

        protected override void Remover()
        {
            base.Remover();
        }

        private void GridPesq_SelectionChanged(object sender, EventArgs e)
        {
            if (GridPesq.SelectedRows.Count > 0)
                produto = (Produto)GridPesq.SelectedRows[0].DataBoundItem;
        }
    }
}
