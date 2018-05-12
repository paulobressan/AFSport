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
    public partial class FrmFormulario : FrmFormularioBase
    {
        Produto produto;
        public FrmFormulario(Produto produto)
        {
            InitializeComponent();
            this.produto = produto;
        }

        protected override void FrmFormularioBase_Load(object sender, EventArgs e)
        {
            CarregarCmbCategoria();
            base.FrmFormularioBase_Load(sender, e);
        }

        protected override void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length == 0)
                MessageBox.Show("Campo nome obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtValorCompra.Text.Length == 0)
                MessageBox.Show("Campo Valor Compra obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtValorVenda.Text.Length == 0)
                MessageBox.Show("Campo Valor Venda obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Salvar();
                base.BtnSalvar_Click(sender, e);
            }
        }

        protected override void MontarFormulario()
        {
            LblId.Text = produto.Id.ToString();
            txtNome.Text = produto.Nome;
            txtDescricao.Text = produto.Descricao;
            txtValorCompra.Text = produto.ValorCompra.ToString();
            txtValorVenda.Text = produto.ValorVenda.ToString();
            cmbCategoria.SelectedValue = produto.Categoria?.Id ?? 0;
            chkAtivo.Checked = produto.IsAtivo;
        }

        protected async override void Salvar()
        {
            var categoriaSelecionada = await SelecionarCategoriaSelecionada();
            using (ProdutoDAO dao = new ProdutoDAO())
                await dao.Salvar(new Produto(
                    txtNome.Text,
                    Convert.ToDecimal(txtValorCompra.Text),
                    Convert.ToDecimal(txtValorVenda.Text),
                    categoriaSelecionada
                    )
                {
                    Id = produto.Id,
                    Descricao = txtDescricao.Text
                }
                );
        }

        private async Task<Categoria> SelecionarCategoriaSelecionada()
        {
            using (CategoriaDAO dao = new CategoriaDAO())
                return await dao.SelecionarId((int)cmbCategoria.SelectedValue);
        }

        private async void CarregarCmbCategoria()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.DataSource = await ListarTodasCategorias();
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DisplayMember = "Nome";
        }

        private async Task<List<Categoria>> ListarTodasCategorias()
        {
            using (CategoriaDAO dao = new CategoriaDAO())
                return await dao.SelecionarTodos(false);
        }
    }
}
