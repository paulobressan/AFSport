using AFSport.Web.Api.DTO.Estado;

namespace AFSport.Web.Api.DTO.Cidade
{
    public class CidadeListaDTO
    {
        public int IdCidade { get; set; }
        public string Nome { get; set; }
        public EstadoListaDTO Estado { get; set; }
        public bool IsAtivo { get; set; }
    }
}