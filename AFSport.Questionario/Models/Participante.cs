using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Questionario.Models
{
    public class Participante
    {
        public Participante()
        {

        }

        public int IdParticipante { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
