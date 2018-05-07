using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.WindowsForms.Formularios.Base
{
    public partial class FrmFormularioBase : Form
    {
        public FrmFormularioBase()
        {
            InitializeComponent();
        }

        protected virtual void FrmFormularioBase_Load(object sender, EventArgs e)
        {
            MontarFormulario();
        }

        protected virtual void BtnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        protected virtual void BtnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirma em cancelar a operação?","Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                Close();  
            }
        }

        private void LblSair_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected virtual void MontarFormulario()
        {

        }

        protected virtual void Salvar()
        {

        }
    }
}
