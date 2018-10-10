using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class OperacaoService : IOperacaoService
    {
        #region Objetos
        private readonly IOperacaoRepository _operacaoRepository;
        #endregion

        #region Construtor
        public OperacaoService(IOperacaoRepository operacaoRepository)
        {
            this._operacaoRepository = operacaoRepository;
        }
        #endregion

        public async Task<Operacao> Alterar(int idOperacao, Operacao operacao)
        {
            try
            {
                await SelecionarId(idOperacao);
                return await _operacaoRepository.Alterar(operacao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Operacao> Inserir(Operacao operacao)
        {
            try
            {
                return await _operacaoRepository.Inserir(operacao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Remover(int idOperacao)
        {
            try
            {
                var operacao = await SelecionarId(idOperacao);
                await _operacaoRepository.Remover(operacao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Operacao> SelecionarId(int id)
        {
            try
            {
                return await _operacaoRepository.SelecionarId(id) ??
                    throw new KeyNotFoundException("Operação não encontrado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Operacao>> SelecionarTodos()
        {
            try
            {
                return (await _operacaoRepository.SelecionarTodos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Operacao>> SelecionarTodosAtivos()
        {
            try
            {
                return (await _operacaoRepository.SelecionarTodosAtivos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Operacao>> SelecionarTodosInativos()
        {
            try
            {
                return (await _operacaoRepository.SelecionarTodosInativos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AtivarInativar(int idOperacao, bool isAtivo)
        {
            try
            {
                var Operacao = await SelecionarId(idOperacao);
                await _operacaoRepository.AtivarInativar(Operacao.IdOperacao, isAtivo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}