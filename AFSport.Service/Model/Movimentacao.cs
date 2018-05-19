using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Model
{
    public class Movimentacao
    {
        public Movimentacao()
        {
            this.IsAtivo = true;
        }

        public Movimentacao(decimal valor, Pedido pedido, Operacao operacao)
        {
            this.Valor = valor;
            this.Pedido = pedido;
            this.Operacao = operacao;
            this.Data = DateTime.Now;
            this.IsAtivo = true;
        }

        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public Pedido Pedido { get; set; }
        public Operacao Operacao { get; set; }
        public bool IsAtivo { get; set; }
    }
}
