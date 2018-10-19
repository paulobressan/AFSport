using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class EstoqueService : IEstoqueService
    {
        #region Objetos
        private readonly IEstoqueRepository _estoqueRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        #endregion

        #region Construtor
        public EstoqueService(
            IEstoqueRepository estoqueRepository,
            IProdutoRepository produtoRepository,
            IUsuarioRepository usuarioRepository)
        {
            this._estoqueRepository = estoqueRepository;
            this._produtoRepository = produtoRepository;
            this._usuarioRepository = usuarioRepository;
        }
        #endregion

        public async Task<Estoque> Alterar(int idEstoque, Estoque estoque)
        {
            try
            {
                await SelecionarId(idEstoque);
                await ValidarProdutoExistente(estoque.IdProduto);
                await ValidarUsuarioExistente(estoque.IdUsuario);
                return await _estoqueRepository.Alterar(estoque);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Estoque> Inserir(Estoque estoque)
        {
            try
            {
                await ValidarProdutoExistente(estoque.IdProduto);
                await ValidarUsuarioExistente(estoque.IdUsuario);
                return await _estoqueRepository.Inserir(estoque);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<Estoque> InserirPorProduto(int idProduto)
        {
            throw new NotImplementedException();
        }

        public async Task Remover(int idEstoque)
        {
            try
            {
                var estoque = await SelecionarId(idEstoque);
                await _estoqueRepository.Remover(estoque);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Estoque> SelecionarEstoquePorProduto(int idProduto)
        {
            try
            {
                await ValidarProdutoExistente(idProduto);
                return await _estoqueRepository.SelecionarEstoquePorProduto(idProduto) ??
                    throw new KeyNotFoundException("Produto não contem estoque");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Estoque> SelecionarId(int id)
        {
            try
            {
                return await _estoqueRepository.SelecionarId(id) ??
                    throw new KeyNotFoundException("Estoque não encontrado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Estoque>> SelecionarTodos()
        {
            try
            {
                return (await _estoqueRepository.SelecionarTodos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private async Task ValidarEstoqueExistente(int idEstoque)
        {
            if (await _estoqueRepository.SelecionarId(idEstoque) == null)
                throw new KeyNotFoundException("Estoque não encontrado");
        }

        private async Task ValidarProdutoExistente(int idProduto)
        {
            if (await _produtoRepository.SelecionarId(idProduto) == null)
                throw new KeyNotFoundException("Produto não encontrado");
        }

        private async Task ValidarUsuarioExistente(int idUsuario)
        {
            if (await _usuarioRepository.SelecionarId(idUsuario) == null)
                throw new KeyNotFoundException("Usuário não encontrado");
        }
    }
}