using System.ComponentModel.DataAnnotations;

namespace AFSport.Web.Api.DTO.Operacao
{
    public class OperacaoSalvarDTO
    {
        [Required(ErrorMessage = "Id obrigatório.")]
        public int IdOperacao { get; set; }

        [Required(ErrorMessage = "Id obrigatório."),
        MaxLength(60, ErrorMessage = "Tamanho máximo 60 caracteres")]
        public string Nome { get; set; }

        [MaxLength(255, ErrorMessage = "Tamanho máximo 255 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Situação obrigatório.")]
        public bool IsAtivo { get; set; }
    }
}