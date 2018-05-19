using AFSport.Service.Base;
using AFSport.Service.Interfaces;
using AFSport.Service.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Repository
{
    public class CategoriaRepository : BaseRepository, ICRUD<Categoria>
    {
        public void Remover(Categoria obj)
        {
             _context.Query<Categoria>(@"delete from categoria 
                where idCategoria = @idCategoria", obj);
        }

        public async Task<Categoria> Salvar(Categoria obj)
        {
            if (obj.IdCategoria == 0)
            {
                var result = await _context.QueryAsync<Categoria>(@"insert into categoria(nome,descricao,isAtivo) 
                    values (@nome,@descricao,@isAtivo);
                    select idCategoria, nome, descricao, isAtivo from categoria
                    where idCategoria = (select last_insert_id() as idCategoria);", obj);
                return result.Single();
            }
            else
            {
                var result = await _context.QueryAsync<Categoria>(@"update categoria set nome = @nome, descricao = @descricao, isAtivo = @isAtivo 
                    where idCategoria = @idCategoria;
                    select idCategoria, nome, descricao, isAtivo from categoria
                    where idCategoria = @IdCategoria", obj);
                return result.Single();
            } 
        }

        public async Task<Categoria> SelecionarId(int id)
        {
            var result = await _context.QueryAsync<Categoria>(@"select idCategoria, nome, descricao, isAtivo from categoria 
                where idCategoria = @idCategoria;", new { idCategoria = id });
            return result.SingleOrDefault();
        }

        public async Task<List<Categoria>> SelecionarTodos(bool selecionarTodos)
        {
            var result = selecionarTodos 
                ? await _context.QueryAsync<Categoria>(@"select idCategoria, nome, descricao, isAtivo from categoria;", null)
                : await _context.QueryAsync<Categoria>(@"select idCategoria, nome, descricao, isAtivo from categoria 
                where isAtivo = true;", null);
            return result.ToList();
        }

        public async Task<int> TotalRegistros()
        {
            var result = await _context.QueryAsync<int>(@"select count(*) from categoria;", null);
            return result.Single();
        }
    }
}
