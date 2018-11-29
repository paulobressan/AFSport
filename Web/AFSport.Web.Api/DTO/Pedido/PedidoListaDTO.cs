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
        public PedidoStatus Status { get; set; }

        public string DataString
        {
            get
            {
                return Data.ToShortDateString();
            }
        }

        public string StatusString
        {
            get
            {
                switch (Status)
                {
                    case PedidoStatus.Aberto:
                        return "Aberto";
                    case PedidoStatus.Cancelado:
                        return "Cancelado";
                    case PedidoStatus.Finalizado:
                        return "Finalizado";
                    default:
                        return "Error";
                }
            }
        }
    }
}