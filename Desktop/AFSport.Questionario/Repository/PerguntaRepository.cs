using AFSport.Questionario.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Questionario.Repository
{
    public class PerguntaRepository : BaseRepository
    {
        public async Task<Pergunta> SelecionarPorSequencia(int sequencia)
        {
            var result = await _context.QueryAsync<Pergunta>(@"select idPergunta, descricao, sequencia from perguntas 
                where sequencia = @sequencia;", new { sequencia });
            return result.SingleOrDefault();
        }
    }
}
