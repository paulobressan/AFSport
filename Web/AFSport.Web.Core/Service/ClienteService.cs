using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class ClienteService : IClienteService
    {
        #region Objetos
        private readonly IClienteRepository _clienteRepository;
        private readonly ICidadeRepository _cidadeRepository;
        #endregion
        public ClienteService(IClienteRepository clienteRepository, ICidadeRepository cidadeRepository)
        {
            _clienteRepository = clienteRepository;
            _cidadeRepository = cidadeRepository;
        }

        public async Task<Cliente> Alterar(int id, Cliente cliente)
        {
            try
            {
                await ValidarClienteExistente(id);
                await ValidarCidadeExistente(cliente.IdCidade);
                return await _clienteRepository.Alterar(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Cliente> Inserir(Cliente cliente)
        {
            try
            {
                await ValidarCidadeExistente(cliente.IdCidade);
                return await _clienteRepository.Inserir(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Cliente> SelecionarId(int id)
        {
            try
            {
                return await _clienteRepository.SelecionarId(id) ??
                    throw new KeyNotFoundException("Cliente não encontrada");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Cliente>> SelecionarPesquisaNomeId(string valor)
        {
            try
            {
                return (await _clienteRepository.SelecionarPesquisaNomeId(valor))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Cliente>> SelecionarPorCidade(int idCidade)
        {
            try
            {
                return (await _clienteRepository.SelecionarPorCidade(idCidade))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Cliente>> SelecionarTodos()
        {
            try
            {
                return (await _clienteRepository.SelecionarTodos())
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
                return await _clienteRepository.TotalRegistros();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AtivarInativar(int idCliente, bool isAtivo)
        {
            try
            {
                await ValidarClienteExistente(idCliente);
                await _clienteRepository.AtivarInativar(idCliente, isAtivo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Cliente>> SelecionarTodosAtivos()
        {
            try
            {
                return (await _clienteRepository.SelecionarTodosAtivos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Cliente>> SelecionarTodosInativos()
        {
            try
            {
                return (await _clienteRepository.SelecionarTodosInativos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task ValidarClienteExistente(int idCliente)
        {
            if (await _clienteRepository.SelecionarId(idCliente) == null)
                throw new KeyNotFoundException("Cliente não encontrada");
        }

        private async Task ValidarCidadeExistente(int idCidade)
        {
            if (await _cidadeRepository.SelecionarId(idCidade) == null)
                throw new KeyNotFoundException("Cidade não encontrada");
        }
    }
}