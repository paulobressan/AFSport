using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface ICaixaRepository
    {
        /// <summary>
        /// Selecionar todos os caixar abertos
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Caixa>> SelecionarTodos();
        /// <summary>
        /// Selecionar caixa por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Caixa> SelecionarId(int id);
        /// <summary>
        /// Inserir um novo caixa
        /// </summary>
        /// <param name="caixa"></param>
        /// <returns></returns>
        Task<Caixa> Inserir(Caixa caixa);
        /// <summary>
        /// Alterar caixa
        /// </summary>
        /// <param name="caixa"></param>
        /// <returns></returns>
        Task<Caixa> Alterar(Caixa caixa);
        /// <summary>
        /// Remover Caixa
        /// </summary>
        /// <param name="caixa"></param>
        /// <returns></returns>
        Task Remover(Caixa caixa);
        /// <summary>
        /// Selecionar caixa por data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<Caixa> SelecionarPorData(DateTime data);
        /// <summary>
        /// Selecionar caixa da data atual
        /// </summary>
        /// <returns></returns>
        Task<Caixa> SelecionarPorDataAtual(DateTime data);
        /// <summary>
        /// Selecionar total de caixa registrado
        /// </summary>
        /// <returns></returns>
        Task<int> TotalRegistros();
    }
}
