using System;
using System.ComponentModel.DataAnnotations;

namespace AFSport.Web.Api.DTO.Caixa
{
    public class CaixaSalvarDTO
    {
        [Required(ErrorMessage = "Id do caixa obrigatório")]
        public int IdCaixa { get; set; }

        [Required(ErrorMessage = "Valor inicial obrigatório")]
        public decimal ValorInicial { get; private set; }

        [Required(ErrorMessage = "Id do usuário obrigatório")]
        public int IdUsuario { get; set; }
    }
}