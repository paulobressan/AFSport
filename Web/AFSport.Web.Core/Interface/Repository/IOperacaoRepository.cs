using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IOperacaoRepository
    {
        Task<List<Operacao>> SelecionarTodos(bool selecionarTodos);
        Task<Operacao> SelecionarId(int id);
        Task<Operacao> Salvar(Operacao obj);
        Task Remover(Operacao obj);
    }
}
