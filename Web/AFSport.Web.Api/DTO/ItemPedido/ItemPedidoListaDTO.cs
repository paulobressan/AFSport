using AFSport.Web.Api.DTO.Pedido;
using AFSport.Web.Api.DTO.Produto;

namespace AFSport.Web.Api.DTO.ItemPedido
{
    public class ItemPedidoListaDTO
    {
        public int IdItemPedido { get; set; }
        public int Quantidade { get; set; }
        public ProdutoListaDTO Produto { get; set; }
        public PedidoListaDTO Pedidio { get; set; }
        public bool IsAtivo { get; set; }
    }
}