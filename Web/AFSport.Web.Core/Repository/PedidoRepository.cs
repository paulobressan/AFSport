﻿using AFSport.Web.Core.Base;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Repository
{
    public class PedidoRepository : BaseRepository,IPedidoRepository
    {
        public PedidoRepository()
        {
        }

        public async Task Remover(Pedido obj)
        {
            await _context.QueryAsync<Pedido>(@"delete from categoria 
                where idCategoria = @idCategoria", obj);
        }

        public async Task<Pedido> Salvar(Pedido obj)
        {
            var result = obj.IdPedido == 0
                ? await _context.QueryAsync<Pedido, Cliente, Usuario, Pedido_Status, Pedido>(@"insert into pedido(idUsuario, idCliente, idStatus, data) values (@idUsuario, @idCliente, @idStatus, @data);
                    select p.idPedido, p.data,c.idCliente, c.nome, c.email, c.logradouro, c.bairro, c.numero, u.idUsuario, u.nome, u.email, u.isAtivo, ps.idStatus, ps.status from pedido as p
                    inner join cliente c on p.idCliente = c.idCliente
                    inner join usuario u on p.idUsuario = u.idUsuario
                    inner join pedido_status ps on p.idStatus = ps.idStatus
                    where p.idPedido = (select last_insert_id() as id)", (pedido, cliente, usuario, pedido_status) =>
                    {
                        pedido.PedidoStatus = pedido_status;
                        pedido.Cliente = cliente;
                        pedido.Usuario = usuario;
                        return pedido;
                    }, obj, splitOn: "idCliente, idUsuario, idStatus")
                : await _context.QueryAsync<Pedido, Cliente, Usuario, Pedido_Status, Pedido>(@"update pedido set idUsuario = @idUsuario, idCliente = @idCliente, idStatus = @idStatus, data = @data where idPedido = @idPedido;
                    select p.idPedido, p.data,c.idCliente, c.nome, c.email, c.logradouro, c.bairro, c.numero, u.idUsuario, u.nome, u.email, u.isAtivo, ps.idStatus, ps.status from pedido as p
                    inner join cliente c on p.idCliente = c.idCliente
                    inner join usuario u on p.idUsuario = u.idUsuario
                    inner join pedido_status ps on p.idStatus = ps.idStatus
                    where p.idPedido = @idPedido;", (pedido, cliente, usuario, pedido_status) =>
                    {
                        pedido.PedidoStatus = pedido_status;
                        pedido.Cliente = cliente;
                        pedido.Usuario = usuario;
                        return pedido;
                    }, obj, splitOn: "idCliente, idUsuario, idStatus");
            return result.Single();
        }

        public async Task<Pedido> SelecionarId(int id)
        {
            var result = await _context.QueryAsync<Pedido, Cliente, Usuario, Pedido_Status, Pedido>(@"select p.idPedido, p.data,c.idCliente, c.nome, c.email, c.logradouro, c.bairro, c.numero, u.idUsuario, u.nome, u.email, u.isAtivo, ps.idStatus, ps.status from pedido as p
                inner join cliente c on p.idCliente = c.idCliente
                inner join usuario u on p.idUsuario = u.idUsuario
                inner join pedido_status ps on p.idStatus = ps.idStatus 
                where p.idPedido = @idPedido
                order by p.data desc;", (pedido, cliente, usuario, pedido_status) =>
            {
                pedido.PedidoStatus = pedido_status;
                pedido.Cliente = cliente;
                pedido.Usuario = usuario;
                return pedido;
            }, new { idPedido = id }, splitOn: "idCliente, idUsuario, idStatus");

            return result.SingleOrDefault();
        }

        public async Task<List<Pedido>> SelecionarTodos(bool selecionarTodos)
        {
            var result = await _context.QueryAsync<Pedido, Cliente, Usuario, Pedido_Status, Pedido>(@"select p.idPedido, p.data,c.idCliente, c.nome, c.email, c.logradouro, c.bairro, c.numero, u.idUsuario, u.nome, u.email, u.isAtivo, ps.idStatus, ps.status from pedido as p
                inner join cliente c on p.idCliente = c.idCliente
                inner join usuario u on p.idUsuario = u.idUsuario
                inner join pedido_status ps on p.idStatus = ps.idStatus 
                order by p.data desc;", (pedido, cliente, usuario, pedido_status ) =>
                    {
                        pedido.PedidoStatus = pedido_status;
                        pedido.Cliente = cliente;
                        pedido.Usuario = usuario;
                        return pedido;
                    } ,null, splitOn: "idCliente, idUsuario, idStatus");
                
            return result.ToList();
        }

        public async Task<List<Pedido>> SelecionarTodosDiario()
        {
            var result = await _context.QueryAsync<Pedido, Cliente, Usuario, Pedido_Status, Pedido>(@"select p.idPedido, p.data,c.idCliente, c.nome, c.email, c.logradouro, c.bairro, c.numero, u.idUsuario, u.nome, u.email, u.isAtivo, ps.idStatus, ps.status from pedido as p
                inner join cliente c on p.idCliente = c.idCliente
                inner join usuario u on p.idUsuario = u.idUsuario
                inner join pedido_status ps on p.idStatus = ps.idStatus 
                where DATE_FORMAT(p.data, '%d/%m/%Y') = DATE_FORMAT(NOW(), '%d/%m/%Y')
                order by p.data desc;", (pedido, cliente, usuario, pedido_status) =>
                {
                    pedido.PedidoStatus = pedido_status;
                    pedido.Cliente = cliente;
                    pedido.Usuario = usuario;
                    return pedido;
                }, null, splitOn: "idCliente, idUsuario, idStatus");

            return result.ToList();
        }

        public async Task<int> TotalRegistros()
        {
            var result = await _context.QueryAsync<int>(@"select count(*) from pedido;", null);
            return result.Single();
        }
    }
}
