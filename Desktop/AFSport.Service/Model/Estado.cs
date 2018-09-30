using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Model
{
    public class Estado
    {
        public Estado()
        {
            this.IsAtivo = true;
        }

        public Estado(string nome, string sigla)
        {
            this.Nome = nome;
            this.Sigla = sigla;
            this.IsAtivo = true;
        }

        public int IdEstado { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public bool IsAtivo { get; set; }

        public override string ToString()
        {
            return $"{ this.Nome} - {this.Sigla}";
        }
    }
}
