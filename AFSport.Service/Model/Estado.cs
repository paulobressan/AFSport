using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.DAO.Model
{
    public class Estado
    {
        public Estado()
        {

        }

        public Estado(string nome, string sigla)
        {
            this.Nome = nome;
            this.Sigla = sigla;
            this.IsAtivo = true;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public bool IsAtivo { get; set; }
    }
}
