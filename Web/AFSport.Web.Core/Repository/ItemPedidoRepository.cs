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
    public class ItemPedidoRepository : BaseRepository, IItemPedidoRepository
    {
        public ItemPedidoRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task Remover(int idItemPedido)
        {
            await _context.QueryAsync<ItemPedido>(@"delete from itemPedido 
                where idItemPedido = @idItemPedido", new { idItemPedido });
        }

        public async Task<ItemPedido> Inserir(ItemPedido itemPedido)
        {
            return (await _context.QueryAsync<ItemPedido, Pedido, Produto, ItemPedido>(@"insert into itempedido(idPedido, idProduto, quantidade) values (@idPedido, @idProduto, @quantidade);
                select i.idItemPedido, i.quantidade, p.idPedido, p2.idProduto, p2.nome, p2.descricao, p2.valorCompra, p2.valorVenda, p2.isAtivo from itempedido as i
                inner join pedido p on i.idPedido = p.idPedido
                inner join produto p2 on i.idProduto = p2.idProduto
                where i.idItemPedido = (select last_insert_id() as id);", (itemPedidop, pedido, produto) =>
                {
                    itemPedidop.Pedidio = pedido;
                    itemPedidop.Produto = produto;
                    return itemPedidop;
                }, itemPedido, splitOn: "idPedido, idProduto"))
                .Single();
        }

        public async Task<ItemPedido> Alterar(ItemPedido itemPedido)
        {
            return (await _context.QueryAsync<ItemPedido, Pedido, Produto, ItemPedido>(@"update itempedido set idPedido = @idPedido, idProduto = @idProduto, quantidade = @quantidade where idItemPedido = @idItemPedido;
                select i.idItemPedido, i.quantidade, p.idPedido, p2.idProduto, p2.nome, p2.descricao, p2.valorCompra, p2.valorVenda, p2.isAtivo from itempedido as i
                inner join pedido p on i.idPedido = p.idPedido
                inner join produto p2 on i.idProduto = p2.idProduto
                where i.idItemPedido = @idItemPedido;", (itemPedidop, pedido, produto) =>
                {
                    itemPedidop.Pedidio = pedido;
                    itemPedidop.Produto = produto;
                    return itemPedidop;
                }, itemPedido, splitOn: "idPedido, idProduto"))
                .Single();
        }

        public async Task<ItemPedido> SelecionarId(int id)
        {
            return (await _context.QueryAsync<ItemPedido, Pedido, Produto, ItemPedido>(@"select i.idItemPedido, i.quantidade, p.idPedido, p2.idProduto, p2.nome, p2.descricao, p2.valorCompra, p2.valorVenda, p2.isAtivo from itempedido as i
                inner join pedido p on i.idPedido = p.idPedido
                inner join produto p2 on i.idProduto = p2.idProduto
                where i.idItemPedido = @idItemPedido;", (itemPedido, pedido, produto) =>
                {
                    itemPedido.Pedidio = pedido;
                    itemPedido.Produto = produto;
                    return itemPedido;
                }, new { idItemPedido = id }, splitOn: "idPedido, idProduto"))
                .SingleOrDefault();
        }

        public async Task<IEnumerable<ItemPedido>> SelecionarPorPedido(int id)
        {
            return await _context.QueryAsync<ItemPedido, Pedido, Produto, ItemPedido>(@"select i.idItemPedido, i.quantidade, p.idPedido, p2.idProduto, p2.nome, p2.descricao, p2.valorCompra, p2.valorVenda, p2.isAtivo from itempedido as i
                inner join pedido p on i.idPedido = p.idPedido
                inner join produto p2 on i.idProduto = p2.idProduto
                where i.idPedido = @idPedido;", (itemPedido, pedido, produto) =>
                {
                    itemPedido.Pedidio = pedido;
                    itemPedido.Produto = produto;
                    return itemPedido;
                }, new { idPedido = id }, splitOn: "idPedido, idProduto");
        }
    }
}
