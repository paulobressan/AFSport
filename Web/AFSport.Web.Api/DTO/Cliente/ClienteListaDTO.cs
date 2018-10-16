using AFSport.Web.Api.DTO.Cidade;

namespace AFSport.Web.Api.DTO.Cliente
{
    public class ClienteListaDTO
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public CidadeListaDTO Cidade { get; set; }
        public bool IsAtivo { get; set; }
    }
}