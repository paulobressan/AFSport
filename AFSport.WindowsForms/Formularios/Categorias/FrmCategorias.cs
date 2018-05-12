using AFSport.DAO.Model;
using AFSport.Service.DAO;
using AFSport.WindowsForms.Formularios.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.WindowsForms.Formularios.Categorias
{
    public partial class FrmCategorias : FrmCadastroBase
    {
        private Categoria categoria;
        public FrmCategorias()
        {
            InitializeComponent();
        }

        protected override void BtnNovo_Click(object sender, EventArgs e)
        {
            using (FrmFormulario frm = new FrmFormulario(new Categoria()))
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
            if (categoria != null)
                using (FrmFormulario frm = new FrmFormulario(categoria))
                {
                    using (FrmModal frmModal = new FrmModal(frm))
                        frmModal.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                        CarregarGrid();
                }
            else
                MessageBox.Show("Seleciona uma categoria para altera-la.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            base.BtnAlterar_Click(sender, e);
        }

        protected override void BtnDeletar_Click(object sender, EventArgs e)
        {
            if(categoria != null && MessageBox.Show($"Confirma a remoção da categoria {categoria.Nome}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Remover();
            }
            base.BtnDeletar_Click(sender, e);
        }

        protected override async void CarregarGrid()
        {

            GridPesq.DataSource = await ListarTodasCategorias();
        }

        private async Task<List<Categoria>> ListarTodasCategorias()
        {
            using (CategoriaDAO dao = new CategoriaDAO())
            {
                return await dao.SelecionarTodos(true);
            }
        }

        private void GridPesq_SelectionChanged(object sender, EventArgs e)
        {
            categoria = GridPesq.SelectedRows.Count > 0
                ? (Categoria)GridPesq.SelectedRows[0].DataBoundItem
                : null;
        }

        private async Task<bool> ExisteDependencia()
        {
            using (ProdutoDAO daoProduto = new ProdutoDAO())
            {
                var produtos = await daoProduto.SelecionarProdutosPorCategoria(categoria.Id);
                if (produtos.Count > 0)
                    return true;
                else
                    return false;
            }
        }

        protected override async void Remover()
        {
            if (await ExisteDependencia())
            {
                if (MessageBox.Show($"A categoria {categoria.Nome} não pode ser excluida, por que existe dependencias. Deseja inativar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    categoria.IsAtivo = false;
                    using (CategoriaDAO dao = new CategoriaDAO())
                    {
                        var categoriaInativada = await dao.Salvar(categoria);
                        MessageBox.Show($"Categoria {categoriaInativada.Nome} foi inativada com sucesso", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarGrid();
                    }
                }
            }
            else
            {
                using (CategoriaDAO dao = new CategoriaDAO())
                {
                    var categoriaRemovida = await dao.Remover(categoria);
                    MessageBox.Show($"Categoria {categoriaRemovida.Nome} foi removida com sucesso", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                }
            }
        }
    }
}
