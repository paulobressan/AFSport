using AFSport.DAO.Model;
using AFSport.Service.DAO;
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
            using (FrmFormClientes frm = new FrmFormClientes(new Cliente()))
            {
                using (FrmModal frmModal = new FrmModal(frm))
                    frmModal.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                    CarregarGrid();
            }
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

        protected override async void CarregarGrid()
        {
            GridPesq.DataSource = await ListarTodosProdutos();
        }

        protected override void Remover()
        {
            base.Remover();
        }

        private async Task<List<Cliente>> ListarTodosProdutos()
        {
            using (ClienteDAO dao = new ClienteDAO())
            {
                return await dao.SelecionarTodos(true);
            }
        }
    }
}
