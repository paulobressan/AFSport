using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Model
{
    public class Movimentacao
    {
        public Movimentacao()
        {
            this.IsAtivo = true;
        }

        public Movimentacao(decimal valor, int idUsuario, int idOperacao)
        {
            this.Valor = valor;
            this.IdUsuario = idUsuario;
            this.IdOperacao = idOperacao;
            this.Data = DateTime.Now;
            this.IsAtivo = true;
        }

        public int IdMovimentacao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public int IdOperacao { get; set; }
        public Operacao Operacao { get; set; }
        public bool IsAtivo { get; set; }
    }
}
