using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IItemPedidoRepository
    {
        Task<List<ItemPedido>> SelecionarTodos(bool selecionarTodos);
        Task<ItemPedido> SelecionarId(int id);
        Task<ItemPedido> Salvar(ItemPedido obj);
        Task Remover(ItemPedido obj);
        Task<List<ItemPedido>> SelecionarPorPedido(int id);
        Task<List<ItemPedido>> SelecionarTodosPorData(DateTime data);
        Task<int> TotalRegistros();
    }
}
