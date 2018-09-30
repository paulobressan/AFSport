using AFSport.Web.Core.Base;
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
    public class PrecoRepository : BaseRepository, IPrecoRepository
    {
        public PrecoRepository()
        {
        }

        public Task Remover(Preco obj)
        {
            throw new NotImplementedException();
        }

        public async Task<Preco> Salvar(Preco obj)
        {
            var result = obj.IdPreco == 0
                ? await _context.QueryAsync<Preco, Produto, Preco>(@"insert into preco(idProduto, dataInicio, dataFinal, valor, isAtivo) values (@idProduto, @dataInicio, @dataFinal, @valor, @isAtivo);
                    select p.idPreco, p.valor, p.dataInicio, p.dataFinal, p.isAtivo, p2.idProduto, p2.nome, p2.descricao, p2.valorVenda, p2.valorCompra, p2.isAtivo from preco p
                    inner join produto p2 on p.idProduto = p2.idProduto
                    where p.idPreco = (select  last_insert_id() as id);", (preco, produto) =>
                    {
                        preco.Produto = produto;
                        return preco;
                    },obj, splitOn: "idProduto")
                : await _context.QueryAsync<Preco, Produto, Preco>(@"update preco set idProduto = @idProduto, dataInicio = @dataInicio, dataFinal = @dataFinal, valor = @valor, isAtivo = @isAtivo
                    where idPreco = @idPreco;
                    select p.idPreco, p.valor, p.dataInicio, p.dataFinal, p.isAtivo, p2.idProduto, p2.nome, p2.descricao, p2.valorVenda, p2.valorCompra, p2.isAtivo from preco p
                    inner join produto p2 on p.idProduto = p2.idProduto
                    where p.idPreco = @idPreco;", (preco, produto) =>
                    {
                        preco.Produto = produto;
                        return preco;
                    }, obj, splitOn: "idProduto");
            return result.Single();
        }

        public async Task<Preco> SelecionarId(int id)
        {
            var result = await _context.QueryAsync<Preco, Produto, Preco>(@"select p.idPreco, p.valor, p.dataInicio, p.dataFinal, p.isAtivo, p2.idProduto, p2.nome, p2.descricao, p2.valorVenda, p2.valorCompra, p2.isAtivo from preco p
                inner join produto p2 on p.idProduto = p2.idProduto
                where p.idProduto = @idProduto;", (preco, produto) =>
            {
                preco.Produto = produto;
                return preco;
            }, new { idProduto = id }, splitOn: "idProduto");
            return result.SingleOrDefault();
        }

        public async Task<List<Preco>> SelecionarTodos(bool selecionarTodos)
        {
            var result = selecionarTodos
                ? await _context.QueryAsync<Preco, Produto, Preco>(@"select p.idPreco, p.valor, p.dataInicio, p.dataFinal, p.isAtivo, p2.idProduto, p2.nome, p2.descricao, p2.valorVenda, p2.valorCompra, p2.isAtivo from preco p
                    inner join produto p2 on p.idProduto = p2.idProduto
                    where  p2.isAtivo = 1;", (preco, produto) =>
                    {
                        preco.Produto = produto;
                        return preco;
                    }, null, splitOn: "idProduto")
                : await _context.QueryAsync<Preco, Produto, Preco>(@"select p.idPreco, p.valor, p.dataInicio, p.dataFinal, p.isAtivo, p2.idProduto, p2.nome, p2.descricao, p2.valorVenda, p2.valorCompra, p2.isAtivo from preco p
                    inner join produto p2 on p.idProduto = p2.idProduto
                    where p2.isAtivo = 1 and p.isAtivo = 1;", (preco, produto) =>
                    {
                        preco.Produto = produto;
                        return preco;
                    }, null, splitOn: "idProduto");
            return result.ToList();
        }

        public async Task<Preco> SelecionarPorIdProdutoEIntervaloData(int idProduto)
        {
            var result = await _context.QueryAsync<Preco, Produto, Preco>(@"select p.idPreco, p.valor, p.dataInicio, p.dataFinal, p.isAtivo, p2.idProduto, p2.nome, p2.descricao, p2.valorVenda, p2.valorCompra, p2.isAtivo from preco p
            inner join produto p2 on p.idProduto = p2.idProduto
            where  p2.isAtivo = 1 and p.isAtivo = 1 
            and p2.idProduto = @idProduto and dataInicio <= DATE_FORMAT(now(), '%d/%m/%Y')
            and dataFinal >= DATE_FORMAT(now(), '%d/%m/%Y');", (preco, produto) =>
            {
                preco.Produto = produto;
                return preco;
            }, new { idProduto }, splitOn: "idProduto");
            return result.SingleOrDefault();
        }
    }
}
