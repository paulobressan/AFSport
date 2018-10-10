using AFSport.Web.Api.DTO.Produto;
using AFSport.Web.Api.DTO.Usuario;

namespace AFSport.Web.Api.DTO.Estoque
{
    public class EstoqueListaDTO
    {
        public int IdEstoque { get; set; }
        public int Quantidade { get; set; }
        public ProdutoListaDTO Produto { get; set; }
        public UsuarioListaDTO Usuario { get; set; }
    }
}