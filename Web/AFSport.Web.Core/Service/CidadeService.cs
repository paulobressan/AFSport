using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class CidadeService : ICidadeService
    {
        #region Objetos
        private readonly ICidadeRepository _cidadeRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IEstadoService _estadoService;
        #endregion

        #region Construtor
        public CidadeService(ICidadeRepository cidadeRepository, IClienteRepository clienteRepository, IEstadoService estadoService)
        {
            this._cidadeRepository = cidadeRepository;
            this._clienteRepository = clienteRepository;
            this._estadoService = estadoService;
        }
        #endregion
        public async Task<Cidade> Alterar(int idCidade, Cidade cidade)
        {
            try
            {
                await ValidarCidadeExistente(idCidade);
                await _estadoService.ValidarEstadoExistente(cidade.IdEstado);
                return await _cidadeRepository.Alterar(cidade);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Cidade> Inserir(Cidade cidade)
        {
            try
            {
                await _estadoService.ValidarEstadoExistente(cidade.IdEstado);
                return await _cidadeRepository.Inserir(cidade);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Remover(int idCidade)
        {
            try
            {
                await ValidarCidadeExistente(idCidade);
                await ValidarDependenciasDeCidade(idCidade);
                await _cidadeRepository.Remover(idCidade);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Cidade> SelecionarId(int id)
        {
            try
            {
                return await _cidadeRepository.SelecionarId(id) ??
                    throw new KeyNotFoundException("Cidade não encontrada");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Cidade>> SelecionarTodos()
        {
            try
            {
                return (await _cidadeRepository.SelecionarTodos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Cidade>> SelecionarTodosAtivos()
        {
            try
            {
                return (await _cidadeRepository.SelecionarTodos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Cidade>> SelecionarTodosInativos()
        {
            try
            {
                return (await _cidadeRepository.SelecionarTodos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AtivarInativar(int idCidade, bool isAtivo)
        {
            try
            {
                await ValidarCidadeExistente(idCidade);
                await _cidadeRepository.AtivarInativar(idCidade, isAtivo);
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
                return await _cidadeRepository.TotalRegistros();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task ValidarCidadeExistente(int idCidade)
        {
            if (await _cidadeRepository.SelecionarId(idCidade) == null)
                throw new KeyNotFoundException("Cidade não encontrada");
        }

        public async Task ValidarDependenciasDeCidade(int idCidade)
        {
            if ((await _clienteRepository.SelecionarPorCidade(idCidade)).Any())
                throw new ArgumentException("Cidade não pode ser removida por conter dependencias");
        }
    }
}