using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.DAO.Model
{
    public class Movimentacao
    {
        public Movimentacao(decimal valor, Pedido pedido, Operacao operacao)
        {
            this.Valor = valor;
            this.Pedido = pedido;
            this.Operecao = operacao;
            this.Data = DateTime.Now;
            this.IsAtivo = true;
        }

        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public Pedido Pedido { get; set; }
        public Operacao Operecao { get; set; }
        public bool IsAtivo { get; set; }
    }
}
