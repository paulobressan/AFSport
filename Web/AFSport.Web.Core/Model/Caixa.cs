using System;
namespace AFSport.Web.Core.Model
{
    public class Caixa
    {
        public Caixa()
        {

        }

        public Caixa(decimal valorInicial, int idUsuario)
        {
            this.ValorInicial = valorInicial;
            this.IdUsuario = idUsuario;
            this.Data = DateTime.Now;
        }

        public int IdCaixa { get; set; }
        public decimal ValorInicial { get; private set; }
        public DateTime Data { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public void SetValorInicial(decimal valor)
        {
            this.ValorInicial = valor > 0 ? valor : 0;
        }
    }
}
