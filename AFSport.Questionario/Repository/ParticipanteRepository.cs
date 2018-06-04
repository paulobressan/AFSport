using AFSport.Questionario.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Questionario.Repository
{
    public class ParticipanteRepository : BaseRepository
    {
        public async Task<Participante> Salvar(Participante participante)
        {
            if(participante.IdParticipante == 0)
            {
                var result = await _context.QueryAsync<Participante>(@"insert into participantes( nome, Telefone) values (@nome, @Telefone);
                    select idParticipante, nome, Telefone from participantes 
                    where idParticipante = (select last_insert_id() as id);", participante);
                return result.Single();
            }
            else
            {
                var result = await _context.QueryAsync<Participante>(@"update participantes set nome = @nome, Telefone = @Telefone where idParticipante = @idParticipante;
                    select idParticipante, nome, Telefone from participantes 
                    where idParticipante = @idParticipante;", participante);
                return result.Single();
            }
        }

        public async Task<List<Participante>> SelecionarTodos()
        {
            var result = await _context.QueryAsync<Participante>(@"select idParticipante, nome, Telefone from participantes 
                order by idParticipante;", null);
            return result.ToList();
        }
    }
}
