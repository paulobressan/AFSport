using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface ICidadeRepository
    {
        Task<List<Cidade>> SelecionarTodos(bool selecionarTodos);
        Task<Cidade> SelecionarId(int id);
        Task<Cidade> Salvar(Cidade obj);
        Task Remover(Cidade obj);
        Task<int> TotalRegistros();
    }
}
