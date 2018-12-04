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
        private readonly IProdutoRepository _produtoRepository;
        #endregion

        #region Construtor
        public ItemPedidoService(
            IItemPedidoRepository itemPedidoRepository,
            IPedidoRepository pedidoRepository,
            IProdutoRepository produtoRepository)
        {
            this._itemPedidoRepository = itemPedidoRepository;
            this._pedidoRepository = pedidoRepository;
            this._produtoRepository = produtoRepository;
        }
        #endregion

        public async Task<ItemPedido> Alterar(int idPedido, int idItemPedido, ItemPedido itemPedido)
        {
            try
            {
                await ValidarItemProdutoExistente(idItemPedido);
                await ValidarPedidoExistente(idPedido);
                itemPedido.IdPedido = idPedido;
                await ValidarProdutoExistente(itemPedido.IdProduto);
                return await _itemPedidoRepository.Alterar(itemPedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ItemPedido> Inserir(int idPedido, ItemPedido itemPedido)
        {
            try
            {
                await ValidarPedidoExistente(idPedido);
                itemPedido.IdPedido = idPedido;
                await ValidarProdutoExistente(itemPedido.IdProduto);
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
                await ValidarItemProdutoExistente(idItemPedido);
                await _itemPedidoRepository.Remover(idItemPedido);
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
                    throw new KeyNotFoundException("Item do pedido não encontrado");
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
                await ValidarPedidoExistente(idPedido);
                return (await _itemPedidoRepository.SelecionarPorPedido(idPedido))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task ValidarItemProdutoExistente(int idItemProduto)
        {
            if (await _itemPedidoRepository.SelecionarId(idItemProduto) == null)
                throw new KeyNotFoundException("Item do pedido não encontrado");
        }

        private async Task ValidarProdutoExistente(int idCidade)
        {
            if (await _produtoRepository.SelecionarId(idCidade) == null)
                throw new KeyNotFoundException("Produto não encontrado");
        }

        private async Task ValidarPedidoExistente(int idPedido)
        {
            if (await _pedidoRepository.SelecionarId(idPedido) == null)
                throw new KeyNotFoundException("Pedido não encontrado");
        }
    }
}