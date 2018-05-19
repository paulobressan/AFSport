using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Model
{
    public class Caixa
    {
        public Caixa()
        {
            this.IsAtivo = true;        
        }

        public Caixa(decimal valorInicial, Usuario usuario)
        {
            this.ValorInicial = valorInicial;
            this.Usuario = usuario;
            this.Data = DateTime.Now;
            this.IsAtivo = true;
        }

        public int Id { get; set; }
        public decimal ValorInicial { get; private set; }
        public DateTime Data { get; set; }
        public Usuario Usuario { get; set; }
        public bool IsAtivo { get; set; }

        public void SetValorInicial(decimal valor)
        {
            this.ValorInicial = valor > 0 ? valor : 0;
        }
    }
}
