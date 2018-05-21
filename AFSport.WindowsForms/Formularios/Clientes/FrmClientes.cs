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

namespace AFSport.WindowsForms.Formularios.Clientes
{
    public partial class FrmClientes : FrmCadastroBase
    {
        Cliente cliente;
        public FrmClientes()
        {
            InitializeComponent();
        }

        protected override async void FrmCadastroBase_Load(object sender, EventArgs e)
        {
            GridPesq.AutoGenerateColumns = false;
            await CarregarGrid();
            base.FrmCadastroBase_Load(sender, e);
        }

        protected override async void BtnNovo_Click(object sender, EventArgs e)
        {
            using (CidadeRepository repository = new CidadeRepository())
            {
                if (await repository.TotalRegistros() > 0)
                    using (FrmFormClientes frm = new FrmFormClientes(new Cliente()))
                    {
                        using (FrmModal frmModal = new FrmModal(frm))
                            frmModal.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                            await CarregarGrid();
                    }
                else
                    MessageBox.Show("Por favor, antes de cadastrar um cliente, cadastre uma cidade para seus clientes.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            base.BtnNovo_Click(sender, e);
        }

        protected override async void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (cliente != null)
                using (FrmFormClientes frm = new FrmFormClientes(cliente))
                {
                    using (FrmModal frmModal = new FrmModal(frm))
                        frmModal.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                        await CarregarGrid();
                }
            else
                MessageBox.Show("Seleciona um cliente para altera-lo.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);

            base.BtnAlterar_Click(sender, e);
        }

        protected override void BtnDeletar_Click(object sender, EventArgs e)
        {
            base.BtnDeletar_Click(sender, e);
        }

        private async Task CarregarGrid()
        {
            GridPesq.DataSource = await SelecionarTodosClientes();
        }

        private void Remover()
        {

        }

        private async Task<List<Cliente>> SelecionarTodosClientes()
        {
            using (ClienteRepository repository = new ClienteRepository())
            {
                return await repository.SelecionarTodos(true);
            }
        }

        private void GridPesq_SelectionChanged(object sender, EventArgs e)
        {
            if (GridPesq.SelectedRows.Count > 0)
                cliente = (Cliente)GridPesq.SelectedRows[0].DataBoundItem;
        }
    }
}
