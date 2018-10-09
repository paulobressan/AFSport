using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Interface.Service
{
    public interface ICidadeService
    {
         /// <summary>
        /// Selecionar todas cidades
        /// </summary>
        /// <returns></returns>
        Task<IList<Cidade>> SelecionarTodos();
        /// <summary>
        /// Selecionar cidades ativas
        /// </summary>
        /// <returns></returns>
        Task<IList<Cidade>> SelecionarTodosAtivos();
        /// <summary>
        /// Selecionar cidades inativas
        /// </summary>
        /// <returns></returns>
        Task<IList<Cidade>> SelecionarTodosInativos();
        /// <summary>
        /// Selecionar cidade por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Cidade> SelecionarId(int id);
        /// <summary>
        /// Inserir nova cidade
        /// </summary>
        /// <param name="cidade"></param>
        /// <returns></returns>
        Task<Cidade> Inserir(Cidade cidade);        
        /// <summary>
        /// Alterar cidade
        /// </summary>
        /// <param name="idCidade"></param>
        /// <param name="cidade"></param>
        /// <returns></returns>
        Task<Cidade> Alterar(int idCidade, Cidade cidade);
        /// <summary>
        /// Remover cidade
        /// </summary>
        /// <param name="idCidade"></param>
        /// <returns></returns>
        Task Remover(int idCidade);
        /// <summary>
        /// Ativar ou inativar cidade
        /// </summary>
        /// <param name="idCidade"></param>
        /// <param name="isAtivo"></param>
        /// <returns></returns>
        Task AtivarInativar(int idCidade, bool isAtivo);
        /// <summary>
        /// Selecionar total de cidades registrada
        /// </summary>
        /// <returns></returns>
        Task<int> TotalRegistros();
    }
}