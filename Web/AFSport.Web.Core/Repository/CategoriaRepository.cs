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
    public class CategoriaRepository : BaseRepository, ICategoriaRepository
    {
        public CategoriaRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task Remover(Categoria obj)
        {
            await _context.QueryAsync<Categoria>(@"delete from categoria 
                where idCategoria = @idCategoria", obj);
        }

        public async Task<Categoria> Inserir(Categoria obj)
        {
            return (await _context.QueryAsync<Categoria>(@"insert into categoria(nome,descricao,isAtivo) 
                values (@nome,@descricao,@isAtivo);
                select idCategoria, nome, descricao, isAtivo from categoria
                where idCategoria = (select last_insert_id() as idCategoria);", obj))
                .Single();
        }

        public async Task<Categoria> Alterar(Categoria obj)
        {
            return (await _context.QueryAsync<Categoria>(@"update categoria set nome = @nome, descricao = @descricao, isAtivo = @isAtivo 
                where idCategoria = @idCategoria;
                select idCategoria, nome, descricao, isAtivo from categoria
                where idCategoria = @IdCategoria", obj))
                .Single();
        }

        public async Task<Categoria> SelecionarId(int id)
        {
            return (await _context.QueryAsync<Categoria>(@"select idCategoria, nome, descricao, isAtivo from categoria 
                where idCategoria = @idCategoria;", new { idCategoria = id }))
                .SingleOrDefault();
        }

        public async Task<IEnumerable<Categoria>> SelecionarTodos()
        {
            return await _context.QueryAsync<Categoria>(@"select idCategoria, nome, descricao, isAtivo from categoria;", null);
        }

        public async Task<IEnumerable<Categoria>> SelecionarTodosAtivo()
        {
            return await _context.QueryAsync<Categoria>(@"select idCategoria, nome, descricao, isAtivo from categoria 
                where isAtivo = true;", null);
        }

        public async Task<IEnumerable<Categoria>> SelecionarTodosInativo()
        {
            return await _context.QueryAsync<Categoria>(@"select idCategoria, nome, descricao, isAtivo from categoria 
                where isAtivo = false;", null);
        }

        public async Task<int> TotalRegistros()
        {
            var result = await _context.QueryAsync<int>(@"select count(*) from categoria;", null);
            return result.Single();
        }
    }
}
