using System;
using System.ComponentModel.DataAnnotations;

namespace AFSport.Web.Api.DTO.Pedido
{
    public class PedidoFormDTO
    {
        [Required(ErrorMessage = "Id obrigatótio")]
        public int IdPedido { get; set; }

        [Required(ErrorMessage = "Id do cliente obrigatótio")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Id do usuário obrigatótio")]
        public int IdUsuario { get; set; }
    }
}