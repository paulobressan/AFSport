using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.DAO.Model
{
    public class Preco
    {
        public Preco()
        {

        }

        public Preco(DateTime dataInicio, DateTime dataFim, decimal valor, Produto produto)
        {
            this.DataInicio = DataInicio;
            this.DataFinal = dataFim;
            this.Valor = valor;
            this.Produto = produto;
            this.IsAtivo = true;
        }

        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public decimal Valor { get; private set; }
        public Produto Produto { get; set; }
        public bool IsAtivo { get; set; }

        public void SetValor(decimal valor)
        {
            this.Valor = valor > 0 ? valor : 0;
        }
    }
}
