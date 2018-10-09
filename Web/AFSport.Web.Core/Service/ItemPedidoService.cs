using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class ItemPedidoService : IItemPedidoService
    {
        #region Objetos
        private readonly IItemPedidoRepository _itemPedidoRepository;
        private readonly IPedidoRepository _pedidoRepository;
        #endregion

        #region Construtor
        public ItemPedidoService(IItemPedidoRepository itemPedidoRepository, IPedidoRepository pedidoRepository)
        {
            this._itemPedidoRepository = itemPedidoRepository;
            this._pedidoRepository = pedidoRepository;
        }
        #endregion

        public async Task<ItemPedido> Alterar(int idItemPedido, ItemPedido itemPedido)
        {
            try
            {
                await SelecionarId(idItemPedido);
                return await _itemPedidoRepository.Alterar(itemPedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ItemPedido> Inserir(ItemPedido itemPedido)
        {
            try
            {
                return await _itemPedidoRepository.Inserir(itemPedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Remover(int idItemPedido)
        {
            try
            {
                var itemPedido = await SelecionarId(idItemPedido);
                await _itemPedidoRepository.Remover(itemPedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ItemPedido> SelecionarId(int id)
        {
            try
            {
                return await _itemPedidoRepository.SelecionarId(id) ??
                    throw new KeyNotFoundException("ItemPedido não encontrado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<ItemPedido>> SelecionarPorPedido(int idPedido)
        {
            try
            {
                var pedido = await _pedidoRepository.SelecionarId(idPedido) ??
                    throw new KeyNotFoundException("Pedido não encontrado para esse item");

                return (await _itemPedidoRepository.SelecionarPorPedido(pedido.IdPedido))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}