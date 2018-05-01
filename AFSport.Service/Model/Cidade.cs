using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Model
{
    public class Cidade
    {
        public Cidade(string nome, Estado estado)
        {
            this.Nome = nome;
            this.Estado = estado;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public Estado Estado { get; set; }
    }
}
