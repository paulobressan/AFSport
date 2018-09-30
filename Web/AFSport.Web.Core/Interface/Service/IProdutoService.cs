using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Interface.Service
{
    public interface IProdutoService
    {
        /// <summary>
        /// Seleciona todos os produtos ativos
        /// </summary>
        /// <returns></returns>
        Task<List<Produto>> SelecionarTodosAtivos();
        /// <summary>
        /// Seleciona todos os produtos inativos
        /// </summary>
        /// <returns></returns>
        Task<List<Produto>> SelecionarTodosInativos();
        /// <summary>
        /// Seleciona todos os produtos
        /// </summary>
        /// <returns></returns>
        Task<List<Produto>> SelecionarTodos();
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
        Task<Produto> Alterar(int id, Produto obj);
        /// <summary>
        /// Remover Produto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Remover(int id);
        /// <summary>
        /// Filtrar produto por nome ou Id
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        Task<List<Produto>> SelecionarPorNomeId(string valor);
        /// <summary>
        /// Selecionar todos produto que contem estoque
        /// </summary>
        /// <returns></returns>
        Task<List<Produto>> SelecionarProdutosComEstoque();
        /// <summary>
        /// Selecionar todos produto que não contem estoque
        /// </summary>
        /// <returns></returns>
        Task<List<Produto>> SelecionarProdutosSemEstoque();
        /// <summary>
        /// Selecionar produto pela categoria
        /// </summary>
        /// <param name="idCategoria"></param>
        /// <returns></returns>
        Task<List<Produto>> SelecionarProdutosPorCategoria(int idCategoria);
        /// <summary>
        /// Selecionar total de produtos 
        /// </summary>
        /// <returns></returns>
        Task<int> TotalRegistros();
    }
}