using AFSport.Service.Model;
using AFSport.Service.Repository;
using AFSport.WindowsForms.Formularios.Base;
using AFSport.WindowsForms.Formularios.Caixas;
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
    public partial class FrmPedidos : FrmCadastroBase
    {
        Pedido pedido;
        Usuario Usuario;
        public FrmPedidos(Usuario Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
        }

        protected override async void FrmCadastroBase_Load(object sender, EventArgs e)
        {
            GridPesq.AutoGenerateColumns = false;
            await CarregarGrid();
        }

        protected override async void BtnNovo_Click(object sender, EventArgs e)
        {
            if (await VerificarCaixaDiarioAberto())
                using (FrmFormPedido frm = new FrmFormPedido(new Pedido(), Usuario))
                {
                    using (FrmModal frmModal = new FrmModal(frm))
                        frmModal.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                        await CarregarGrid();
                }
            else
                MessageBox.Show("Para realizar pedidos é necessario ter um caixa aberto.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected override async void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (pedido != null)
                using (FrmFormPedido frm = new FrmFormPedido(pedido, Usuario))
                {
                    using (FrmModal frmModal = new FrmModal(frm))
                        frmModal.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                        await CarregarGrid();
                }
            else
                MessageBox.Show("Seleciona um pedido para altera-lo.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            base.BtnAlterar_Click(sender, e);
        }

        protected override async void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (pedido != null)
                if (MessageBox.Show($"Confirma o cancelamento do pedido {pedido.IdPedido}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    await CancelarPedido();
                    await MovimentacaoEstorno();
                    await CarregarGrid();
                    MessageBox.Show("Cancelado com sucesso!", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Seleciona um pedido para cancela-lo.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            base.BtnDeletar_Click(sender, e);
        }

        private async Task CarregarGrid()
        {
            GridPesq.DataSource = await SelecionarTodosPedidosDiario();
        }

        private async Task<List<Pedido>> SelecionarTodosPedidosDiario()
        {
            using (PedidoRepository repository = new PedidoRepository())
                return await repository.SelecionarTodosDiario();
        }

        private void GridPesq_SelectionChanged(object sender, EventArgs e)
        {
            if (GridPesq.SelectedRows.Count > 0)
                pedido = (Pedido)GridPesq.SelectedRows[0].DataBoundItem;
        }

        private async Task<Caixa> SelecionarCaixaDiario()
        {
            using (CaixaRepository repository = new CaixaRepository())
                return await repository.SelecionarPorData(DateTime.Now.Date);
        }

        private async Task<bool> VerificarCaixaDiarioAberto()
        {
            var caixa = await SelecionarCaixaDiario();
            if (caixa == null)
            {
                if (MessageBox.Show("Caixa diario não esta aberto, deseja abrir o caixa?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    using (FrmAberturaCaixa frm = new FrmAberturaCaixa(Usuario))
                    {
                        using (FrmModal frmModal = new FrmModal(frm))
                            frmModal.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                            return true;
                        return false;
                    }
                }
                else
                    return false;
            }
            return true;
        }

        private async Task CancelarPedido()
        {
            using (PedidoRepository repository = new PedidoRepository())
            {
                pedido.IdStatus = 2;
                pedido.IdUsuario = pedido.Usuario.IdUsuario;
                pedido.IdCliente = pedido.Cliente.IdCliente;
                await repository.Salvar(pedido);
            }
        }

        private async Task<List<ItemPedido>> SelecionarItensPorPedido()
        {
            using (ItemPedidoRepository repository = new ItemPedidoRepository())
                return await repository.SelecionarPorPedido(pedido.IdPedido);
        }

        private async Task MovimentacaoEstorno()
        {
            using (MovimentacaoRepository repository = new MovimentacaoRepository())
            {
                pedido.ItensPedido = await SelecionarItensPorPedido();
                await repository.Salvar(new Movimentacao(
                    pedido.CalcularPedido(),
                    Usuario.IdUsuario,
                    2));
            }
        }
    }
}
