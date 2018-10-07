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
        Task<IList<Produto>> SelecionarTodosAtivos();
        /// <summary>
        /// Seleciona todos os produtos inativos
        /// </summary>
        /// <returns></returns>
        Task<IList<Produto>> SelecionarTodosInativos();
        /// <summary>
        /// Seleciona todos os produtos
        /// </summary>
        /// <returns></returns>
        Task<IList<Produto>> SelecionarTodos();
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
        Task<IList<Produto>> SelecionarPorNomeId(string valor);
        /// <summary>
        /// Selecionar todos produto que contem estoque
        /// </summary>
        /// <returns></returns>
        Task<IList<Produto>> SelecionarProdutosComEstoque();
        /// <summary>
        /// Selecionar todos produto que não contem estoque
        /// </summary>
        /// <returns></returns>
        Task<IList<Produto>> SelecionarProdutosSemEstoque();
        /// <summary>
        /// Selecionar produto pela categoria
        /// </summary>
        /// <param name="idCategoria"></param>
        /// <returns></returns>
        Task<IList<Produto>> SelecionarProdutosPorCategoria(int idCategoria);
        /// <summary>
        /// Ativar ou inativar produto
        /// </summary>
        /// <param name="idProduto"></param>
        /// <param name="isAtivo"></param>
        /// <returns></returns>
        Task AtivarInativar(int idProduto, bool isAtivo);
        /// <summary>
        /// Selecionar total de produtos 
        /// </summary>
        /// <returns></returns>
        Task<int> TotalRegistros();
    }
}