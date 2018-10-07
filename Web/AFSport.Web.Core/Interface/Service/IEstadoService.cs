using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Interface.Service
{
    public interface IEstadoService
    {
         /// <summary>
        /// Selecionar todos estados
        /// </summary>
        /// <returns></returns>
        Task<IList<Estado>> SelecionarTodos();
        /// <summary>
        /// Selecionar todos estados ativos
        /// </summary>
        /// <returns></returns>
        Task<IList<Estado>> SelecionarTodosAtivos();
        /// <summary>
        /// Selecionar todos estados inativos
        /// </summary>
        /// <returns></returns>
        Task<IList<Estado>> SelecionarTodosInativos();
        /// <summary>
        /// Selecionar estado por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Estado> SelecionarId(int id);
        /// <summary>
        /// Inserir um novo estado
        /// </summary>
        /// <param name="estado"></param>
        /// <returns></returns>
        Task<Estado> Inserir(Estado estado);
        /// <summary>
        /// Alterar estado
        /// </summary>
        /// <param name="estado"></param>
        /// <returns></returns>
        Task<Estado> Alterar(int idEstado, Estado estado);
        /// <summary>
        /// Remover estado
        /// </summary>
        /// <param name="idEstado"></param>
        /// <returns></returns>
        Task Remover(int idEstado);
        /// <summary>
        /// Selecionar total de estados registrado
        /// </summary>
        /// <returns></returns>
        Task<int> TotalRegistros();
    }
}