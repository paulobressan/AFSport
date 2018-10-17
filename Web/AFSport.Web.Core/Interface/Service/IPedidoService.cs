using AFSport.Web.Core.Enum;
using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Service
{
    public interface IPedidoService
    {
        /// <summary>
        /// Selecionar todos pedidos
        /// </summary>
        /// <returns></returns>
        Task<IList<Pedido>> SelecionarTodos();
        /// <summary>
        /// Selecionar pedido por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Pedido> SelecionarId(int id);
        /// <summary>
        /// Inserir novo pedido
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        Task<Pedido> Inserir(Pedido pedido);
        /// <summary>
        /// Alterar pedido
        /// </summary>
        /// <param name="idPedido"></param>
        /// <param name="pedido"></param>
        /// <returns></returns>
        Task<Pedido> Alterar(int idPedido, Pedido pedido);
        /// <summary>
        /// Remover pedido
        /// </summary>
        /// <param name="idPedido"></param>
        /// <returns></returns>
        Task Remover(int idPedido);
        /// <summary>
        /// Selecionar todos pedidos do dia
        /// </summary>
        /// <returns></returns>
        Task<IList<Pedido>> SelecionarTodosDiario();
        /// <summary>
        /// Selecionar pedidos por cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        Task<IList<Pedido>> SelecionarPorCliente(int idCliente);
        /// <summary>
        /// Cancelar pedido
        /// </summary>
        /// <param name="idPedido"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        Task<Pedido> CancelarPedido(int idPedido);
        /// <summary>
        /// Selecionar total de registro de pedidos
        /// </summary>
        /// <returns></returns>
        Task<int> TotalRegistros();
    }
}
