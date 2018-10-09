using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Service
{
    public interface IItemPedidoService
    {
        /// <summary>
        /// Selecionar item pedido por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ItemPedido> SelecionarId(int id);
        /// <summary>
        /// Inserir novo item pedido
        /// </summary>
        /// <param name="itemPedido"></param>
        /// <returns></returns>
        Task<ItemPedido> Inserir(ItemPedido itemPedido);
        /// <summary>
        /// Alterar item pedido
        /// </summary>
        /// <param name="itemPedido"></param>
        /// <param name="idItemPedido"></param>
        /// <returns></returns>
        Task<ItemPedido> Alterar(int idItemPedido, ItemPedido itemPedido);
        /// <summary>
        /// Remover item pedido
        /// </summary>
        /// <param name="idItemPedido"></param>
        /// <returns></returns>
        Task Remover(int idItemPedido);
        /// <summary>
        /// Selecionar item pedido por id do pedido
        /// </summary>
        /// <param name="idPedido"></param>
        /// <returns></returns>
        Task<IList<ItemPedido>> SelecionarPorPedido(int idPedido);
    }
}
