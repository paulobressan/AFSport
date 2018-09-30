using System.ComponentModel.DataAnnotations;

namespace AFSport.Web.Api.DTO.Auth
{
    public class AuthDTO
    {
        [Required(ErrorMessage = "Login obrigatório")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Senha obrigatória")]
        public string Senha { get; set; }
    }
}