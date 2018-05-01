using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Model
{
    public class Caixa
    {
        public int Id { get; set; }
        public decimal ValorInicial { get; private set; }
        public DateTime Data { get; set; }
        public Usuario Usuario { get; set; }

        public void SetValorInicial(decimal valor)
        {
            this.ValorInicial = valor > 0 ? valor : 0;
        }
    }
}
