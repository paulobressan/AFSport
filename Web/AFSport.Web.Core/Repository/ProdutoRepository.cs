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
    public class ProdutoRepository : BaseRepository, IProdutoRepository
    {
        public ProdutoRepository(IConfiguration configuration)
            : base(configuration) { }

        public async Task<Produto> SelecionarId(int id)
        {
            return (await _context.QueryAsync<Produto, Categoria, Produto>(@"select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria c on p.idCategoria = c.idCategoria where c.idCategoria = true and p.idProduto = @idProduto;", (produto, categoria) =>
                {
                    produto.Categoria = categoria;
                    return produto;
                }, new { idProduto = id }, splitOn: "idCategoria"))
             .Single();
        }

        public async Task<IEnumerable<Produto>> SelecionarPorNomeId(string valor)
        {
            return await _context.QueryAsync<Produto, Categoria, Produto>(@"select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria c on p.idCategoria = c.idCategoria 
                where c.isAtivo = true 
                and (p.idProduto = @valor or p.nome like concat('%', @valor, '%'));", (produto, categoria) =>
                {
                    produto.Categoria = categoria;
                    return produto;
                }, new { valor }, splitOn: "idCategoria");
        }

        public async Task<IEnumerable<Produto>> SelecionarProdutosComEstoque()
        {
            return await _context.QueryAsync<Produto, Categoria, Produto>(@"select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria c on p.idCategoria = c.idCategoria
                inner join estoque e on p.idProduto = e.idProduto
                where c.isAtivo = true;", (produto, categoria) =>
                {
                    produto.Categoria = categoria;
                    return produto;
                }, null, splitOn: "idCategoria");
        }

        public async Task<IEnumerable<Produto>> SelecionarProdutosSemEstoque()
        {
            return await _context.QueryAsync<Produto, Categoria, Produto>(@"select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria c on p.idCategoria = c.idCategoria
                left join estoque e on p.idProduto = e.idProduto
                where c.isAtivo = true and e.idEstoque is null;", (produto, categoria) =>
                {
                    produto.Categoria = categoria;
                    return produto;
                }, null, splitOn: "idCategoria");
        }

        public async Task<IEnumerable<Produto>> SelecionarProdutosPorCategoria(int idCategoria)
        {
            return await _context.QueryAsync<Produto, Categoria, Produto>(@"select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria c on p.idCategoria = c.idCategoria where c.isAtivo = true and c.idCategoria = @idCategoria;", (produto, categoria) =>
                {
                    produto.Categoria = categoria;
                    return produto;
                }, new { idCategoria }, splitOn: "idCategoria");
        }

        public async Task Remover(Produto obj)
        {
            await _context.QueryAsync<Produto>(@"delete from produto where idProduto = @idProduto");
        }

        public async Task<int> TotalRegistros()
        {
            return (await _context.QueryAsync<int>(@"select count(*) from produto isAtivo = true;", null))
                .Single();
        }

        public async Task<Produto> Inserir(Produto obj)
        {
            return (await _context.QueryAsync<Produto, Categoria, Produto>(@"insert into produto(idCategoria, nome, descricao, valorCompra, valorVenda, isAtivo) values (@idCategoria, @nome, @descricao, @valorCompra, @valorVenda, @isAtivo);
                select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria c on p.idCategoria = c.idCategoria where p.idProduto = (select last_insert_id() as id);",
                (produto, categoria) =>
                {
                    produto.Categoria = categoria;
                    return produto;
                }, obj, splitOn: "idCategoria"))
                .Single();
        }

        public async Task<Produto> Alterar(Produto obj)
        {
            return (await _context.QueryAsync<Produto, Categoria, Produto>(@"update produto set idCategoria = @idCategoria,  nome = @nome, descricao = @descricao, valorCompra = @valorCompra, valorVenda = @valorVenda, isAtivo = @isAtivo 
                where idProduto = @idProduto;
                select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria c on p.idCategoria = c.idCategoria where p.idProduto = @idProduto;", (produto, categoria) =>
                {
                    produto.Categoria = categoria;
                    return produto;
                }, obj, splitOn: "idCategoria"))
                .Single();
        }

        public async Task<IEnumerable<Produto>> SelecionarTodosAtivos()
        {
            return await _context.QueryAsync<Produto, Categoria, Produto>(@"select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria c on p.idCategoria = c.idCategoria where c.isAtivo = true", (produto, categoria) =>
                {
                    produto.Categoria = categoria;
                    return produto;
                }, null, splitOn: "idCategoria");
        }

        public async Task<IEnumerable<Produto>> SelecionarTodosInativos()
        {
            return await _context.QueryAsync<Produto, Categoria, Produto>(@"select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria c on p.idCategoria = c.idCategoria where c.isAtivo = true and p.isAtivo = true;", (produto, categoria) =>
                {
                    produto.Categoria = categoria;
                    return produto;
                }, null, splitOn: "idCategoria");
        }

        public async Task<IEnumerable<Produto>> SelecionarTodos()
        {
            return await _context.QueryAsync<Produto, Categoria, Produto>(@"select p.idProduto, p.nome, p.descricao, p.valorCompra, p.valorVenda, p.isAtivo,c.idCategoria, c.nome, c.descricao, c.isAtivo from produto as p
                inner join categoria as c on p.idCategoria = c.idCategoria where c.isAtivo = true", (produto, categoria) =>
                {
                    produto.Categoria = categoria;
                    return produto;
                }, null, splitOn: "idCategoria");
        }

         public async Task AtivarInativar(int idProduto, Boolean isAtivo)
        {
            await _context.QueryAsync(@"update produto set isAtivo = @isAtivo 
                where idProduto = @idProduto;", new { idProduto, isAtivo });
        }
    }
}
