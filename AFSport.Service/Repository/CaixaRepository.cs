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
    public class CaixaRepository : BaseRepository, ICRUD<Caixa>
    {
        public async Task Remover(Caixa obj)
        {
            await _context.QueryAsync<Caixa>(@"delete from categoria 
                where idCategoria = @idCategoria", obj);
        }

        public async Task<Caixa> Salvar(Caixa obj)
        {
            var result = obj.IdCaixa == 0
                ? await _context.QueryAsync<Caixa>(@"insert into caixa(idUsuario, data, valorInicial)  values (@idUsuario, @data,@valorInicial);
                    select c.idCaixa, c.data, c.valorInicial, u.idUsuario, u.nome, u.login, u.email, u.isAtivo from caixa as c
                    inner join usuario u on c.idUsuario = u.idUsuario where idCaixa = (select last_insert_id() as id);", obj)
                : await _context.QueryAsync<Caixa>(@"update caixa set idUsuario = @idUsuario, data = @data, valorInicial = @valorInicial where idCaixa = @idCaixa;
                    select c.idCaixa, c.data, c.valorInicial, u.idUsuario, u.nome, u.login, u.email, u.isAtivo from caixa as c
                    inner join usuario u on c.idUsuario = u.idUsuario where idCaixa = @idCaixa;", obj);
            return result.Single();
        }

        public async Task<Caixa> SelecionarId(int id)
        {
            var result = await _context.QueryAsync<Caixa, Usuario, Caixa>(@"select c.idCaixa, c.data, c.valorInicial, u.idUsuario, u.nome, u.login, u.email, u.isAtivo from caixa as c
                    inner join usuario u on c.idUsuario = u.idUsuario where c.idCaixa = @idCaixa;", (caixa, usuario) =>
            {
                caixa.Usuario = usuario;
                return caixa;
            }, new { idCaixa = id }, splitOn: "idUsuario");
            return result.SingleOrDefault();
        }

        public async Task<Caixa> SelecionarPorData(DateTime data)
        {
            var result = await _context.QueryAsync<Caixa, Usuario, Caixa>(@"select c.idCaixa, c.data, c.valorInicial, u.idUsuario, u.nome, u.login, u.email, u.isAtivo from caixa as c
                    inner join usuario u on c.idUsuario = u.idUsuario where DATE_FORMAT(data, '%d/%m/%Y') = DATE_FORMAT( @data, '%d/%m/%Y');", (caixa, usuario) =>
            {
                caixa.Usuario = usuario;
                return caixa;
            }, new { data }, splitOn: "idUsuario");
            return result.SingleOrDefault();
        }

        public async Task<Caixa> SelecionarPorDataAtual(DateTime data)
        {
            var result = await _context.QueryAsync<Caixa, Usuario, Caixa>(@"select c.idCaixa, c.data, c.valorInicial, u.idUsuario, u.nome, u.login, u.email, u.isAtivo from caixa as c
                    inner join usuario u on c.idUsuario = u.idUsuario where DATE_FORMAT(data, '%d/%m/%Y') = DATE_FORMAT(NOW(), '%d/%m/%Y');", (caixa, usuario) =>
            {
                caixa.Usuario = usuario;
                return caixa;
            }, null, splitOn: "idUsuario");
            return result.SingleOrDefault();
        }

        public async Task<List<Caixa>> SelecionarTodos(bool selecionarTodos)
        {
            var result = await _context.QueryAsync<Caixa, Usuario, Caixa>(@"select c.idCaixa, c.data, c.valorInicial, u.idUsuario, u.nome, u.login, u.email, u.isAtivo from caixa as c
                    inner join usuario u on c.idUsuario = u.idUsuario;", (caixa, usuario) =>
                    {
                        caixa.Usuario = usuario;
                        return caixa;
                    }, null, splitOn: "idUsuario");
            return result.ToList();
        }

        public async Task<int> TotalRegistros()
        {
            var result = await _context.QueryAsync<int>(@"select count(*) from caixa;", null);
            return result.Single();
        }
    }
}
