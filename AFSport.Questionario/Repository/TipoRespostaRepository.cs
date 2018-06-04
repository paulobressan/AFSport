using AFSport.Questionario.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Questionario.Repository
{
    public class TipoRespostaRepository : BaseRepository
    {
        public async Task<List<TipoResposta>> SelecionarPorPergunta(int idPergunta)
        {
            var result = await _context.QueryAsync<TipoResposta>(@"select idTipoResposta, idPergunta, descricao from tiposRespostas 
                where idPergunta = @idPergunta;", new { idPergunta });
            return result.ToList();
        }
    }
}
