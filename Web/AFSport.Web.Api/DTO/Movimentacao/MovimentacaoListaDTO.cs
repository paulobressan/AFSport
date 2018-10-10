using System;
using AFSport.Web.Api.DTO.Operacao;
using AFSport.Web.Api.DTO.Usuario;

namespace AFSport.Web.Api.DTO.Movimentacao
{
    public class MovimentacaoListaDTO
    {
        public int IdMovimentacao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public UsuarioListaDTO Usuario { get; set; }
        public OperacaoListaDTO Operacao { get; set; }
        public bool IsAtivo { get; set; }
    }
}