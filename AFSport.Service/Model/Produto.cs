using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Model
{
    public class Produto
    {
        public Produto()
        {
            this.IsAtivo = true;
        }

        public Produto(string nome, decimal valorCompra, decimal valorVenda, int idCategoria)
        {
            this.Nome = nome;
            this.ValorCompra = valorCompra;
            this.ValorVenda = valorVenda;
            this.IdCategoria = idCategoria;
            this.IsAtivo = true;
        }
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal ValorCompra { get; private set; }
        public decimal ValorVenda { get; private set; }
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
        public bool IsAtivo { get; set; }

        public void SetValorCompra(decimal valor)
        {
            this.ValorCompra = valor > 0 ? valor : 0;
        }

        public void SetValorVenda(decimal valor)
        {
            this.ValorVenda = valor > 0 ? valor : 0;
        }
    }
}
