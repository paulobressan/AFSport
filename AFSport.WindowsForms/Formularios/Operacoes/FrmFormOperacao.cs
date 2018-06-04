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

namespace AFSport.WindowsForms.Formularios.Operacoes
{
    public partial class FrmFormOperacao : FrmFormularioBase
    {
        Operacao operacao;
        public FrmFormOperacao(Operacao operacao)
        {
            InitializeComponent();
            this.operacao = operacao;
        }

        protected override void FrmFormularioBase_Load(object sender, EventArgs e)
        {
            MontarFormulario();
        }

        protected override async void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
                MessageBox.Show("Campo nome obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                await Salvar();
        }

        private void MontarFormulario()
        {
            LblId.Text = operacao.IdOperacao.ToString();
            txtNome.Text = operacao.Nome;
            txtDescricao.Text = operacao.Descricao;
            chkAtivo.Checked = operacao.IsAtivo;
        }

        private async Task Salvar()
        {
            using(OperacaoRepository repository = new OperacaoRepository())
            {
                await repository.Salvar(new Operacao(
                    txtNome.Text)
                {
                    Descricao = txtDescricao.Text,
                    IdOperacao = operacao.IdOperacao,
                    IsAtivo = chkAtivo.Checked
                });
                DialogResult = DialogResult.OK;
            }
        }
    }
}
