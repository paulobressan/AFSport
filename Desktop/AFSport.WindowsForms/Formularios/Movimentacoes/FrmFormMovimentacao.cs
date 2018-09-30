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

namespace AFSport.WindowsForms.Formularios.Movimentacoes
{
    public partial class FrmFormMovimentacao : FrmFormularioBase
    {
        Movimentacao movimentacao;
        Usuario usuario;
        public FrmFormMovimentacao(Movimentacao movimentacao, Usuario usuario)
        {
            InitializeComponent();
            this.movimentacao = movimentacao;
            this.usuario = usuario;
        }

        protected override async void FrmFormularioBase_Load(object sender, EventArgs e)
        {
            await CarregarComboBoxOperacao();
            MontarForm();
            base.FrmFormularioBase_Load(sender, e);
        }

        protected override async void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor.Text))
                MessageBox.Show("Campo valor obrigatório.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (cmbOperacao.SelectedItem == null)
                MessageBox.Show("Seleção de operação obrigatória.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                await Salvar();
            base.BtnSalvar_Click(sender, e);
        }

        private async Task Salvar()
        {
            using (MovimentacaoRepository repository = new MovimentacaoRepository())
            {
                movimentacao.Valor = Convert.ToDecimal(txtValor.Text);
                movimentacao.Data = DateTime.Now;
                movimentacao.IdUsuario = usuario.IdUsuario;
                movimentacao.IdOperacao = (int) cmbOperacao.SelectedValue;
                await repository.Salvar(movimentacao);
                DialogResult = DialogResult.OK;
            }
        }

        private void MontarForm()
        {
            LblId.Text = movimentacao.IdMovimentacao.ToString();
            txtValor.Text = movimentacao.Valor.ToString();
            cmbOperacao.SelectedValue = movimentacao.Operacao?.IdOperacao ?? 0;
        }

        private async Task CarregarComboBoxOperacao()
        {
            cmbOperacao.DataSource = await SelecionarTodasOperacoes();
            cmbOperacao.DisplayMember = "Nome";
            cmbOperacao.ValueMember = "IdOperacao";
            cmbOperacao.Refresh();
        }

        private async Task<List<Operacao>> SelecionarTodasOperacoes()
        {
            using (OperacaoRepository repository = new OperacaoRepository())
                return await repository.SelecionarTodos(false);
        }
    }
}
