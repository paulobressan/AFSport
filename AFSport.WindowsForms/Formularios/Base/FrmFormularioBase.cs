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

        }

        protected virtual void BtnSalvar_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BtnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confimar em cancelar a operação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void LblSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
