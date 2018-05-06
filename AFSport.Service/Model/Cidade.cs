using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.DAO.Model
{
    public class Cidade
    {
        public Cidade(string nome, Estado estado)
        {
            this.Nome = nome;
            this.Estado = estado;
            this.IsAtivo = true;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public Estado Estado { get; set; }
        public bool IsAtivo { get; set; }
    }
}
