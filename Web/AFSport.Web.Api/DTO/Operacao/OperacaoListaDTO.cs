namespace AFSport.Web.Api.DTO.Operacao
{
    public class OperacaoListaDTO
    {
        public int IdOperacao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool IsAtivo { get; set; }
    }
}