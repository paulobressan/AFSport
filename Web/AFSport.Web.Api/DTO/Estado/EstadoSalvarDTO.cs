using System.ComponentModel.DataAnnotations;

namespace AFSport.Web.Api.DTO.Estado
{
    public class EstadoSalvarDTO
    {
        [Required]
        public int IdEstado { get; set; }
        [Required, MaxLength(50)]
        public string Nome { get; set; }
        [Required, MaxLength(2)]
        public string Sigla { get; set; }
        [Required]
        public bool IsAtivo { get; set; }
    }
}