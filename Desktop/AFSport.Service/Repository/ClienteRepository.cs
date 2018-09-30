using AFSport.Service.Model;
using AFSport.Service.Base;
using AFSport.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace AFSport.Service.Repository
{
    public class ClienteRepository : BaseRepository, ICRUD<Cliente>
    {
        public async Task Remover(Cliente obj)
        {
            await _context.QueryAsync<Cliente>(@"delete from cliente where idCliente = @idCliente", obj);
        }

        public async Task<Cliente> Salvar(Cliente obj)
        {
            var result = obj.IdCliente == 0
                ? await _context.QueryAsync<Cliente, Cidade, Estado, Cliente>(
                    @"insert into cliente(idCidade, nome, logradouro, bairro, numero, email) values (@idCidade, @nome, @logradouro, @bairro, @numero, @email);
                    select c.idCliente, c.nome, c.logradouro, c.bairro, c.numero, c.email, ci.idCidade, ci.nome, ci.isAtivo, e.idEstado, e.nome, e.sigla, e.isAtivo
                    from cliente as c
                    inner join cidade ci on c.idCidade = ci.idCidade
                    inner join estado e on ci.idEstado = e.idEstado
                    where c.idCliente = (select last_insert_id() as id)", (cliente, cidade, estado) =>
                    {
                        cliente.Cidade = cidade;
                        cliente.Cidade.Estado = estado;
                        return cliente;
                    }, obj, splitOn: "idCidade, IdEstado")
                : await _context.QueryAsync<Cliente, Cidade, Estado, Cliente>(
                    @"update cliente set idCidade = @idCidade, nome = @nome, logradouro = @logradouro, bairro = @bairro, numero = @numero, email = @email where idCliente = @idCliente;
                        select c.idCliente, c.nome, c.logradouro, c.bairro, c.numero, c.email, ci.idCidade, ci.nome, ci.isAtivo, e.idEstado, e.nome, e.sigla, e.isAtivo
                        from cliente as c
                        inner join cidade ci on c.idCidade = ci.idCidade
                        inner join estado e on ci.idEstado = e.idEstado
                        where idCliente = @idCliente", (cliente, cidade, estado) =>
                    {
                        cliente.Cidade = cidade;
                        cliente.Cidade.Estado = estado;
                        return cliente;
                    }, obj, splitOn: "idCidade, IdEstado");
            return result.Single();
        }

        public async Task<Cliente> SelecionarId(int id)
        {
            var result = await _context.QueryAsync<Cliente, Cidade, Estado, Cliente>(
                    @"select c.idCliente, c.nome, c.logradouro, c.bairro, c.numero, c.email, ci.idCidade, ci.nome, ci.isAtivo, e.idEstado, e.nome, e.sigla, e.isAtivo
                    from cliente as c
                    inner join cidade ci on c.idCidade = ci.idCidade
                    inner join estado e on ci.idEstado = e.idEstado 
                    where ci.isAtivo = true and e.isAtivo = true and c.idCliente = @idCliente", (cliente, cidade, estado) =>
                    {
                        cliente.Cidade = cidade;
                        cliente.Cidade.Estado = estado;
                        return cliente;
                    }, new { idCliente = id }, splitOn: "idCidade, IdEstado");
            return result.SingleOrDefault();
        }

        public async Task<List<Cliente>> SelecionarTodos(bool selecionarTodos)
        {
            var result = await _context.QueryAsync<Cliente, Cidade, Estado, Cliente>(
                    @"select c.idCliente, c.nome, c.logradouro, c.bairro, c.numero, c.email, ci.idCidade, ci.nome, ci.isAtivo, e.idEstado, e.nome, e.sigla, e.isAtivo
                    from cliente as c
                    inner join cidade ci on c.idCidade = ci.idCidade
                    inner join estado e on ci.idEstado = e.idEstado 
                    where ci.isAtivo = true and e.isAtivo = true;", (cliente, cidade, estado) =>
                    {
                        cliente.Cidade = cidade;
                        cliente.Cidade.Estado = estado;
                        return cliente;
                    }, null, splitOn: "idCidade, IdEstado");                 
            return result.ToList();
        }

        public async Task<List<Cliente>> SelecionarPorCidade(int idCidade)
        {
            var result = await _context.QueryAsync<Cliente, Cidade, Estado, Cliente>(
                    @"select c.idCliente, c.nome, c.logradouro, c.bairro, c.numero, c.email, ci.idCidade, ci.nome, ci.isAtivo, e.idEstado, e.nome, e.sigla, e.isAtivo
                    from cliente as c
                    inner join cidade ci on c.idCidade = ci.idCidade
                    inner join estado e on ci.idEstado = e.idEstado 
                    where ci.isAtivo = true and e.isAtivo = true and c.idCidade = @idCidade", (cliente, cidade, estado) =>
                    {
                        cliente.Cidade = cidade;
                        cliente.Cidade.Estado = estado;
                        return cliente;
                    }, new { idCidade }, splitOn: "idCidade, IdEstado");
            return result.ToList();
        }

        public async Task<List<Cliente>> SelecionarPesquisaNomeId(string valor)
        {
            var result = await _context.QueryAsync<Cliente, Cidade, Estado, Cliente>(
                    @"select c.idCliente, c.nome, c.logradouro, c.bairro, c.numero, c.email, ci.idCidade, ci.nome, ci.isAtivo, e.idEstado, e.nome, e.sigla, e.isAtivo
                    from cliente as c
                    inner join cidade ci on c.idCidade = ci.idCidade
                    inner join estado e on ci.idEstado = e.idEstado 
                    where ci.isAtivo = true and e.isAtivo = true and (c.idCliente = @idCliente or c.nome like concat('%', @nome '%'))", (cliente, cidade, estado) =>
                    {
                        cliente.Cidade = cidade;
                        cliente.Cidade.Estado = estado;
                        return cliente;
                    }, new { idCliente = valor, nome = valor }, splitOn: "idCidade, IdEstado");
            return result.ToList();
        }

        public async Task<int> TotalRegistros()
        {
            var result = await _context.QueryAsync<int>(@"select count(*) from cliente where isAtivo = true;", null);
            return result.Single();
        }
    }
}
