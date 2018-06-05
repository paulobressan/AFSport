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
    public class ItemPedidoRepository : BaseRepository, ICRUD<ItemPedido>
    {
        public async Task Remover(ItemPedido obj)
        {
            await _context.QueryAsync<ItemPedido>(@"delete from categoria 
                where idCategoria = @idCategoria", obj);
        }

        public async Task<ItemPedido> Salvar(ItemPedido obj)
        {
            var result = obj.IdItemPedido == 0
                ? await _context.QueryAsync<ItemPedido, Pedido, Produto, ItemPedido>(@"insert into itempedido(idPedido, idProduto, quantidade) values (@idPedido, @idProduto, @quantidade);
                    select i.idItemPedido, i.quantidade, p.idPedido, p2.idProduto, p2.nome, p2.descricao, p2.valorCompra, p2.valorVenda, p2.isAtivo from itempedido as i
                    inner join pedido p on i.idPedido = p.idPedido
                    inner join produto p2 on i.idProduto = p2.idProduto
                    where i.idItemPedido = (select last_insert_id() as id);", (itemPedido, pedido, produto) =>
                    {
                        itemPedido.Pedidio = pedido;
                        itemPedido.Produto = produto;
                        return itemPedido;
                    }, obj, splitOn: "idPedido, idProduto")
                : await _context.QueryAsync<ItemPedido, Pedido, Produto, ItemPedido>(@"update itempedido set idPedido = @idPedido, idProduto = @idProduto, quantidade = @quantidade where idItemPedido = @idItemPedido;
                    select i.idItemPedido, i.quantidade, p.idPedido, p2.idProduto, p2.nome, p2.descricao, p2.valorCompra, p2.valorVenda, p2.isAtivo from itempedido as i
                    inner join pedido p on i.idPedido = p.idPedido
                    inner join produto p2 on i.idProduto = p2.idProduto
                    where i.idItemPedido = @idItemPedido;", (itemPedido, pedido, produto) =>
                    {
                        itemPedido.Pedidio = pedido;
                        itemPedido.Produto = produto;
                        return itemPedido;
                    }, obj, splitOn: "idPedido, idProduto");
            return result.Single();
        }

        public async Task<ItemPedido> SelecionarId(int id)
        {
            var result = await _context.QueryAsync<ItemPedido, Pedido, Produto, ItemPedido>(@"select i.idItemPedido, i.quantidade, p.idPedido, p2.idProduto, p2.nome, p2.descricao, p2.valorCompra, p2.valorVenda, p2.isAtivo from itempedido as i
                inner join pedido p on i.idPedido = p.idPedido
                inner join produto p2 on i.idProduto = p2.idProduto
                where i.idItemPedido = @idItemPedido;", (itemPedido, pedido, produto) =>
            {
                itemPedido.Pedidio = pedido;
                itemPedido.Produto = produto;
                return itemPedido;
            }, new { idItemPedido = id }, splitOn: "idPedido, idProduto");
            return result.SingleOrDefault();
        }

        public async Task<List<ItemPedido>> SelecionarPorPedido(int id)
        {
            var result = await _context.QueryAsync<ItemPedido, Pedido, Produto, ItemPedido>(@"select i.idItemPedido, i.quantidade, p.idPedido, p2.idProduto, p2.nome, p2.descricao, p2.valorCompra, p2.valorVenda, p2.isAtivo from itempedido as i
                inner join pedido p on i.idPedido = p.idPedido
                inner join produto p2 on i.idProduto = p2.idProduto
                where i.idPedido = @idPedido;", (itemPedido, pedido, produto) =>
            {
                itemPedido.Pedidio = pedido;
                itemPedido.Produto = produto;
                return itemPedido;
            }, new { idPedido = id }, splitOn: "idPedido, idProduto");
            return result.ToList();
        }

        public async Task<List<ItemPedido>> SelecionarTodos(bool selecionarTodos)
        {
            var result = await _context.QueryAsync<ItemPedido, Pedido, Produto, ItemPedido>(@"select i.idItemPedido, i.quantidade, p.idPedido, p2.idProduto, p2.nome, p2.descricao, p2.valorCompra, p2.valorVenda, p2.isAtivo from itempedido as i
                inner join pedido p on i.idPedido = p.idPedido
                inner join produto p2 on i.idProduto = p2.idProduto;", (itemPedido, pedido, produto) =>
                    {
                        itemPedido.Pedidio = pedido;
                        itemPedido.Produto = produto;
                        return itemPedido;
                    }, null, splitOn: "idPedido, idProduto");               
            return result.ToList();
        }

        public async Task<List<ItemPedido>> SelecionarTodosPorData(DateTime data)
        {
            var result = await _context.QueryAsync<ItemPedido, Pedido, Produto, ItemPedido>(@"select i.idItemPedido, i.quantidade, p.idPedido, p2.idProduto, p2.nome, p2.descricao, p2.valorCompra, p2.valorVenda, p2.isAtivo from itempedido as i
                inner join pedido p on i.idPedido = p.idPedido
                inner join produto p2 on i.idProduto = p2.idProduto
                where DATE_FORMAT(p.data, '%d/%m/%Y') = DATE_FORMAT(@data, '%d/%m/%Y') ;", (itemPedido, pedido, produto) =>
            {
                itemPedido.Pedidio = pedido;
                itemPedido.Produto = produto;
                return itemPedido;
            }, new { data }, splitOn: "idPedido, idProduto");
            return result.ToList();
        }

        public async Task<int> TotalRegistros()
        {
            var result = await _context.QueryAsync<int>(@"select count(*) from categoria;", null);
            return result.Single();
        }
    }
}
