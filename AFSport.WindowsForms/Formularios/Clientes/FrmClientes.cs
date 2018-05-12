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
    public partial class FrmClientes : FrmCadastroBase
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        protected override void BtnNovo_Click(object sender, EventArgs e)
        {
            base.BtnNovo_Click(sender, e);
        }

        protected override void BtnAlterar_Click(object sender, EventArgs e)
        {
            base.BtnAlterar_Click(sender, e);
        }

        protected override void BtnDeletar_Click(object sender, EventArgs e)
        {
            base.BtnDeletar_Click(sender, e);
        }

        protected override void CarregarGrid()
        {
            base.CarregarGrid();
        }

        protected override void Remover()
        {
            base.Remover();
        }

        //private Task<List<Cliente>> ListarTodosClientes()
        //{

        //}
    }
}
