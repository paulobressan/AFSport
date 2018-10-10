using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class MovimentacaoService : IMovimentacaoService
    {
        #region Objetos
        private readonly IMovimentacaoRepository _movimentacaoRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IOperacaoRepository _operacaoRepository;
        #endregion

        #region Construtor
        public MovimentacaoService(
            IMovimentacaoRepository movimentacaoRepository,
            IUsuarioRepository usuarioRepository,
            IOperacaoRepository operacaoRepository)
        {
            this._movimentacaoRepository = movimentacaoRepository;
            this._usuarioRepository = usuarioRepository;
            this._operacaoRepository = operacaoRepository;
        }
        #endregion

        public async Task<Movimentacao> Alterar(int idMovimentacao, Movimentacao movimentacao)
        {
            try
            {
                await ValidarMovimentacaoExistente(idMovimentacao);
                await ValidarOperacaoExistente(movimentacao.IdOperacao);
                await ValidarUsuarioExistente(movimentacao.IdUsuario);
                return await _movimentacaoRepository.Alterar(movimentacao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Movimentacao> Inserir(Movimentacao movimentacao)
        {
            try
            {
                await ValidarOperacaoExistente(movimentacao.IdOperacao);
                await ValidarUsuarioExistente(movimentacao.IdUsuario);
                return await _movimentacaoRepository.Inserir(movimentacao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Movimentacao> SelecionarId(int idMovimentacao)
        {
            try
            {
                return await _movimentacaoRepository.SelecionarId(idMovimentacao) ??
                    throw new KeyNotFoundException("Movimentacao não encontrada");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Movimentacao>> SelecionarMovimentacaoPorDia(DateTime data)
        {
            try
            {
                return (await _movimentacaoRepository.SelecionarMovimentacaoPorDia(data))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Movimentacao>> SelecionarTodos()
        {
            try
            {
                return (await _movimentacaoRepository.SelecionarTodos())
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
                return await _movimentacaoRepository.TotalRegistros();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task ValidarMovimentacaoExistente(int idMovimentacao)
        {
            if (await _movimentacaoRepository.SelecionarId(idMovimentacao) == null)
                throw new KeyNotFoundException("Movimentação não encontrado");
        }

        private async Task ValidarUsuarioExistente(int idUsuario)
        {
            if (await _usuarioRepository.SelecionarId(idUsuario) == null)
                throw new KeyNotFoundException("Usuário não encontrado");
        }

        private async Task ValidarOperacaoExistente(int IdOperacao)
        {
            if (await _operacaoRepository.SelecionarId(IdOperacao) == null)
                throw new KeyNotFoundException("Operação não encontrada");
        }
    }
}