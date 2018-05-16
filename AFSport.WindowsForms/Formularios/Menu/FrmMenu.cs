using AFSport.WindowsForms.Formularios.Categorias;
using AFSport.WindowsForms.Formularios.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.WindowsForms.Formularios.Menu
{
    public partial class FrmMenu : Form
    {
        private bool SideBar = false;
        Form form;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void ControleSideBar()
        {
            switch (SideBar)
            {
                case true:
                    pnlSideBar.Width = 55;
                    SideBar = false;
                    break;
                case false:
                    pnlSideBar.Width = 200;
                    SideBar = true;
                    break;
            }
        }

        private void TmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void RenderForm(Form formRender)
        {
            if (form != null) form.Close();
            form = formRender;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            PnlRenderForm.Controls.Add(form);
            form.Show();
        }

        private void LblSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOpenSideBar_Click(object sender, EventArgs e)
        {
            ControleSideBar();
        }

        private void BtnIconInicio_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmPainelInicial());
        }

        private void BtnIconCategorias_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmCategorias());
        }

        private void BtnIconProdutos_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmProdutos());
        }
    }
}
