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

namespace AFSport.WindowsForms.Formularios.Login
{
    public partial class FrmLogin : Form
    {
        public Usuario usuario;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void LblSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma sair do sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private async Task AutenticarUsuario()
        {
            using (UsuarioRepository repository = new UsuarioRepository())
            {
                var usuarioAutenticado = await repository.AutenticarUsuario(txtLogin.Text, txtSenha.Text);
                if (usuarioAutenticado != null)
                {
                    usuario = usuarioAutenticado;
                    Close();
                }
                else
                    MessageBox.Show("Usuário ou Senha incorreto.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLogin.Text))
                MessageBox.Show("Campo usuário obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (String.IsNullOrEmpty(txtSenha.Text))
                MessageBox.Show("Campo senha obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Cursor = Cursors.WaitCursor;
                await AutenticarUsuario();
                Cursor = Cursors.Default;
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnEntrar.PerformClick();
        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
