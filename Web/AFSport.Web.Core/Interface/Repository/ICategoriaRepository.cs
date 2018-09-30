using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> SelecionarTodos(bool selecionarTodos);
        Task<Categoria> SelecionarId(int id);
        Task<Categoria> Salvar(Categoria obj);
        Task Remover(Categoria obj);
        Task<int> TotalRegistros();
    }
}
