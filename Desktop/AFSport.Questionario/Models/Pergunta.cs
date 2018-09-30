using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Questionario.Models
{
    public class Pergunta
    {
        public Pergunta()
        {

        }

        public int IdPergunta { get; set; }
        public string Descricao { get; set; }
        public int Sequencia { get; set; }
    }
}
