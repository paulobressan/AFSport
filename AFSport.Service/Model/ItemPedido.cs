using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.DAO.Model
{
    public class ItemPedido
    {
        public ItemPedido()
        {

        }

        public ItemPedido(int quantidade, Produto produto, Pedido pedido)
        {
            this.Quantidade = quantidade;
            this.Produto = produto;
            this.Pedidio = pedido;
            this.IsAtivo = true;
        }

        public int Id { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
        public Pedido Pedidio { get; set; }
        public bool IsAtivo { get; set; }
    }
}
