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

        }

        public Categoria(string nome, string descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
