using AFSport.Questionario.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Questionario.Repository
{
    public class RespostaRepository : BaseRepository
    {
        public async Task<Resposta> Salvar(Resposta resposta)
        {
            if(resposta.IdResposta == 0)
            {
                var result = await _context.QueryAsync<Resposta>(@"insert into respostas(idParticipante, idTipoResposta, idPergunta, observacao) values (@idParticipante, @idTipoResposta, @idPergunta, @observacao);
                    select idRespota, idPergunta, idTipoResposta, idParticipante, observacao from respostas 
                    where idRespota = (select last_insert_id() as id);", resposta);
                return result.Single();
            }
            else
            {
                var result = await _context.QueryAsync<Resposta>(@"update respostas set idParticipante = @dParticipante, idTipoResposta = @idTipoResposta, idPergunta = @idPergunta, observacao = @observacao where idRespota = @idResposta;
                    select idRespota, idPergunta, idTipoResposta, idParticipante, observacao from respostas 
                    where idRespota = (select last_insert_id() as id);", resposta);
                return result.Single();
            }
        }
    }
}
