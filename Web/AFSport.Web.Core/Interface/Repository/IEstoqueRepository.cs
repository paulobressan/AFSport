using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IEstoqueRepository
    {
        Task<List<Estoque>> SelecionarTodos(bool selecionarTodos);
        Task<Estoque> SelecionarId(int id);
        Task<Estoque> Salvar(Estoque obj);
        Task Remover(Estoque obj);
        Task<Estoque> SelecionarEstoquePorProduto(int idProduto);
    }
}
