using System.ComponentModel.DataAnnotations;

namespace AFSport.Web.Api.DTO.Cidade
{
    public class CidadeSalvarDTO
    {
        [Required(ErrorMessage = "Id obrigatório.")]
        public int IdCidade { get; set; }
        [Required(ErrorMessage = "Nome obrigatório."), MaxLength(50, ErrorMessage = "Tamanho máximo 50 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Estado obrigatório.")]
        public int IdEstado { get; set; }
        [Required(ErrorMessage = "Situação obrigatória.")]
        public bool IsAtivo { get; set; }
    }
}