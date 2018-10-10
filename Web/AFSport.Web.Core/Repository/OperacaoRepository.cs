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
    public class OperacaoRepository : BaseRepository, IOperacaoRepository
    {
        public OperacaoRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task Remover(int idOperacao)
        {
            await _context.QueryAsync<Operacao>("delete from operacao where idOperacao = @idOperacao", new { idOperacao });
        }

        public async Task<Operacao> Inserir(Operacao operacao)
        {
            return (await _context.QueryAsync<Operacao>(@"insert into operacao(nome, descricao, isAtivo) value (@nome, @descricao, @isAtivo);
                select idOperacao, nome, descricao,isAtivo from operacao 
                where idOperacao = (select last_insert_id() as id);", operacao))
                .Single();
        }

        public async Task<Operacao> Alterar(Operacao operacao)
        {
            return (await _context.QueryAsync<Operacao>(@"update operacao set nome = @nome, descricao = @descricao, @isAtivo where idOperacao = @idOperacao;
                select idOperacao, nome, descricao,isAtivo from operacao 
                where idOperacao = @idOperacao;", operacao))
                .Single();
        }

        public async Task<Operacao> SelecionarId(int id)
        {
            return (await _context.QueryAsync<Operacao>(@"select idOperacao, nome, descricao,isAtivo from operacao
                where idOperacao = @idOperacao;", null))
                .SingleOrDefault();
        }

        public async Task<IEnumerable<Operacao>> SelecionarTodos()
        {
            return await _context.QueryAsync<Operacao>(@"select idOperacao, nome, descricao,isAtivo from operacao;", null);
        }

        public async Task<IEnumerable<Operacao>> SelecionarTodosAtivos()
        {
            return await _context.QueryAsync<Operacao>(@"select idOperacao, nome, descricao,isAtivo 
                from operacao where isAtivo = true;", null);
        }

        public async Task AtivarInativar(int idOperacao, Boolean isAtivo)
        {
            await _context.QueryAsync(@"update operacao set isAtivo = @isAtivo 
                where idOperacao = @idOperacao;", new { idOperacao, isAtivo });
        }

        public async Task<IEnumerable<Operacao>> SelecionarTodosInativos()
        {
            return await _context.QueryAsync<Operacao>(@"select idOperacao, nome, descricao,isAtivo 
                from operacao where isAtivo = false;", null);
        }
    }
}
