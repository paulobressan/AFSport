using AFSport.Web.Api.DTO.Categoria;

namespace AFSport.Web.Api.DTO.Produto
{
    public class ProdutoListaDTO
    {
        public int IdProduto { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal ValorCompra { get; set; }

        public decimal ValorVenda { get; set; }

        public CategoriaListaDTO Categoria { get; set; }

        public bool IsAtivo { get; set; }
    }
}