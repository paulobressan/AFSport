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
    public partial class FrmFormEstoque : FrmFormularioBase
    {
        Estoque estoque;
        Usuario usuario;
        public FrmFormEstoque(Estoque estoque, Usuario usuario)
        {
            InitializeComponent();
            this.estoque = estoque;
            this.usuario = usuario;
        }

        protected override async void FrmFormularioBase_Load(object sender, EventArgs e)
        {
            await CarregarCmbProdutos();
            MontarFormulario();
            base.FrmFormularioBase_Load(sender, e);
        }

        protected override async void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbProdutos.SelectedValue == null)
                MessageBox.Show("Seleção de Produto obrigatória", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (String.IsNullOrEmpty(txtQuantidade.Text))
                MessageBox.Show("Campo Quantidade obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                await Salvar();
        }

        private async Task Salvar()
        {
            using (EstoqueRepository repository = new EstoqueRepository())
            {
                await repository.Salvar(new Estoque(
                        Convert.ToInt32(txtQuantidade.Text),
                        (int)cmbProdutos.SelectedValue,
                        1
                    )
                {
                    IdEstoque = estoque.IdEstoque
                });
                DialogResult = DialogResult.OK;
            }
        }

        private void MontarFormulario()
        {
            LblId.Text = estoque.IdEstoque.ToString();
            cmbProdutos.SelectedValue = estoque.Produto?.IdProduto ?? 0;
            txtQuantidade.Text = estoque.Quantidade.ToString();
            cmbProdutos.Enabled = estoque.IdEstoque != 0 ? false : true;
        }

        private async Task CarregarCmbProdutos()
        {
            cmbProdutos.DataSource = estoque.IdEstoque == 0
                ? await SelecionarTodosProdutosSemEstoque()
                : await SelecionarTodosProdutosComEstoque();
            cmbProdutos.DisplayMember = "Nome";
            cmbProdutos.ValueMember = "idProduto";
            cmbProdutos.Refresh();         
        }

        private async Task<List<Produto>> SelecionarTodosProdutosComEstoque()
        {
            using (ProdutoRepository repository = new ProdutoRepository())
            {
                return await repository.SelecionarProdutosComEstoque();
            }
        }

        private async Task<List<Produto>> SelecionarTodosProdutosSemEstoque()
        {
            using (ProdutoRepository repository = new ProdutoRepository())
            {
                return await repository.SelecionarProdutosSemEstoque();
            }
        }
    }
}
