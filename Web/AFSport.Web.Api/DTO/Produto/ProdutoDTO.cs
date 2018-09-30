using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSport.Web.Api.DTO.Categoria;

namespace AFSport.Web.Api.DTO.Produto
{
    public class ProdutoDTO
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }
        public CategoriaDTO Categoria { get; set; }
        public bool IsAtivo { get; set; }
    }
}
