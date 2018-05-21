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

namespace AFSport.WindowsForms.Formularios.Produtos
{
    public partial class FrmProdutos : FrmCadastroBase
    {
        Produto produto;
        public FrmProdutos()
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
            using (CategoriaRepository repository = new CategoriaRepository())
            {
                if (await repository.TotalRegistros() > 0)
                    using (FrmFormProdutos frm = new FrmFormProdutos(new Produto()))
                    {
                        using (FrmModal frmModal = new FrmModal(frm))
                            frmModal.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                            await CarregarGrid();
                    }
                else
                    MessageBox.Show("Por favor, antes de cadastrar um produto, cadastre uma categoria para seus produtos.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                base.BtnNovo_Click(sender, e);
            }
        }

        protected override async void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (produto != null)
                using (FrmFormProdutos frm = new FrmFormProdutos(produto))
                {
                    using (FrmModal frmModal = new FrmModal(frm))
                        frmModal.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                        await CarregarGrid();
                }
            else
                MessageBox.Show("Seleciona um produto para altera-lo.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            base.BtnAlterar_Click(sender, e);
        }

        protected override void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (produto != null && MessageBox.Show($"Confirma a remoção do produto {produto.Nome}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

            }
            base.BtnDeletar_Click(sender, e);
        }

        private async Task CarregarGrid()
        {
            GridPesq.DataSource = await SelecionarTodosProdutos();
        }

        private async Task<List<Produto>> SelecionarTodosProdutos()
        {
            using (ProdutoRepository repository = new ProdutoRepository())
            {
                return await repository.SelecionarTodos(true);
            }
        }

        private void GridPesq_SelectionChanged(object sender, EventArgs e)
        {
            if (GridPesq.SelectedRows.Count > 0)
                produto = (Produto)GridPesq.SelectedRows[0].DataBoundItem;
        }

        private async void BtnGerarEstoque_Click(object sender, EventArgs e)
        {
            if (categoria == null)
                MessageBox.Show("Selecione um Produto para gerar o estoque.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if(await SelecionarEstoquePorProduto() != null)
                    MessageBox.Show($"Atenção! Já existe um estoque para o produto {produto.Nome}. Acessa a tela de estoque para gerenciá-lo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    await GerarEstoque();
                    MessageBox.Show($"O estoque do produto {produto.Nome} foi gerado com sucesso.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async Task<Estoque> SelecionarEstoquePorProduto()
        {
            using(EstoqueRepository repository = new EstoqueRepository())
            {
                return await repository.SelecionarEstoquePorProduto(produto.IdProduto);
            }
        }

        private async Task GerarEstoque()
        {
            using (EstoqueRepository repository = new EstoqueRepository())
            {
                await repository.Salvar(new Estoque(
                        0,
                        produto.IdProduto,
                        1
                    ));
            }
        }
    }
}
