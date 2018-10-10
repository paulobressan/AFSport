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
        #endregion
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<Cliente> Alterar(int id, Cliente cliente)
        {
            try
            {
                await ValidarClienteExistente(id);
                return await _clienteRepository.Alterar(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Cliente> Inserir(Cliente Cliente)
        {
            try
            {
                return await _clienteRepository.Inserir(Cliente);
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

        public async Task ValidarClienteExistente(int idCliente)
        {
            if (await _clienteRepository.SelecionarId(idCliente) == null)
                throw new KeyNotFoundException("Cliente não encontrada");
        }
    }
}