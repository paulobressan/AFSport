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
        private readonly IMovimentacaoRepository _movimentacaoRepository;
        #endregion

        #region Construtor
        public OperacaoService(
            IOperacaoRepository operacaoRepository,
            IMovimentacaoRepository movimentacaoRepository)
        {
            this._operacaoRepository = operacaoRepository;
            this._movimentacaoRepository = movimentacaoRepository;
        }
        #endregion

        public async Task<Operacao> Alterar(int idOperacao, Operacao operacao)
        {
            try
            {
                await ValidarOperacaoExistente(idOperacao);
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
                await ValidarOperacaoExistente(idOperacao);
                await _operacaoRepository.Remover(idOperacao);
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

        private async Task ValidarOperacaoExistente(int IdOperacao)
        {
            if (await _operacaoRepository.SelecionarId(IdOperacao) == null)
                throw new KeyNotFoundException("Operação não encontrada");
        }

        private async Task ValidarDependenciaDeOperacaoExistente(int IdOperacao)
        {
            if (await _movimentacaoRepository(IdOperacao) == null)
                throw new KeyNotFoundException("Operação não encontrada");
        }
    }
}