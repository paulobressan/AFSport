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

namespace AFSport.WindowsForms.Formularios.Pedidos
{
    public partial class FrmFormPedido : FrmFormularioBase
    {
        Usuario usuario;
        Pedido pedido;
        Produto produto;
        ItemPedido item;

        List<ItemPedido> LimparGridItens = new List<ItemPedido>();
        public FrmFormPedido(Pedido pedido, Usuario usuario)
        {
            InitializeComponent();
            this.pedido = pedido;
            this.usuario = usuario;
        }

        protected override async void FrmFormularioBase_Load(object sender, EventArgs e)
        {
            GridItens.AutoGenerateColumns = false;
            GridProdutos.AutoGenerateColumns = false;
            await CarregarGridProdutos();
            await MontarFormulario();
            base.FrmFormularioBase_Load(sender, e);
        }

        protected override async void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (pedido.Cliente == null)
                MessageBox.Show("Seleção de cliente obrigatória.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (pedido.ItensPedido.Count == 0)
                MessageBox.Show("Adicione itens ao pedido.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                await SalvarPedido();
            base.BtnSalvar_Click(sender, e);
        }

        private async Task SalvarPedido()
        {
            if (await SalvarMovimentacao())
                using (PedidoRepository repository = new PedidoRepository())
                {
                    MontarPedido();
                    var pedidoSalvo = await repository.Salvar(pedido);
                    pedido.IdPedido = pedidoSalvo.IdPedido;
                    await SalvarItensPedido();
                    await BaixarEstoqueDeProdutos();
                    DialogResult = DialogResult.OK;
                }
            else
                MessageBox.Show("Pedido não pode ser finalizado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void MontarPedido()
        {
            pedido.Usuario = usuario;
            pedido.IdUsuario = usuario.IdUsuario;
            pedido.IdCliente = pedido.Cliente.IdCliente;
            pedido.IdStatus = 1;//Status confirmado.
            pedido.Data = DateTime.Now;
        }

        private async Task<bool> SalvarMovimentacao()
        {
            using (MovimentacaoRepository repository = new MovimentacaoRepository())
            {
                var movimentacao = Finalizadora();
                if (movimentacao == null)
                    return false;
                else
                {
                    await repository.Salvar(movimentacao);
                    return true;
                }
            }
        }

        private Movimentacao Finalizadora()
        {
            using (FrmFinalizadora frm = new FrmFinalizadora(pedido, usuario))
            {
                using (FrmModal frmoModal = new FrmModal(frm))
                    frmoModal.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                    return frm.movimentacao;
                return null;
            }
        }

        private void BtnSelecaoCliente_Click(object sender, EventArgs e)
        {
            using (FrmSelecaoCliente frm = new FrmSelecaoCliente())
            {
                using (FrmModal frmModal = new FrmModal(frm))
                    frmModal.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    pedido.Cliente = frm.cliente;
                    MontarCliente();
                }
            }
        }

        private void MontarCliente()
        {
            lblClienteNomeTexto.Text = pedido.Cliente.Nome;
            lblClienteEnderecoTexto.Text = $"{pedido.Cliente.Logradouro},{pedido.Cliente.Numero},{pedido.Cliente.Bairro}";
        }

        private async Task<List<ItemPedido>> SelecionarItensPorPedido()
        {
            using (ItemPedidoRepository repository = new ItemPedidoRepository())
                return await repository.SelecionarPorPedido(pedido.IdPedido);
        }

        private async Task MontarFormulario()
        {
            if (pedido.IdPedido != 0)
            {
                BtnSalvar.Enabled = false;
                BtnRemoverItem.Enabled = false;
                pnlCliente.Enabled = false;
                pnlSelecaoProdutos.Enabled = false;
                pedido.ItensPedido = await SelecionarItensPorPedido();
                CarregarItensPedido(pedido.ItensPedido);
                MontarCliente();
            }
            LblId.Text = pedido.IdPedido.ToString();
        }

        private async Task CarregarGridProdutos()
        {
            GridProdutos.DataSource = await SelecionarTodosProdutos();
        }

        private async Task CarregaGridProdutosPesquisados()
        {
            GridProdutos.DataSource = await SelecionarProdutoPesquisados();
        }

        private async Task<List<Produto>> SelecionarTodosProdutos()
        {
            using (ProdutoRepository repository = new ProdutoRepository())
                return await repository.SelecionarTodos(false);
        }

        private async Task<List<Produto>> SelecionarProdutoPesquisados()
        {
            using (ProdutoRepository repository = new ProdutoRepository())
                return await repository.SelecionarPorNomeId(TxtProdutoPesquisa.Text);
        }

        private async void TxtProdutoPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                await CarregaGridProdutosPesquisados();
        }

        private async void BtnProdutoPesquisar_Click(object sender, EventArgs e)
        {
            await CarregaGridProdutosPesquisados();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarProdutos();
        }

        private void AdicionarProdutos()
        {
            if (produto == null)
                MessageBox.Show("Selecione um produto.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (Convert.ToInt16(txtQuantidade.Text) == 0 || Convert.ToInt16(txtQuantidade.Text) <= 0)
                MessageBox.Show("Adicione uma quantidade valida.", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                pedido.ItensPedido.Add(new ItemPedido(
                    Convert.ToInt32(txtQuantidade.Text),
                    produto.IdProduto,
                    0
                )
                {
                    Produto = produto
                });
                CarregarItensPedido(pedido.ItensPedido);
            }
        }

        private void CarregarItensPedido(List<ItemPedido> itens)
        {
            GridItens.DataSource = LimparGridItens;
            GridItens.DataSource = itens;
            CarregarPrecoPedido();
        }

        private void CarregarPrecoPedido()
        {
            lblPreco.Text = pedido.CalcularPedido().ToString();
        }

        private void GridProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (GridProdutos.SelectedRows.Count > 0)
                produto = (Produto)GridProdutos.SelectedRows[0].DataBoundItem;
        }

        private void BtnAdicionar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void GridItens_SelectionChanged(object sender, EventArgs e)
        {
            if (GridItens.SelectedRows.Count > 0)
                item = (ItemPedido)GridItens.SelectedRows[0].DataBoundItem;
        }

        private void BtnRemoverItem_Click(object sender, EventArgs e)
        {
            if (item != null)
            {
                pedido.ItensPedido.Remove(item);
                CarregarItensPedido(pedido.ItensPedido);
            }
        }

        private void FrmFormPedido_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F4:
                    BtnAdicionar.PerformClick();
                    break;
            }
        }

