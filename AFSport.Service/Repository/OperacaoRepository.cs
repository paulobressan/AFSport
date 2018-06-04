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
    public class OperacaoRepository : BaseRepository, ICRUD<Operacao>
    {
        public async Task Remover(Operacao obj)
        {
            await _context.QueryAsync<Operacao>("delete from operacao where idOperacao = @idOperacao", obj);
        }

        public async Task<Operacao> Salvar(Operacao obj)
        {
            var result = obj.IdOperacao == 0
                ? await _context.QueryAsync<Operacao>(@"insert into operacao(nome, descricao, isAtivo) value (@nome, @descricao, @isAtivo);
                    select idOperacao, nome, descricao,isAtivo from operacao 
                    where idOperacao = (select last_insert_id() as id);", obj)
                : await _context.QueryAsync<Operacao>(@"update operacao set nome = @nome, descricao = @descricao, @isAtivo where idOperacao = @idOperacao;
                    select idOperacao, nome, descricao,isAtivo from operacao 
                    where idOperacao = @idOperacao;", obj);
            return result.Single();
        }

        public async Task<Operacao> SelecionarId(int id)
        {
            var result = await _context.QueryAsync<Operacao>(@"select idOperacao, nome, descricao,isAtivo from operacao
                where idOperacao = @idOperacao;", null);
            return result.SingleOrDefault();
        }

        public async Task<List<Operacao>> SelecionarTodos(bool selecionarTodos)
        {
            var result = selecionarTodos
                ? await _context.QueryAsync<Operacao>(@"select idOperacao, nome, descricao,isAtivo from operacao;", null)
                : await _context.QueryAsync<Operacao>(@"select idOperacao, nome, descricao,isAtivo from operacao where isAtivo = true;", null);
            return result.ToList();
        }
    }
}
