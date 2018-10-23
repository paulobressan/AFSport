using System;

namespace AFSport.Web.Core.Model
{
    public class Movimentacao
    {
        public Movimentacao()
        {

        }

        public Movimentacao(decimal valor, int idUsuario, int idOperacao)
        {
            this.Valor = valor;
            this.IdUsuario = idUsuario;
            this.IdOperacao = idOperacao;
            this.Data = DateTime.Now;
        }

        public int IdMovimentacao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public int IdOperacao { get; set; }
        public Operacao Operacao { get; set; }
    }
}
