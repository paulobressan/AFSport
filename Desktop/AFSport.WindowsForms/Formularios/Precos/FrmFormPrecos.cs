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

namespace AFSport.WindowsForms.Formularios.Precos
{
    public partial class FrmFormPrecos : FrmFormularioBase
    {
        Preco preco;
        public FrmFormPrecos(Preco preco)
        {
            InitializeComponent();
            this.preco = preco;
        }

        protected override async void FrmFormularioBase_Load(object sender, EventArgs e)
        {
            await CarregarComboBoxProdutos();
            MontarForm();
            base.FrmFormularioBase_Load(sender, e);
        }

        protected override async void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor.Text))
                MessageBox.Show("Campo valor obrigatório.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (string.IsNullOrEmpty(txtDataInicio.Text))
                MessageBox.Show("Campo data início obrigatório.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (string.IsNullOrEmpty(txtDataFinal.Text))
                MessageBox.Show("Campo data final obrigatório.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (cmbProdutos.SelectedItem == null)
                MessageBox.Show("Seleção de produto obrigatória.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                await Salvar();
            base.BtnSalvar_Click(sender, e);
        }

        private void MontarForm()
        {
            txtValor.Text = preco.Valor.ToString();
            txtDataInicio.Text = preco.IdPreco != 0 ? preco.DataInicio.ToShortDateString() : DateTime.Now.ToShortDateString();
            txtDataFinal.Text = preco.IdPreco != 0 ? preco.DataFinal.ToShortDateString() : DateTime.Now.ToShortDateString();
            cmbProdutos.SelectedValue = preco.Produto?.IdProduto ?? 0;
        }

        private async Task Salvar()
        {
            using (PrecoRepository repository = new PrecoRepository())
            {
                preco.SetValor(Convert.ToDecimal(txtValor.Text));
                preco.DataInicio = Convert.ToDateTime(txtDataInicio.Text);
                preco.DataFinal = Convert.ToDateTime(txtDataFinal.Text);
                preco.IdProduto = (int)cmbProdutos.SelectedValue;
                await repository.Salvar(preco);
                DialogResult = DialogResult.OK;
            }
        }

        private async Task CarregarComboBoxProdutos()
        {
            cmbProdutos.DataSource = await SelecionarTodosProdutos();
            cmbProdutos.DisplayMember = "Nome";
            cmbProdutos.ValueMember = "IdProduto";
            cmbProdutos.Refresh();
        }

        private async Task<List<Produto>> SelecionarTodosProdutos()
        {
            using (ProdutoRepository repository = new ProdutoRepository())
                return await repository.SelecionarTodos(false);
        }
    }
}
