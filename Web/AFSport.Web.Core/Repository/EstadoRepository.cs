using AFSport.Web.Core.Base;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Model;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Repository
{
    public class EstadoRepository : BaseRepository, IEstadoRepository
    {
        public EstadoRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task Remover(int idEstado)
        {
            await _context.QueryAsync<Estado>("delete from estado where idEstado = @idEstado", new { idEstado });
        }

        public async Task<Estado> Inserir(Estado estado)
        {
            return (await _context.QueryAsync<Estado>(@"insert into estado(nome, sigla, isAtivo) values (@nome, @sigla, @isAtivo);
                select idEstado, nome, sigla, isAtivo from estado where idEstado = (select last_insert_id() as id);", estado))
                .Single();
        }

        public async Task<Estado> Alterar(Estado estado)
        {
            return (await _context.QueryAsync<Estado>(@"update estado set nome=@nome, sigla=@sigla, isAtivo=@isAtivo where idEstado = @idEstado;
                select idEstado, nome, sigla, isAtivo from estado where idEstado = @IdEstado", estado))
                .Single();
        }

        public async Task<Estado> SelecionarId(int id)
        {
            return (await _context.QueryAsync<Estado>(@"select idEstado, nome, sigla, isAtivo from estado 
                where idEstado = @idEstado;", new { idEstado = id }))
                .SingleOrDefault();
        }

        public async Task<IEnumerable<Estado>> SelecionarTodos()
        {
            return await _context.QueryAsync<Estado>(@"select idEstado, nome, sigla, isAtivo from estado;", null);
        }

        public async Task<IEnumerable<Estado>> SelecionarTodosAtivos()
        {
            return (await _context.QueryAsync<Estado>(@"select idEstado, nome, sigla, isAtivo 
                from estado where isAtivo = true;", null))
                .ToList();
        }

        public async Task<IEnumerable<Estado>> SelecionarTodosInativos()
        {
            return (await _context.QueryAsync<Estado>(@"select idEstado, nome, sigla, isAtivo 
                from estado where isAtivo = false;", null))
                .ToList();
        }

        public async Task AtivarInativar(int idEstado, Boolean isAtivo)
        {
            await _context.QueryAsync(@"update Estado set isAtivo = @isAtivo 
                where idEstado = @idEstado;", new { idEstado, isAtivo });
        }

        public async Task<int> TotalRegistros()
        {
            var result = await _context.QueryAsync<int>(@"select count(8) from estado where isAtivo = true;", null);
            return result.Single();
        }
    }
}
