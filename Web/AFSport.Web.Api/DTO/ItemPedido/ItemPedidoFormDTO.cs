using System.ComponentModel.DataAnnotations;

namespace AFSport.Web.Api.DTO.ItemPedido
{
    public class ItemPedidoFormDTO
    {
        [Required(ErrorMessage = "Id do item do pedido obrigatório.")]
        public int IdItemPedido { get; set; }

        [Required(ErrorMessage = "Quantidade do item do pedido obrigatório.")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Id produto do item do pedido obrigatório.")]
        public int IdProduto { get; set; }

        [Required(ErrorMessage = "Id pedido do item do pedido obrigatório.")]
        public int IdPedidio { get; set; }

        [Required(ErrorMessage = "Situação do item do pedido obrigatório.")]
        public bool IsAtivo { get; set; }
    }
}