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
    public class MovimentacaoRepository : BaseRepository, IMovimentacaoRepository
    {
        public MovimentacaoRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<Movimentacao> Inserir(Movimentacao movimentacao)
        {
            return (await _context.QueryAsync<Movimentacao, Usuario, Operacao, Movimentacao>(@"insert into movimentacao(idUsuario, idOperacao, valor, data)
                values (@idUsuario, @idOperacao, @valor, @data);
                select idMovimentacao, m.data, m.valor, u.idUsuario, u.nome, u.email, u.login, u.isAtivo, o.idOperacao, o.nome, o.descricao, o.isAtivo from movimentacao m
                inner join usuario u on m.idUsuario = u.idUsuario
                inner join operacao o on m.idOperacao = o.idOperacao
                where idMovimentacao = (select last_insert_id() as id);", (movimentacaop, usuario, operacao) =>
                {
                    movimentacaop.Usuario = usuario;
                    movimentacaop.Operacao = operacao;
                    return movimentacaop;
                }, movimentacao, splitOn: "IdUsuario, IdOperacao"))
                .Single();
        }

        public async Task<Movimentacao> Alterar(Movimentacao movimentacao)
        {
            return (await _context.QueryAsync<Movimentacao, Usuario, Operacao, Movimentacao>(@"update movimentacao set idUsuario = @idUsuario, idOperacao = @idOperacao, valor = @valor, data = @data
                where idMovimentacao = @idMovimentacao;
                select idMovimentacao, m.data, m.valor, u.idUsuario, u.nome, u.email, u.login, u.isAtivo, o.idOperacao, o.nome, o.descricao, o.isAtivo from movimentacao m
                inner join usuario u on m.idUsuario = u.idUsuario
                inner join operacao o on m.idOperacao = o.idOperacao
                where idMovimentacao = @idMovimentacao;", (movimentacaop, usuario, operacao) =>
                {
                    movimentacaop.Usuario = usuario;
                    movimentacaop.Operacao = operacao;
                    return movimentacaop;
                }, movimentacao, splitOn: "IdUsuario, IdOperacao"))
                .Single();
        }

        public async Task<Movimentacao> SelecionarId(int id)
        {
            return (await _context.QueryAsync<Movimentacao, Usuario, Operacao, Movimentacao>(@"select idMovimentacao, m.data, m.valor, u.idUsuario, u.nome, u.email, u.login, u.isAtivo, o.idOperacao, o.nome, o.descricao, o.isAtivo from movimentacao m
                inner join usuario u on m.idUsuario = u.idUsuario
                inner join operacao o on m.idOperacao = o.idOperacao
                where idMovimentacao = @idMovimentacao;", (movimentacao, usuario, operacao) =>
                {
                    movimentacao.Usuario = usuario;
                    movimentacao.Operacao = operacao;
                    return movimentacao;
                }, new { idMovimentacao = id }, splitOn: "IdUsuario, IdOperacao"))
                .SingleOrDefault();
        }

        public async Task<IEnumerable<Movimentacao>> SelecionarTodos()
        {
            return await _context.QueryAsync<Movimentacao, Usuario, Operacao, Movimentacao>(@"select idMovimentacao, m.data, m.valor, u.idUsuario, u.nome, u.email, u.login, u.isAtivo, o.idOperacao, o.nome, o.descricao, o.isAtivo from movimentacao m
                inner join usuario u on m.idUsuario = u.idUsuario
                inner join operacao o on m.idOperacao = o.idOperacao;", (movimentacao, usuario, operacao) =>
                {
                    movimentacao.Usuario = usuario;
                    movimentacao.Operacao = operacao;
                    return movimentacao;
                }, null, splitOn: "IdUsuario, IdOperacao");
        }

        public async Task<IEnumerable<Movimentacao>> SelecionarMovimentacaoPorDia(DateTime data)
        {
            return await _context.QueryAsync<Movimentacao, Usuario, Operacao, Movimentacao>(@"select idMovimentacao, m.data, m.valor, u.idUsuario, u.nome, u.email, u.login, u.isAtivo, o.idOperacao, o.nome, o.descricao, o.isAtivo from movimentacao m
                inner join usuario u on m.idUsuario = u.idUsuario
                inner join operacao o on m.idOperacao = o.idOperacao
                where DATE_FORMAT(data, '%d/%m/%Y') = DATE_FORMAT(@data, '%d/%m/%Y');", (movimentacao, usuario, operacao) =>
                {
                    movimentacao.Usuario = usuario;
                    movimentacao.Operacao = operacao;
                    return movimentacao;
                }, new { data }, splitOn: "IdUsuario, IdOperacao");
        }

        public async Task<IEnumerable<Movimentacao>> SelecionarMovimentacaoPorOperacao(int idOperacao)
        {
            return await _context.QueryAsync<Movimentacao, Usuario, Operacao, Movimentacao>(@"select idMovimentacao, m.data, m.valor, u.idUsuario, u.nome, u.email, u.login, u.isAtivo, o.idOperacao, o.nome, o.descricao, o.isAtivo from movimentacao m
                inner join usuario u on m.idUsuario = u.idUsuario
                inner join operacao o on m.idOperacao = o.idOperacao
                where o.idOperacao = @idOperacao", (movimentacao, usuario, operacao) =>
                {
                    movimentacao.Usuario = usuario;
                    movimentacao.Operacao = operacao;
                    return movimentacao;
                }, new { idOperacao }, splitOn: "IdUsuario, IdOperacao");
        }

        public async Task<int> TotalRegistros()
        {
            return (await _context.QueryAsync<int>(@"select count(*) from movimentacao;", null))
                .Single();
        }
    }
}
