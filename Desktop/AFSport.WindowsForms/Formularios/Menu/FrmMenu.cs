using AFSport.Questionario.Formularios;
using AFSport.Service.Model;
using AFSport.Service.Repository;
using AFSport.WindowsForms.Formularios.Base;
using AFSport.WindowsForms.Formularios.Caixas;
using AFSport.WindowsForms.Formularios.Categorias;
using AFSport.WindowsForms.Formularios.Cidades;
using AFSport.WindowsForms.Formularios.Clientes;
using AFSport.WindowsForms.Formularios.Estados;
using AFSport.WindowsForms.Formularios.Estoques;
using AFSport.WindowsForms.Formularios.Login;
using AFSport.WindowsForms.Formularios.Movimentacoes;
using AFSport.WindowsForms.Formularios.Operacoes;
using AFSport.WindowsForms.Formularios.Pedidos;
using AFSport.WindowsForms.Formularios.Precos;
using AFSport.WindowsForms.Formularios.Produtos;
using AFSport.WindowsForms.Formularios.Relatorios;
using AFSport.WindowsForms.Formularios.Usuarios;
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
            RenderForm(new FrmPainelInicial(usuario));
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
                        RenderForm(new FrmPainelInicial(usuario));
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
            RenderForm(new FrmPainelInicial(usuario));
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmPainelInicial(usuario));
        }

        private void BtnIconCategorias_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmCategorias());
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmCategorias());
        }

        private void BtnIconProdutos_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmProdutos(usuario));
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmProdutos(usuario));
        }

        private void BtnIconClientes_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmClientes());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmClientes());
        }

        private void BtnIconEstado_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmEstados());
        }

        private void BtnEstados_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmEstados());
        }

        private void BtnIconCidade_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmCidades());
        }

        private void BtnCidades_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmCidades());
        }

        private void BtnIconEstoque_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmEstoque(usuario));
        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmEstoque(usuario));
        }

        private void LblLogoft_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmPainelInicial(usuario));
            usuario = null;
            lblUsuario.Text = "Nulo";
            Login();
        }

        private void BtnIconQuestionario_Click(object sender, EventArgs e)
        {
            using(FrmParticipante frm = new FrmParticipante())
            {
                using (FrmModal frmModal = new FrmModal(frm))
                    frmModal.ShowDialog();
            }
        }

        private void BtnQuestionario_Click(object sender, EventArgs e)
        {
            using (FrmParticipante frm = new FrmParticipante())
            {
                using (FrmModal frmModal = new FrmModal(frm))
                    frmModal.ShowDialog();
            }
        }

        private void BtnIconUsuarios_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmUsuarios());
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmUsuarios());
        }

        private void LblIcoLogin_Click(object sender, EventArgs e)
        {
            using (FrmSorteio frm = new FrmSorteio())
            {
                using (FrmModal frmModal = new FrmModal(frm))
                    frmModal.ShowDialog();
            }
        }

        private void BtnIconOperacao_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmOperacoes());
        }

        private void BtnOperacoes_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmOperacoes());
        }

        private void BtnIconPedidos_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmPedidos(usuario));
        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmPedidos(usuario));
        }

        private void BtnIconMovimentacao_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmMovimentacoes(usuario));
        }

        private void BtnMovimentacoes_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmMovimentacoes(usuario));
        }

        private void BtnIconCaixa_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmCaixa(usuario));
        }

        private void BtnCaixa_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmCaixa(usuario));
        }

        private void BtnIconPrecos_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmPrecos());
        }

        private void BtnPrecos_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmPrecos());
        }

        private void BtnIconAjuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/paulobressan/AFSport");
        }

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/paulobressan/AFSport");
        }

        private void BtnIconRelatorios_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmRelatorios());
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            RenderForm(new FrmRelatorios());
        }
    }
}
