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
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IItemPedidoRepository _itemPedidoRepository;
        #endregion

        #region Construtor
        public PedidoService(
            IPedidoRepository pedidoRepository,
            IUsuarioRepository usuarioRepository,
            IClienteRepository clienteRepository,
            IItemPedidoRepository itemPedidoRepository)
        {
            this._pedidoRepository = pedidoRepository;
            this._usuarioRepository = usuarioRepository;
            this._clienteRepository = clienteRepository;
            this._itemPedidoRepository = itemPedidoRepository;
        }
        #endregion

        public async Task<Pedido> Alterar(int idPedido, Pedido pedido)
        {
            try
            {
                await ValidarPedidoExistente(idPedido);
                await ValidarClienteExistente(pedido.IdCliente);
                await ValidarUsuarioExistente(pedido.IdUsuario);
                return await _pedidoRepository.Alterar(pedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Pedido> CancelarPedido(int idPedido)
        {
            try
            {
                await ValidarPedidoExistente(idPedido);
                return await _pedidoRepository.AlterarStatusPedido(idPedido, PedidoStatus.Cancelado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Pedido> Inserir(Pedido pedido)
        {
            try
            {
                await ValidarClienteExistente(pedido.IdCliente);
                await ValidarUsuarioExistente(pedido.IdUsuario);
                return await _pedidoRepository.Inserir(pedido);
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
                await ValidarPedidoExistente(idPedido);
                await ValidarDependenciaDePedidoExistente(idPedido);
                await _pedidoRepository.Remover(idPedido);
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

        public async Task<IList<Pedido>> SelecionarPorCliente(int idCliente)
        {
            try
            {
                await ValidarClienteExistente(idCliente);
                return (await _pedidoRepository.SelecionarPorCliente(idCliente))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task ValidarPedidoExistente(int idPedido)
        {
            if (await _pedidoRepository.SelecionarId(idPedido) == null)
                throw new KeyNotFoundException("Pedido não encontrada");
        }

        private async Task ValidarClienteExistente(int idCliente)
        {
            if (await _clienteRepository.SelecionarId(idCliente) == null)
                throw new KeyNotFoundException("Cliente não encontrada");
        }

        private async Task ValidarUsuarioExistente(int idUsuario)
        {
            if (await _usuarioRepository.SelecionarId(idUsuario) == null)
                throw new KeyNotFoundException("Usuário não encontrado");
        }

        private async Task ValidarDependenciaDePedidoExistente(int idPedido)
        {
            if (await _itemPedidoRepository.SelecionarPorPedido(idPedido) == null)
                throw new KeyNotFoundException("Pedido contem dependencia");
        }
    }
}