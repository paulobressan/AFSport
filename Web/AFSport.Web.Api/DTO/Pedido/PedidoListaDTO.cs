using System;
using AFSport.Web.Api.DTO.Cliente;
using AFSport.Web.Api.DTO.Usuario;
using AFSport.Web.Core.Enum;

namespace AFSport.Web.Api.DTO.Pedido
{
    public class PedidoListaDTO
    {
        public int IdPedido { get; set; }
        public DateTime Data { get; set; }
        public ClienteListaDTO Cliente { get; set; }
        public UsuarioListaDTO Usuario { get; set; }
        public PedidoStatus PedidoStatus { get; set; }
    }
}