using System;
using System.Collections.Generic;
using System.Drawing;
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

        protected virtual void FrmCadastroBase_Load(object sender, EventArgs e) {
            this.CarregarGrid();
        }
        protected virtual void CarregarGrid()
        {

        }
        protected virtual void Remover()
        {

        }      
    }
}
