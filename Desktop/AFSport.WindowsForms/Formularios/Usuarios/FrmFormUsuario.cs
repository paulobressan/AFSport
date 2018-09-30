using AFSport.Service.Model;
using AFSport.Service.Repository;
using AFSport.WindowsForms.Formularios.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.WindowsForms.Formularios.Usuarios
{
    public partial class FrmFormUsuario : FrmFormularioBase
    {
        Usuario usuario;
        public FrmFormUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        protected override void FrmFormularioBase_Load(object sender, EventArgs e)
        {
            MontarFormulario();
            base.FrmFormularioBase_Load(sender, e);
        }

        protected override async void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
                MessageBox.Show("Campo nome obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (String.IsNullOrEmpty(txtLogin.Text))
                MessageBox.Show("Campo login obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (String.IsNullOrEmpty(txtSenha.Text))
                MessageBox.Show("Campo senha obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                await Salvar();
            base.BtnSalvar_Click(sender, e);
        }

        private async Task Salvar()
        {
            using(UsuarioRepository repository = new UsuarioRepository())
            {
                await repository.Salvar(new Usuario(
                        txtNome.Text,
                        txtLogin.Text,
                        txtSenha.Text
                    )
                {
                    Email = txtEmail.Text,
                    IdUsuario = usuario.IdUsuario
                });
                DialogResult = DialogResult.OK;
            }
        }

        private void MontarFormulario()
        {
            LblId.Text = usuario.IdUsuario.ToString();
            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            txtLogin.Text = usuario.Login;
            txtSenha.Text = usuario.Senha;
            chkAtivo.Checked = usuario.IsAtivo;
        }
    }
}
