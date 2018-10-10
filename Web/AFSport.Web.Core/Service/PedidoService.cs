using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSport.Web.Core.Enum;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class PedidoService : IPedidoService
    {
        #region Objetos
        private readonly IPedidoRepository _pedidoRepository;
        #endregion

        #region Construtor
        public PedidoService(IPedidoRepository pedidoRepository)
        {
            this._pedidoRepository = pedidoRepository;
        }
        #endregion

        public async Task<Pedido> Alterar(int idPedido, Pedido Pedido)
        {
            try
            {
                await SelecionarId(idPedido);
                return await _pedidoRepository.Alterar(Pedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Pedido> CancelarPedido(int idPedido, PedidoStatus status)
        {
            try
            {
                var pedido = await _pedidoRepository.SelecionarId(idPedido) ??
                    throw new KeyNotFoundException("Pedido não encontrado");

                return await _pedidoRepository.AlterarStatusPedido(pedido.IdPedido, status);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Pedido> Inserir(Pedido Pedido)
        {
            try
            {
                return await _pedidoRepository.Inserir(Pedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Remover(int idPedido)
        {
            try
            {
                var Pedido = await SelecionarId(idPedido);
                await _pedidoRepository.Remover(Pedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Pedido> SelecionarId(int id)
        {
            try
            {
                return await _pedidoRepository.SelecionarId(id) ??
                    throw new KeyNotFoundException("Pedido não encontrado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Pedido>> SelecionarTodos()
        {
            try
            {
                return (await _pedidoRepository.SelecionarTodos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Pedido>> SelecionarTodosDiario()
        {
            try
            {
                return (await _pedidoRepository.SelecionarTodosDiario())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> TotalRegistros()
        {
            try
            {
                return await _pedidoRepository.TotalRegistros();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}