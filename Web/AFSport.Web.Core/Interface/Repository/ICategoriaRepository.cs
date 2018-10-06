using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface ICategoriaRepository
    {
        /// <summary>
        /// Selecionar todas categorias
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Categoria>> SelecionarTodos();
        /// <summary>
        /// Selecionar todas categorias ativas
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Categoria>> SelecionarTodosAtivo();
        /// <summary>
        /// Selecionar todas categorias Inativas
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Categoria>> SelecionarTodosInativo();
        /// <summary>
        /// Selecionar categoria por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Categoria> SelecionarId(int id);
        /// <summary>
        /// Inserir nova categoria
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        Task<Categoria> Inserir(Categoria obj);
        /// <summary>
        /// Alterar categoria
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        Task<Categoria> Alterar(Categoria obj);
        /// <summary>
        /// Remover categoria
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        Task Remover(Categoria obj);
        /// <summary>
        /// Ativar ou inativar categoria
        /// </summary>
        /// <param name="idCategoria"></param>
        /// <param name="isAtivo"></param>
        /// <returns></returns>
        Task AtivarInativar(int idCategoria, bool isAtivo);
        /// <summary>
        /// Selecionar total de categoria
        /// </summary>
        /// <returns></returns>
        Task<int> TotalRegistros();
    }
}
