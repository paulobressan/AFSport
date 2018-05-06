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

        protected virtual void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
