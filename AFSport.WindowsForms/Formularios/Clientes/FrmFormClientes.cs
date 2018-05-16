using AFSport.DAO.Model;
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

namespace AFSport.WindowsForms.Formularios.Clientes
{
    public partial class FrmFormClientes : FrmFormularioBase
    {
        Cliente cliente;
        public FrmFormClientes(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        protected override void BtnSalvar_Click(object sender, EventArgs e)
        {
            base.BtnSalvar_Click(sender, e);
        }

        protected override void BtnCancelar_Click(object sender, EventArgs e)
        {
            base.BtnCancelar_Click(sender, e);
        }

        protected override void Salvar()
        {
            base.Salvar();
        }

        protected override void MontarFormulario()
        {
            base.MontarFormulario();
        }
    }
}
