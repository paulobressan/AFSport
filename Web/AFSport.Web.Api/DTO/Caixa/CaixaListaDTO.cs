using System;
using AFSport.Web.Api.DTO.Usuario;

namespace AFSport.Web.Api.DTO.Caixa
{
    public class CaixaListaDTO
    {
        public int IdCaixa { get; set; }
        public decimal ValorInicial { get; private set; }
        public DateTime Data { get; set; }
        public UsuarioListaDTO Usuario { get; set; }
    }
}