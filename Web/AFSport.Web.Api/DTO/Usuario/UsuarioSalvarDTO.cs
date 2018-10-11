using System.ComponentModel.DataAnnotations;

namespace AFSport.Web.Api.DTO.Usuario
{
    public class UsuarioSalvarDTO
    {
        [Required(ErrorMessage = "Id obrigatório")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Login obrigatório"),
        MaxLength(50, ErrorMessage = "Tamanho máximo 50 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Senha obrigatório"),
        MaxLength(30, ErrorMessage = "Tamanho máximo 30 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Nome obrigatório"),
        MaxLength(50, ErrorMessage = "Tamanho máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email obrigatório"),
        MaxLength(255, ErrorMessage = "Tamanho máximo 255 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Situação obrigatório")]
        public bool IsAtivo { get; set; }
    }
}