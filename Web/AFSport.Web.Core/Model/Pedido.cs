using System;
using System.Collections.Generic;
using AFSport.Web.Core.Enum;

namespace AFSport.Web.Core.Model
{
    public class Pedido
    {
        public Pedido()
        {

        }

        public int IdPedido { get; set; }
        public DateTime Data { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public PedidoStatus Status { get; set; }
    }
}