using AFSport.Web.Core.Base;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Repository
{
    public class EstadoRepository : BaseRepository, IEstadoRepository
    {
        public async Task Remover(Estado obj)
        {
            await _context.QueryAsync<Estado>("delete from estado where idEstado = @idEstado", obj);
        }

        public async Task<Estado> Salvar(Estado obj)
        {
            var result = obj.IdEstado == 0
                ? await _context.QueryAsync<Estado>(@"insert into estado(nome, sigla, isAtivo) values (@nome, @sigla, @isAtivo);
                    select idEstado, nome, sigla, isAtivo from estado where idEstado = (select last_insert_id() as id);", obj)
                : await _context.QueryAsync<Estado>(@"update estado set nome=@nome, sigla=@sigla, isAtivo=@isAtivo where idEstado = @idEstado;
                    select idEstado, nome, sigla, isAtivo from estado where idEstado = @IdEstado", obj);
            return result.Single();
        }

        public async Task<Estado> SelecionarId(int id)
        {
            var result = await _context.QueryAsync<Estado>(@"select idEstado, nome, sigla, isAtivo from estado 
                where idEstado = @idEstado;", new { idCategoria = id });
            return result.SingleOrDefault();
        }

        public async Task<List<Estado>> SelecionarTodos(bool selecionarTodos)
        {
            var result = selecionarTodos
                ? await _context.QueryAsync<Estado>(@"select idEstado, nome, sigla, isAtivo from estado;", null)
                : await _context.QueryAsync<Estado>(@"select idEstado, nome, sigla, isAtivo from estado where isAtivo = true;", null);
            return result.ToList();
        }

        public async Task<int> TotalRegistros()
        {
            var result = await _context.QueryAsync<int>(@"select count(8) from estado where isAtivo = true;", null);
            return result.Single();
        }
    }
}
