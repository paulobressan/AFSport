using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IEstadoRepository
    {
        Task<List<Estado>> SelecionarTodos(bool selecionarTodos);
        Task<Estado> SelecionarId(int id);
        Task<Estado> Salvar(Estado obj);
        Task Remover(Estado obj);
        Task<int> TotalRegistros();
    }
}
