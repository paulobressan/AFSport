using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Model
{
    public abstract class Pessoa
    {
        public Pessoa()
        {
            this.IsAtivo = true;
        }

        public Pessoa(string nome)
        {
            this.Nome = nome;
            this.IsAtivo = true;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public bool IsAtivo { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
