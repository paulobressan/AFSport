namespace AFSport.Web.Core.Model
{
    public class ItemPedido
    {
        public ItemPedido()
        {

        }

        public ItemPedido(int quantidade, int idProduto, int idPedido)
        {
            this.Quantidade = quantidade;
            this.IdProduto = idProduto;
            this.IdPedido = idPedido;
        }

        public int IdItemPedido { get; set; }
        public int Quantidade { get; set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
        public int IdPedido { get; set; }
        public Pedido Pedidio { get; set; }
        public bool IsAtivo { get; set; }
    }
}
