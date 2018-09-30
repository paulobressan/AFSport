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
        Task<List<Cidade>> SelecionarTodos();
        /// <summary>
        /// Selecionar cidades ativas
        /// </summary>
        /// <returns></returns>
        Task<List<Cidade>> SelecionarTodosAtivo();
        /// <summary>
        /// Selecionar cidades inativas
        /// </summary>
        /// <returns></returns>
        Task<List<Cidade>> SelecionarTodosInativo();
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
        /// Selecionar total de cidades registrada
        /// </summary>
        /// <returns></returns>
        Task<int> TotalRegistros();
    }
}
