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
    public class CaixaRepository : BaseRepository, ICaixaService
    {
        public CaixaRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<Caixa> Alterar(Caixa caixa)
        {
            return (await _context.QueryAsync<Caixa>(@"update caixa set idUsuario = @idUsuario, data = @data, valorInicial = @valorInicial where idCaixa = @idCaixa;
                select c.idCaixa, c.data, c.valorInicial, u.idUsuario, u.nome, u.login, u.email, u.isAtivo from caixa as c
                inner join usuario u on c.idUsuario = u.idUsuario where idCaixa = @idCaixa;", caixa))
                .Single();
        }

        public async Task<Caixa> Inserir(Caixa caixa)
        {
            return (await _context.QueryAsync<Caixa>(@"insert into caixa(idUsuario, data, valorInicial)  values (@idUsuario, @data,@valorInicial);
                select c.idCaixa, c.data, c.valorInicial, u.idUsuario, u.nome, u.login, u.email, u.isAtivo from caixa as c
                inner join usuario u on c.idUsuario = u.idUsuario where idCaixa = (select last_insert_id() as id);", caixa))
                .Single();
        }

        public async Task Remover(Caixa caixa)
        {
            await _context.QueryAsync<Caixa>(@"delete from categoria 
                where idCategoria = @idCategoria", caixa);

        }

        public async Task<Caixa> SelecionarId(int id)
        {
            return (await _context.QueryAsync<Caixa, Usuario, Caixa>(@"select c.idCaixa, c.data, c.valorInicial, u.idUsuario, u.nome, u.login, u.email, u.isAtivo from caixa as c
                inner join usuario u on c.idUsuario = u.idUsuario where c.idCaixa = @idCaixa;", (caixa, usuario) =>
                {
                    caixa.Usuario = usuario;
                    return caixa;
                }, new { idCaixa = id }, splitOn: "idUsuario"))
              .SingleOrDefault();
        }

        public async Task<Caixa> SelecionarPorData(DateTime data)
        {
            return (await _context.QueryAsync<Caixa, Usuario, Caixa>(@"select c.idCaixa, c.data, c.valorInicial, u.idUsuario, u.nome, u.login, u.email, u.isAtivo from caixa as c
                inner join usuario u on c.idUsuario = u.idUsuario where DATE_FORMAT(data, '%d/%m/%Y') = DATE_FORMAT( @data, '%d/%m/%Y');", (caixa, usuario) =>
            {
                caixa.Usuario = usuario;
                return caixa;
            }, new { data }, splitOn: "idUsuario"))
            .SingleOrDefault();
        }

        public async Task<Caixa> SelecionarPorDataAtual(DateTime data)
        {
            return (await _context.QueryAsync<Caixa, Usuario, Caixa>(@"select c.idCaixa, c.data, c.valorInicial, u.idUsuario, u.nome, u.login, u.email, u.isAtivo from caixa as c
                inner join usuario u on c.idUsuario = u.idUsuario where DATE_FORMAT(data, '%d/%m/%Y') = DATE_FORMAT(NOW(), '%d/%m/%Y');", (caixa, usuario) =>
            {
                caixa.Usuario = usuario;
                return caixa;
            }, null, splitOn: "idUsuario"))
            .SingleOrDefault();
        }

        public async Task<IEnumerable<Caixa>> SelecionarTodos()
        {
            return (await _context.QueryAsync<Caixa, Usuario, Caixa>(@"select c.idCaixa, c.data, c.valorInicial, u.idUsuario, u.nome, u.login, u.email, u.isAtivo from caixa as c
                inner join usuario u on c.idUsuario = u.idUsuario;", (caixa, usuario) =>
                {
                    caixa.Usuario = usuario;
                    return caixa;
                }, null, splitOn: "idUsuario"));
        }

        public async Task<int> TotalRegistros()
        {
            return (await _context.QueryAsync<int>(@"select count(*) from caixa;", null))
                .Single();
        }
    }
}
