using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class CaixaService : ICaixaService
    {
        #region Objetos
        private readonly ICaixaRepository _caixaRepository;
        #endregion
        public CaixaService(ICaixaRepository caixaRepository)
        {
            _caixaRepository = caixaRepository;
        }

        public async Task<Caixa> Alterar(int idCaixa, Caixa caixa)
        {
            try
            {
                await ValidarCaixaExistente(idCaixa);
                return await _caixaRepository.Alterar(caixa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Caixa> Inserir(Caixa caixa)
        {
            try
            {
                await ValidarCaixaDiarioExistente();
                caixa.Data = DateTime.Now;
                return await _caixaRepository.Inserir(caixa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Caixa> SelecionarId(int idCaixa)
        {
            try
            {
                return await _caixaRepository.SelecionarId(idCaixa) ??
                    throw new KeyNotFoundException("Caixa não encontrada");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Caixa> SelecionarPorData(DateTime data)
        {
            try
            {
                return await _caixaRepository.SelecionarPorData(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Caixa> SelecionarPorDataAtual()
        {
            try
            {
                return await _caixaRepository.SelecionarPorDataAtual();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Caixa>> SelecionarTodos()
        {
            try
            {
                return (await _caixaRepository.SelecionarTodos())
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
                return await _caixaRepository.TotalRegistros();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task ValidarCaixaExistente(int idCaixa)
        {
            if (await _caixaRepository.SelecionarId(idCaixa) == null)
                throw new KeyNotFoundException("Caixa não encontrada");
        }

        public async Task ValidarCaixaDiarioExistente()
        {
            if (await _caixaRepository.SelecionarPorDataAtual() != null)
                throw new KeyNotFoundException("Caixa diário já foi criado.");
        }
    }
}