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
        public async void Remover(Cliente obj)
        {
            await _context.QueryAsync<Cliente>(@"delete from cliente where idCliente = @idCliente", obj);
        }

        public async Task<Cliente> Salvar(Cliente obj)
        {
            if(obj.IdCliente == 0)
            {
                var result = await _context.QueryAsync<Cliente, Cidade, Estado, Cliente>(
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
                    }, obj, splitOn: "idCidade, IdEstado");
                return result.Single();
            }
            else
            {
                var result = await _context.QueryAsync<Cliente, Cidade, Estado, Cliente>(
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
        }

        public async Task<Cliente> SelecionarId(int id)
        {
            var result = await _context.QueryAsync<Cliente, Cidade, Estado, Cliente>(
                    @"select c.idCliente, c.nome, c.logradouro, c.bairro, c.numero, c.email, ci.idCidade, ci.nome, ci.isAtivo, e.idEstado, e.nome, e.sigla, e.isAtivo
                    from cliente as c
                    inner join cidade ci on c.idCidade = ci.idCidade
                    inner join estado e on ci.idEstado = e.idEstado 
                    where ci.isAtivo = true and c.idCliente = @idCliente", (cliente, cidade, estado) =>
                    {
                        cliente.Cidade = cidade;
                        cliente.Cidade.Estado = estado;
                        return cliente;
                    }, new { idCliente = id }, splitOn: "idCidade, IdEstado");
            return result.SingleOrDefault();
        }

        public async Task<List<Cliente>> SelecionarTodos(bool selecionarTodos)
        {
            var result = selecionarTodos
                ? await _context.QueryAsync<Cliente, Cidade, Estado, Cliente>(
                    @"select c.idCliente, c.nome, c.logradouro, c.bairro, c.numero, c.email, ci.idCidade, ci.nome, ci.isAtivo, e.idEstado, e.nome, e.sigla, e.isAtivo
                    from cliente as c
                    inner join cidade ci on c.idCidade = ci.idCidade
                    inner join estado e on ci.idEstado = e.idEstado 
                    where ci.isAtivo = true", (cliente, cidade, estado) =>
                    {
                        cliente.Cidade = cidade;
                        cliente.Cidade.Estado = estado;
                        return cliente;
                    }, null , splitOn: "idCidade, IdEstado")
                    : await _context.QueryAsync<Cliente, Cidade, Estado, Cliente>(
                    @"select c.idCliente, c.nome, c.logradouro, c.bairro, c.numero, c.email, ci.idCidade, ci.nome, ci.isAtivo, e.idEstado, e.nome, e.sigla, e.isAtivo
                    from cliente as c
                    inner join cidade ci on c.idCidade = ci.idCidade
                    inner join estado e on ci.idEstado = e.idEstado 
                    where ci.isAtivo = true and c.isAtivo = true", (cliente, cidade, estado) =>
                    {
                        cliente.Cidade = cidade;
                        cliente.Cidade.Estado = estado;
                        return cliente;
                    },null, splitOn: "idCidade, IdEstado");
            return result.ToList();
        }
    }
}
