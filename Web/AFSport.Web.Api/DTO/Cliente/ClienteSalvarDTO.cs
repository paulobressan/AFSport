using System.ComponentModel.DataAnnotations;

namespace AFSport.Web.Api.DTO.Cliente
{
    public class ClienteSalvarDTO
    {
        [Required(ErrorMessage = "Id Obrigatório.")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Nome Obrigatório"),
        MaxLength(100, ErrorMessage = "Tamanho máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email Obrigatório"),
        MaxLength(255, ErrorMessage = "Tamanho máximo 255 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Logradouro Obrigatório."),
        MaxLength(255, ErrorMessage = "Tamanho máximo 255 caracteres")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Número Obrigatório.")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Bairro Obrigatório."),
        MaxLength(50, ErrorMessage = "Tamanho máximo 50 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Cidade Obrigatória.")]
        public int IdCidade { get; set; }

        [Required(ErrorMessage = "Situação Obrigatória.")]
        public bool IsAtivo { get; set; }
    }
}