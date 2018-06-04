using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Interfaces
{
    public interface ICRUD<T>
    {
        Task<List<T>> SelecionarTodos(bool selecionarTodos);
        Task<T> SelecionarId(int id);
        Task<T> Salvar(T obj);
        Task Remover(T obj);
    }
}
