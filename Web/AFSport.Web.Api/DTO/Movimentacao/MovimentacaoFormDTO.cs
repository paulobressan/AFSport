using System;
using System.ComponentModel.DataAnnotations;

namespace AFSport.Web.Api.DTO.Movimentacao
{
    public class MovimentacaoFormDTO
    {
        [Required(ErrorMessage = "Id da movimentação obrigatório.")]
        public int IdMovimentacao { get; set; }

        [Required(ErrorMessage = "Valor obrigatório.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Data obrigatória.")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Id do usuário obrigatório.")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Id da operação obrigatório.")]
        public int IdOperacao { get; set; }

        [Required(ErrorMessage = "Situação obrigatório.")]
        public bool IsAtivo { get; set; }
    }
}