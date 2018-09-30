using AFSport.Questionario.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.Questionario.Formularios.Base
{
    public partial class FrmQuestionarioBase : Form
    {
        public FrmQuestionarioBase()
        {
            InitializeComponent();
        }

        protected virtual void FrmQuestionarioBase_Load(object sender, EventArgs e)
        {
            
        }

        protected virtual void BtnProximo_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }
    }
}
