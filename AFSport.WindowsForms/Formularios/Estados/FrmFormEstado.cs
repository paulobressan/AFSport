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

namespace AFSport.WindowsForms.Formularios.Estados
{
    public partial class FrmFormEstado : FrmFormularioBase
    {
        Estado estado;
        public FrmFormEstado(Estado estado)
        {
            InitializeComponent();
            this.estado = estado;
        }

        protected override void FrmFormularioBase_Load(object sender, EventArgs e)
        {
            MontarFormulario();
        }

        protected override void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
                MessageBox.Show("Campo nome obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (String.IsNullOrEmpty(txtSigla.Text))
                MessageBox.Show("Campo sigla obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                Salvar();
            base.BtnSalvar_Click(sender, e);
        }

        protected override void MontarFormulario()
        {
            LblId.Text = estado.IdEstado.ToString();
            txtNome.Text = estado.Nome;
            txtSigla.Text = estado.Sigla;
            chkAtivo.Checked = estado.IsAtivo;
        }

        protected override async void Salvar()
        {
            using(EstadoRepository repository = new EstadoRepository())
            {
                await repository.Salvar(new Estado(
                    txtNome.Text,
                    txtSigla.Text
                    )
                {
                    IdEstado = estado.IdEstado,
                    IsAtivo = chkAtivo.Checked
                });
                DialogResult = DialogResult.OK;
            }
        }
    }
}
