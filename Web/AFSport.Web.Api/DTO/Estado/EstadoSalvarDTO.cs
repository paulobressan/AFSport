namespace AFSport.Web.Api.DTO.Estado
{
    public class EstadoSalvarDTO
    {
        public int IdEstado { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public bool IsAtivo { get; set; }
    }
}