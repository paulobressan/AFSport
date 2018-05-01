using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Interfaces
{
    public interface ICRUD<T>
    {
        List<T> SelecionarTodos();
        T SelecionarId(int id);
        T Salvar(T obj);
        T Ativar(T obj);
        T Inativar(T obj);
    }
}
