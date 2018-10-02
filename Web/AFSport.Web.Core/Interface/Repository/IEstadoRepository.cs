using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IEstadoRepository
    {
        /// <summary>
        /// Selecionar todos estados
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Estado>> SelecionarTodos();
        /// <summary>
        /// Selecionar todos estados ativos
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Estado>> SelecionarTodosAtivos();
        /// <summary>
        /// Selecionar todos estados inativos
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Estado>> SelecionarTodosInativos();
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
        Task<Estado> Alterar(Estado estado);
        /// <summary>
        /// Remover estado
        /// </summary>
        /// <param name="estado"></param>
        /// <returns></returns>
        Task Remover(Estado estado);
        /// <summary>
        /// Selecionar total de estados registrado
        /// </summary>
        /// <returns></returns>
        Task<int> TotalRegistros();
    }
}