        private async Task<Estoque> SelecionarEstoqueDeProduto(Produto produto)
        {
            using (EstoqueRepository repository = new EstoqueRepository())
                return await repository.SelecionarEstoquePorProduto(produto.IdProduto);
        }

        private async Task<Estoque> SalvarEstoque(Estoque estoque)
        {
            using (EstoqueRepository repository = new EstoqueRepository())
                return await repository.Salvar(estoque);
        }   
        
        private async Task BaixarEstoqueDeProdutos()
        {
            foreach(var item in pedido.ItensPedido)
            {
                var estoque = await SelecionarEstoqueDeProduto(item.Produto);
                if (estoque != null)
                {
                    estoque.Decrementa(item.Quantidade);
                    estoque = await SalvarEstoque(estoque);
                    if (estoque.Quantidade < 0)
                        MessageBox.Show($"O estoque do produto {item.Produto} esta negativo. Estoque: {estoque.Quantidade}.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private async Task SalvarItemPedido(ItemPedido itemPedido)
        {
            using (ItemPedidoRepository repository = new ItemPedidoRepository())
                await repository.Salvar(itemPedido);
        }

        private async Task SalvarItensPedido()
        {
            foreach (var item in pedido.ItensPedido)
            {
                item.IdPedido = pedido.IdPedido;
                await SalvarItemPedido(item);
            }
        }

    }
}
