using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IProdutoRepository
    {
        /// <summary>
        /// Seleciona todos os produtos ativos
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Produto>> SelecionarTodosAtivos();
        /// <summary>
        /// Seleciona todos os produtos inativos
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Produto>> SelecionarTodosInativos();
        /// <summary>
        /// Seleciona todos os produtos
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Produto>> SelecionarTodos();
        /// <summary>
        /// Seleciona produto por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Produto> SelecionarId(int id);
        /// <summary>
        /// Adicionar novo produto
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        Task<Produto> Inserir(Produto obj);
        /// <summary>
        /// Alterar produto
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        Task<Produto> Alterar(Produto obj);
        /// <summary>
        /// Remover produto
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        Task Remover(Produto obj);
        /// <summary>
        /// Filtrar produto por nome ou Id
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        Task<IEnumerable<Produto>> SelecionarPorNomeId(string valor);
        /// <summary>
        /// Selecionar todos produto que contem estoque
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Produto>> SelecionarProdutosComEstoque();
        /// <summary>
        /// Selecionar todos produto que não contem estoque
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Produto>> SelecionarProdutosSemEstoque();
        /// <summary>
        /// Selecionar produto pela categoria
        /// </summary>
        /// <param name="idCategoria"></param>
        /// <returns></returns>
        Task<IEnumerable<Produto>> SelecionarProdutosPorCategoria(int idCategoria);
        /// <summary>
        /// Selecionar total de produtos 
        /// </summary>
        /// <returns></returns>
        Task<int> TotalRegistros();
    }
}
