using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface ICidadeRepository
    {
        /// <summary>
        /// Selecionar todas cidades
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Cidade>> SelecionarTodos();
        /// <summary>
        /// Selecionar cidades ativas
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Cidade>> SelecionarTodosAtivos();
        /// <summary>
        /// Selecionar cidades inativas
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Cidade>> SelecionarTodosInativos();
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
        /// <param name="cidade"></param>
        /// <returns></returns>
        Task<Cidade> Alterar(Cidade cidade);
        /// <summary>
        /// Remover cidade
        /// </summary>
        /// <param name="cidade"></param>
        /// <returns></returns>
        Task Remover(Cidade cidade);
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
