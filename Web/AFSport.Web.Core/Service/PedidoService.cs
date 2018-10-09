using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class PedidoService : IPedidoService
    {
        public Task<Pedido> Alterar(Pedido pedido)
        {
            throw new System.NotImplementedException();
        }

        public Task<Pedido> Inserir(Pedido pedido)
        {
            throw new System.NotImplementedException();
        }

        public Task Remover(int idPedido)
        {
            throw new System.NotImplementedException();
        }

        public Task<Pedido> SelecionarId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Pedido>> SelecionarTodos()
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Pedido>> SelecionarTodosDiario()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> TotalRegistros()
        {
            throw new System.NotImplementedException();
        }
    }
}