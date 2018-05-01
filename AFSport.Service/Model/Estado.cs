using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Model
{
    public class Estado
    {
        public Estado(string nome, string sigla)
        {
            this.Nome = nome;
            this.Sigla = sigla;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
    }
}
