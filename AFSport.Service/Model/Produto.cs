using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.DAO.Model
{
    public class Produto
    {
        public Produto()
        {

        }

        public Produto(string nome, decimal valorCompra, decimal valorVenda, Categoria categoria)
        {
            this.Nome = nome;
            this.ValorCompra = valorCompra;
            this.ValorVenda = ValorVenda;
            this.Categoria = categoria;
            this.IsAtivo = true;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal ValorCompra { get; private set; }
        public decimal ValorVenda { get; private set; }
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
