using AFSport.Service.Model;
using AFSport.Service.Repository;
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
    public partial class FrmAberturaCaixa : Form
    {
        Usuario usuario;
        public FrmAberturaCaixa(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrmAberturaCaixa_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void LblSair_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma em cancelar a operação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private async void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtValorInicial.Text))
                MessageBox.Show("Campo valor inicial obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                await Salvar();
        }

        private async Task Salvar()
        {
            using(CaixaRepository repository = new CaixaRepository())
            {
                await repository.Salvar(new Caixa(
                    Convert.ToDecimal(txtValorInicial.Text),
                    usuario.IdUsuario
                    ));
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        
    }
}
