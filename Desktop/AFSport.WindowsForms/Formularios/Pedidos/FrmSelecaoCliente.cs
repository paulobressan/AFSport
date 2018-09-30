using AFSport.Service.Model;
using AFSport.Service.Repository;
using AFSport.WindowsForms.Formularios.Base;
using AFSport.WindowsForms.Formularios.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSport.WindowsForms.Formularios.Pedidos
{
    public partial class FrmSelecaoCliente : Form
    {
        public Cliente cliente;
        public FrmSelecaoCliente()
        {
            InitializeComponent();
        }

        private void LblSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FrmSelecaoCliente_Load(object sender, EventArgs e)
        {
            await CarregarGrid();
        }

        private async void BtnProdutoPesquisar_Click(object sender, EventArgs e)
        {
            await PesquisarClientes();
        }

        private async Task PesquisarClientes()
        {
            GridPesq.DataSource = await SelecionarTodosClientesPesquisado();
        }

        private async Task CarregarGrid()
        {
            GridPesq.DataSource = await SelecionarTodosClientes();
        }

        private async Task<List<Cliente>> SelecionarTodosClientes()
        {
            using (ClienteRepository repository = new ClienteRepository())
                return await repository.SelecionarTodos(false);
        }

        private async Task<List<Cliente>> SelecionarTodosClientesPesquisado()
        {
            using (ClienteRepository repository = new ClienteRepository())
                return await repository.SelecionarPesquisaNomeId(TxtPesquisa.Text);
        }

        private void BtnAdicionarPedido_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private async void BtnAdicionarCliente_Click(object sender, EventArgs e)
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
        }

        private void TxtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnProdutoPesquisar.PerformClick();
        }

        private void GridPesq_SelectionChanged(object sender, EventArgs e)
        {
            if (GridPesq.SelectedRows.Count > 0)
                cliente = (Cliente)GridPesq.SelectedRows[0].DataBoundItem;
        }
    }
}
