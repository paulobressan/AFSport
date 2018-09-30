using System.ComponentModel.DataAnnotations;

namespace AFSport.Web.Api.DTO.Categoria
{
    public class CategoriaSalvarDTO
    {
        [Required(ErrorMessage = "Id da categoria obrigatório")]
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "Nome obrigatório"), MaxLength(50, ErrorMessage = "Tamanho maximo 50 caracteres")]
        public string Nome { get; set; }

        [MaxLength(50, ErrorMessage = "Tamanho maximo 50 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Situação da categoria(ativo/inativo) obrigatório")]
        public bool IsAtivo { get; set; }
    }
}