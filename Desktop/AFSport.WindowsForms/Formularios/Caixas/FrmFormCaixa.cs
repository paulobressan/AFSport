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

namespace AFSport.WindowsForms.Formularios.Caixas
{
    public partial class FrmFormCaixa : FrmFormularioBase
    {
        Caixa caixa;
        Usuario usuario;
        public FrmFormCaixa(Caixa caixa, Usuario usuario)
        {
            InitializeComponent();
            this.caixa = caixa;
            this.usuario = usuario;
        }

        protected override void FrmFormularioBase_Load(object sender, EventArgs e)
        {
            MontarForm();
            base.FrmFormularioBase_Load(sender, e);
        }

        protected override async void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValorInicial.Text))
                MessageBox.Show("Campo valor inicial obrigatório.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                await Salvar();
            base.BtnSalvar_Click(sender, e);
        }

        private void MontarForm()
        {
            LblId.Text = caixa.IdCaixa.ToString();
            txtValorInicial.Text = caixa.ValorInicial.ToString();
            txtData.Text = caixa.IdCaixa != 0 ? caixa.Data.ToString() : DateTime.Now.ToShortDateString();
        }

        private async Task Salvar()
        {
            using (CaixaRepository repository = new CaixaRepository())
            {
                caixa.Data = caixa.IdCaixa != 0 ? caixa.Data : DateTime.Now;
                caixa.SetValorInicial(Convert.ToDecimal(txtValorInicial.Text));
                caixa.IdUsuario = usuario.IdUsuario;
                await repository.Salvar(caixa);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
