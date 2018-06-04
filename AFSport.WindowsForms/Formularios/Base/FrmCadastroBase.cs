using AFSport.Service.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.WindowsForms.Formularios.Base
{
    public partial class FrmCadastroBase : Form
    {
        public FrmCadastroBase()
        {
            InitializeComponent();
        }

        protected virtual void BtnDeletar_Click(object sender, EventArgs e) { }

        protected virtual void BtnAlterar_Click(object sender, EventArgs e) { }

        protected virtual void BtnNovo_Click(object sender, EventArgs e) { }

        protected virtual void FrmCadastroBase_Load(object sender, EventArgs e) { }

        protected virtual void FrmCadastroBase_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    BtnNovo.PerformClick();
                    break;
                case Keys.F6:
                    BtnAlterar.PerformClick();
                    break;
                case Keys.F7:
                    BtnDeletar.PerformClick();
                    break;

            }
                
        }
    }
}
