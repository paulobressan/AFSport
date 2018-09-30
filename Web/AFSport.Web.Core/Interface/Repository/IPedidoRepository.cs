using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IPedidoRepository
    {
        Task<List<Pedido>> SelecionarTodos(bool selecionarTodos);
        Task<Pedido> SelecionarId(int id);
        Task<Pedido> Salvar(Pedido obj);
        Task Remover(Pedido obj);
        Task<List<Pedido>> SelecionarTodosDiario();
        Task<int> TotalRegistros();
    }
}
