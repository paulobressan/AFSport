using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Interface.Service
{
    public interface ICategoriaService
    {
        /// <summary>
        /// Selecionar todas categorias
        /// </summary>
        /// <returns></returns>
        Task<List<Categoria>> SelecionarTodos();
        /// <summary>
        /// Selecionar todas categorias ativas
        /// </summary>
        /// <returns></returns>
        Task<List<Categoria>> SelecionarTodosAtivo();
        /// <summary>
        /// Selecionar todas categorias Inativas
        /// </summary>
        /// <returns></returns>
        Task<List<Categoria>> SelecionarTodosInativo();
        /// <summary>
        /// Selecionar categoria por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Categoria> SelecionarId(int id);
        /// <summary>
        /// Inserir nova categoria
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        Task<Categoria> Inserir(Categoria categoria);
        /// <summary>
        /// Alterar categoria
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        Task<Categoria> Alterar(int id, Categoria categoria);
        /// <summary>
        /// Remover categoria
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Remover(int id);
        /// <summary>
        /// Selecionar total de categoria
        /// </summary>
        /// <returns></returns>
        Task<int> TotalRegistros();
    }
}