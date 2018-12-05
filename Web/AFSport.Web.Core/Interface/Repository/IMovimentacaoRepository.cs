using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IMovimentacaoRepository
    {
        /// <summary>
        /// Selecionar todas movimentação
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Movimentacao>> SelecionarTodos();
        /// <summary>
        /// Selecionar movimentação por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Movimentacao> SelecionarId(int id);
        /// <summary>
        /// Inserir nova movimentação
        /// </summary>
        /// <param name="movimentacao"></param>
        /// <returns></returns>
        Task<Movimentacao> Inserir(Movimentacao movimentacao);
        /// <summary>
        /// Alterar movimentação
        /// </summary>
        /// <param name="movimentacao"></param>
        /// <returns></returns>
        Task<Movimentacao> Alterar(Movimentacao movimentacao);
        /// <summary>
        /// Selecionar movimentação do dia
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<IEnumerable<Movimentacao>> SelecionarMovimentacaoPorDia(DateTime data);
        /// <summary>
        /// Selecionar movimentações por operação
        /// </summary>
        /// <param name="idOperacao"></param>
        /// <returns></returns>
        Task<IEnumerable<Movimentacao>> SelecionarMovimentacaoPorOperacao(int idOperacao);
        /// <summary>
        /// Selecionar total de movimentação
        /// </summary>
        /// <returns></returns>
        Task<int> TotalRegistros();
    }
}
