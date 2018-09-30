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
    public class ProdutoRepository : BaseRepository, ICRUD<Produto>
    {
        public async Task<Produto> Salvar(Produto obj)
        {
                var result = obj.IdProduto == 0
                    ? await _context.QueryAsync<Produto, Categoria, Produto>(@"insert into produto(idCategoria, nome, descricao, valorCompra, valorVenda, isAtivo) values (@idCategoria, @nome, @descricao, @valorCompra, @valorVenda, @isAtivo);
                        select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                        inner join categoria c on p.idCategoria = c.idCategoria where p.idProduto = (select last_insert_id() as id);", 
                        (produto, categoria) =>
                        {
                            produto.Categoria = categoria;
                            return produto;
                        }, obj, splitOn: "idCategoria")
                    : await _context.QueryAsync<Produto, Categoria, Produto>(@"update produto set idCategoria = @idCategoria,  nome = @nome, descricao = @descricao, valorCompra = @valorCompra, valorVenda = @valorVenda, isAtivo = @isAtivo 
                        where idProduto = @idProduto;
                        select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                        inner join categoria c on p.idCategoria = c.idCategoria where p.idProduto = @idProduto;",
                        (produto, categoria) =>
                        {
                            produto.Categoria = categoria;
                            return produto;
                        }, obj, splitOn: "idCategoria");
            return result.Single();

        }

        public async Task<Produto> SelecionarId(int id)
        {
            var result = await _context.QueryAsync<Produto, Categoria, Produto>(@"select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria c on p.idCategoria = c.idCategoria where c.idCategoria = true and c.idProduto = @idProduto;", (produto, categoria) =>
            {
                produto.Categoria = categoria;
                return produto;
            }, new { idProduto = id }, splitOn: "idCategoria");
            return result.Single();
        }

        public async Task<List<Produto>> SelecionarPorNomeId(string valor)
        {
            var result = await _context.QueryAsync<Produto, Categoria, Produto>(@"select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria c on p.idCategoria = c.idCategoria 
                where c.isAtivo = true 
                and (p.idProduto = @valor or p.nome like concat('%', @valor, '%'));", (produto, categoria) =>
            {
                produto.Categoria = categoria;
                return produto;
            }, new { valor }, splitOn: "idCategoria");
            return result.ToList();
        }

        public async Task<List<Produto>> SelecionarTodos(bool selecionarTodos)
        {
            var result = selecionarTodos 
                ? await _context.QueryAsync<Produto, Categoria, Produto>(@"select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria c on p.idCategoria = c.idCategoria where c.isAtivo = true", (produto, categoria) => 
                {
                    produto.Categoria = categoria;
                    return produto;
                },null, splitOn:"idCategoria")
                : await _context.QueryAsync<Produto, Categoria, Produto>(@"select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria c on p.idCategoria = c.idCategoria where c.isAtivo = true and p.isAtivo = true;", (produto, categoria) =>
                {
                    produto.Categoria = categoria;
                    return produto;
                }, null, splitOn: "idCategoria");
            return result.ToList();
        }

        public async Task<List<Produto>> SelecionarProdutosComEstoque()
        {
            var result = await _context.QueryAsync<Produto, Categoria, Produto>(@"select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria c on p.idCategoria = c.idCategoria
                inner join estoque e on p.idProduto = e.idProduto
                where c.isAtivo = true;", (produto, categoria) =>
                {
                    produto.Categoria = categoria;
                    return produto;
                }, null, splitOn: "idCategoria");              
            return result.ToList();
        }


        public async Task<List<Produto>> SelecionarProdutosSemEstoque()
        {
            var result = await _context.QueryAsync<Produto, Categoria, Produto>(@"select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria c on p.idCategoria = c.idCategoria
                left join estoque e on p.idProduto = e.idProduto
                where c.isAtivo = true and e.idEstoque is null;", (produto, categoria) =>
            {
                produto.Categoria = categoria;
                return produto;
            }, null, splitOn: "idCategoria");
            return result.ToList();
        }

        public async Task<List<Produto>> SelecionarProdutosPorCategoria(int idCategoria)
        {
            var result = await _context.QueryAsync<Produto, Categoria, Produto>(@"select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria c on p.idCategoria = c.idCategoria where c.isAtivo = true and c.idCategoria = @idCategoria;", (produto, categoria) =>
            {
                produto.Categoria = categoria;
                return produto;
            }, new { idCategoria }, splitOn:"idCategoria");
            return result.ToList();
        }

        public async Task Remover(Produto obj)
        {
            await _context.QueryAsync<Produto>(@"delete from produto where idProduto = @idProduto");
        }

        public async Task<int> TotalRegistros()
        {
            var result = await _context.QueryAsync<int>(@"select count(*) from produto isAtivo = true;", null);
            return result.Single();
        }
    }
}
