using AFSport.Service.Model;
using AFSport.Service.Repository;
using AFSport.WindowsForms.Formularios.Base;
using AFSport.WindowsForms.Formularios.Categorias;
using AFSport.WindowsForms.Formularios.Cidades;
using AFSport.WindowsForms.Formularios.Clientes;
using AFSport.WindowsForms.Formularios.Estados;
using AFSport.WindowsForms.Formularios.Estoques;
using AFSport.WindowsForms.Formularios.Login;
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
        Usuario usuario;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            RenderForm(new FrmPainelInicial());
            Login();
        }

        private void Login()
        {
            if (usuario == null)
            {
                using (FrmLogin frm = new FrmLogin())
                {
                    using (FrmModal frmModal = new FrmModal(frm))
                        frmModal.ShowDialog();
                    usuario = frm.usuario;
                    if (usuario == null)
                        Application.Exit();
                    else
                    {
                        lblUsuario.Text = usuario.Nome;
                        MessageBox.Show("Bem Vindo ao Sistema AFSport.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
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
            Cursor = Cursors.WaitCursor;
            if (form != null) form.Close();
            form = formRender;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            PnlRenderForm.Controls.Add(form);
            form.Show();
            Cursor = Cursors.Default;
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

        private void BtnIconClientes_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmClientes());
        }

        private void BtnIconEstado_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmEstados());
        }

        private void BtnIconCidade_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmCidades());
        }

        private void BtnIconEstoque_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmEstoque());
        }

        private void LblLogoft_Click(object sender, EventArgs e)
        {
            usuario = null;
            RenderForm(new FrmPainelInicial());
            lblUsuario.Text = "Nulo";
            Login();
        }
    }
}
