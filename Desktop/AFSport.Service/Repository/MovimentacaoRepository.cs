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
    public class MovimentacaoRepository : BaseRepository, ICRUD<Movimentacao>
    {
        public async Task Remover(Movimentacao obj)
        {
            await _context.QueryAsync<Movimentacao>(@"delete from movimentacao 
                where idMovimentacao = @idMovimentacao", obj);
        }

        public async Task<Movimentacao> Salvar(Movimentacao obj)
        {
            var result = obj.IdMovimentacao == 0
                ? await _context.QueryAsync<Movimentacao, Usuario, Operacao, Movimentacao>(@"insert into movimentacao(idUsuario, idOperacao, valor, data)
                    values (@idUsuario, @idOperacao, @valor, @data);
                    select idMovimentacao, m.data, m.valor, u.idUsuario, u.nome, u.email, u.login, u.isAtivo, o.idOperacao, o.nome, o.descricao, o.isAtivo from movimentacao m
                    inner join usuario u on m.idUsuario = u.idUsuario
                    inner join operacao o on m.idOperacao = o.idOperacao
                    where idMovimentacao = (select last_insert_id() as id);", (movimentacao, usuario, operacao) =>
                    {
                        movimentacao.Usuario = usuario;
                        movimentacao.Operacao = operacao;
                        return movimentacao;
                    }, obj, splitOn: "IdUsuario, IdOperacao")
                : await _context.QueryAsync<Movimentacao, Usuario, Operacao, Movimentacao>(@"update movimentacao set idUsuario = @idUsuario, idOperacao = @idOperacao, valor = @valor, data = @data
                    where idMovimentacao = @idMovimentacao;
                    select idMovimentacao, m.data, m.valor, u.idUsuario, u.nome, u.email, u.login, u.isAtivo, o.idOperacao, o.nome, o.descricao, o.isAtivo from movimentacao m
                    inner join usuario u on m.idUsuario = u.idUsuario
                    inner join operacao o on m.idOperacao = o.idOperacao
                    where idMovimentacao = @idMovimentacao;", (movimentacao, usuario, operacao) =>
                    {
                        movimentacao.Usuario = usuario;
                        movimentacao.Operacao = operacao;
                        return movimentacao;
                    }, obj , splitOn: "IdUsuario, IdOperacao");
            return result.Single();
        }

        public async Task<Movimentacao> SelecionarId(int id)
        {
            var result = await _context.QueryAsync<Movimentacao, Usuario, Operacao, Movimentacao>(@"select idMovimentacao, m.data, m.valor, u.idUsuario, u.nome, u.email, u.login, u.isAtivo, o.idOperacao, o.nome, o.descricao, o.isAtivo from movimentacao m
                inner join usuario u on m.idUsuario = u.idUsuario
                inner join operacao o on m.idOperacao = o.idOperacao
                where idMovimentacao = @idMovimentacao;", (movimentacao, usuario, operacao) =>
                {
                    movimentacao.Usuario = usuario;
                    movimentacao.Operacao = operacao;
                    return movimentacao;
                }, new { idMovimentacao = id }, splitOn: "IdUsuario, IdOperacao");
            return result.SingleOrDefault();
        }

        public async Task<List<Movimentacao>> SelecionarTodos(bool selecionarTodos)
        {
            var result = await _context.QueryAsync<Movimentacao, Usuario, Operacao, Movimentacao>(@"select idMovimentacao, m.data, m.valor, u.idUsuario, u.nome, u.email, u.login, u.isAtivo, o.idOperacao, o.nome, o.descricao, o.isAtivo from movimentacao m
                inner join usuario u on m.idUsuario = u.idUsuario
                inner join operacao o on m.idOperacao = o.idOperacao;", (movimentacao, usuario, operacao)=> 
                {
                    movimentacao.Usuario = usuario;
                    movimentacao.Operacao = operacao;
                    return movimentacao;
                }, null, splitOn: "IdUsuario, IdOperacao");
            return result.ToList();
        }

        public async Task<List<Movimentacao>> SelecionarMovimentacaoPorCaixa(DateTime data)
        {
            var result = await _context.QueryAsync<Movimentacao, Usuario, Operacao, Movimentacao>(@"select idMovimentacao, m.data, m.valor, u.idUsuario, u.nome, u.email, u.login, u.isAtivo, o.idOperacao, o.nome, o.descricao, o.isAtivo from movimentacao m
                inner join usuario u on m.idUsuario = u.idUsuario
                inner join operacao o on m.idOperacao = o.idOperacao
                where DATE_FORMAT(data, '%d/%m/%Y') = DATE_FORMAT(@data, '%d/%m/%Y');", (movimentacao, usuario, operacao) =>
            {
                movimentacao.Usuario = usuario;
                movimentacao.Operacao = operacao;
                return movimentacao;
            }, new { data }, splitOn: "IdUsuario, IdOperacao");
            return result.ToList();
        }

        public async Task<int> TotalRegistros()
        {
            var result = await _context.QueryAsync<int>(@"select count(*) from movimentacao;", null);
            return result.Single();
        }
    }
}
