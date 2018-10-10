using System.ComponentModel.DataAnnotations;

namespace AFSport.Web.Api.DTO.Estoque
{
    public class EstoqueFormDTO
    {
        [Required(ErrorMessage = "Id obrigatório")]
        public int IdEstoque { get; set; }

        [Required(ErrorMessage = "Quantidade obrigatório")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Id do produto obrigatório")]
        public int IdProduto { get; set; }

        [Required(ErrorMessage = "Id do usuário obrigatório")]
        public int IdUsuario { get; set; }
    }
}