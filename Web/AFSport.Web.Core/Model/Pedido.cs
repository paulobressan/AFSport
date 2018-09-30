using System;
using System.Collections.Generic;

namespace AFSport.Web.Core.Model
{
    public class Pedido
    {
        public Pedido()
        {
            this.ItensPedido = new List<ItemPedido>();
        }

        public Pedido(int idCliente, int idUsuario)
        {
            this.Data = DateTime.Now;
            this.IdCliente = idCliente;
            this.IdUsuario = idUsuario;
            this.ItensPedido = new List<ItemPedido>();
        }

        public int IdPedido { get; set; }
        public DateTime Data { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public int IdStatus { get; set; }
        public Pedido_Status PedidoStatus { get; set; }
        public List<ItemPedido> ItensPedido { get; set; }

        public decimal CalcularPedido()
        {
            decimal valor = 0;
            ItensPedido.ForEach(item =>
            {
                valor += (item.Produto.ValorVenda * item.Quantidade);
            });
            return valor;
        }      

        public decimal CalcularTroco(decimal valor)
        {
            return valor - this.CalcularPedido();
        }
    }
}
