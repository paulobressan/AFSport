using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Model
{
    public class Categoria
    {
        public Categoria()
        {
            this.IsAtivo = true;
        }

        public Categoria(string nome, string descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.IsAtivo = true;
        }

        public int IdCategoria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool IsAtivo { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
