using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Model
{
    public class Preco
    {
        public Preco()
        {
            this.IsAtivo = true;
        }

        public Preco(DateTime dataInicio, DateTime dataFim, decimal valor, int idProduto)
        {
            this.DataInicio = DataInicio;
            this.DataFinal = dataFim;
            this.Valor = valor;
            this.IdProduto = idProduto;
            this.IsAtivo = true;
        }

        public int IdPreco { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public decimal Valor { get; private set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
        public bool IsAtivo { get; set; }

        public void SetValor(decimal valor)
        {
            this.Valor = valor > 0 ? valor : 0;
        }
    }
}
