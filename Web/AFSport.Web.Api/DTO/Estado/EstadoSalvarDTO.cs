using System.ComponentModel.DataAnnotations;

namespace AFSport.Web.Api.DTO.Estado
{
    public class EstadoSalvarDTO
    {
        [Required(ErrorMessage = "Id Obrigatório.")]
        public int IdEstado { get; set; }
        [Required(ErrorMessage = "Nome Obrigatório."), 
        MaxLength(50, ErrorMessage = "Nome Obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Sigla Obrigatória."), 
        MaxLength(2, ErrorMessage = "Tamanho máximo 2 caracteres")]
        public string Sigla { get; set; }
        [Required(ErrorMessage = "Situação Obrigatória.")]
        public bool IsAtivo { get; set; }
    }
}