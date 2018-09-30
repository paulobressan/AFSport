using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Questionario.Models
{
    public class Resposta
    {
        public Resposta()
        {

        }

        public Resposta(int idParticipante, int? idTipoResposta, int idPergunta)
        {
            this.IdParticipante = idParticipante;
            this.IdTipoResposta = idTipoResposta;
            this.IdPergunta = idPergunta;
        }

        public int IdResposta { get; set; }
        public int IdParticipante { get; set; }
        public int? IdTipoResposta { get; set; }
        public int IdPergunta { get; set; }
        public string Observacao { get; set; }
    }
}
