using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IMovimentacaoRepository
    {
        Task<List<Movimentacao>> SelecionarTodos(bool selecionarTodos);
        Task<Movimentacao> SelecionarId(int id);
        Task<Movimentacao> Salvar(Movimentacao obj);
        Task Remover(Movimentacao obj);
        Task<List<Movimentacao>> SelecionarMovimentacaoPorCaixa(DateTime data);
        Task<int> TotalRegistros();
    }
}
