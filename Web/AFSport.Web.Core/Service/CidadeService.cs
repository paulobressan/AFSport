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
        #endregion

        #region Construtor
        public CidadeService(ICidadeRepository cidadeRepository)
        {
            this._cidadeRepository = cidadeRepository;
        }
        #endregion
        public async Task<Cidade> Alterar(int idCidade, Cidade cidade)
        {
            try
            {
                await SelecionarId(idCidade);
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
                var cidade = await SelecionarId(idCidade);
                //DEPENDENCIA CLIENTES
                await _cidadeRepository.Remover(cidade);
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
                var cidade = await SelecionarId(idCidade);
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
    }
}