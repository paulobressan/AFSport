using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class EstadoService : IEstadoService
    {
        #region Objetos
        private readonly IEstadoRepository _estadoRepository;
        private readonly ICidadeRepository _cidadeRepository;
        #endregion

        #region Construtor
        public EstadoService(IEstadoRepository estadoRepository, ICidadeRepository cidadeRepository)
        {
            this._estadoRepository = estadoRepository;
            this._cidadeRepository = cidadeRepository;
        }
        #endregion

        public async Task<Estado> Alterar(int idEstado, Estado estado)
        {
            try
            {
                await ValidarEstadoExistente(idEstado);
                return await _estadoRepository.Alterar(estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Estado> Inserir(Estado estado)
        {
            try
            {
                return await _estadoRepository.Inserir(estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Remover(int idEstado)
        {
            try
            {
                await ValidarEstadoExistente(idEstado);
                await ValidarDependenciasDeEstado(idEstado);
                await _estadoRepository.Remover(idEstado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Estado> SelecionarId(int id)
        {
            try
            {
                return await _estadoRepository.SelecionarId(id) ??
                    throw new KeyNotFoundException("Estado não encontrado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Estado>> SelecionarTodos()
        {
            try
            {
                return (await _estadoRepository.SelecionarTodos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Estado>> SelecionarTodosAtivos()
        {
            try
            {
                return (await _estadoRepository.SelecionarTodosAtivos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Estado>> SelecionarTodosInativos()
        {
            try
            {
                return (await _estadoRepository.SelecionarTodosInativos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AtivarInativar(int idEstado, bool isAtivo)
        {
            try
            {
                await ValidarEstadoExistente(idEstado);
                await _estadoRepository.AtivarInativar(idEstado, isAtivo);
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
                return await _estadoRepository.TotalRegistros();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task ValidarEstadoExistente(int idEstado)
        {
            if (await _estadoRepository.SelecionarId(idEstado) == null)
                throw new KeyNotFoundException("Estado não encontrada");
        }

        private async Task ValidarDependenciasDeEstado(int idEstado)
        {
            if ((await _cidadeRepository.SelecionarPorEstado(idEstado)).Any())
                throw new ArgumentException("Estado não pode ser removido por conter dependencias");
        }
    }
}