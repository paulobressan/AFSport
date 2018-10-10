using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class ProdutoService : IProdutoService
    {
        #region Obejtos
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaRepository _categoriaRepository;
        #endregion

        public ProdutoService(
            IProdutoRepository produtoRepository,
            ICategoriaRepository categoriaRepository)
        {
            this._produtoRepository = produtoRepository;
            this._categoriaRepository = categoriaRepository;
        }

        #region Selecionar
        public async Task<Produto> SelecionarId(int id)
        {
            try
            {
                return await _produtoRepository.SelecionarId(id) ??
                    throw new KeyNotFoundException("Produto não encontrado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Produto>> SelecionarPorNomeId(string valor)
        {
            try
            {
                return (await _produtoRepository.SelecionarPorNomeId(valor))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Produto>> SelecionarProdutosComEstoque()
        {
            try
            {
                return (await _produtoRepository.SelecionarProdutosComEstoque())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Produto>> SelecionarProdutosPorCategoria(int idCategoria)
        {
            try
            {
                return (await _produtoRepository.SelecionarProdutosPorCategoria(idCategoria))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Produto>> SelecionarProdutosSemEstoque()
        {
            try
            {
                return (await _produtoRepository.SelecionarProdutosSemEstoque())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Produto>> SelecionarTodos()
        {
            try
            {
                return (await _produtoRepository.SelecionarTodos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Produto>> SelecionarTodosAtivos()
        {
            try
            {
                return (await _produtoRepository.SelecionarTodosAtivos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Produto>> SelecionarTodosInativos()
        {
            try
            {
                return (await _produtoRepository.SelecionarTodosInativos())
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
                return (await _produtoRepository.TotalRegistros());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Editar
        public async Task<Produto> Alterar(int idProduto, Produto produto)
        {
            try
            {
                await ValidarProdutoExistente(idProduto);
                await ValidarCategoriaExistente(produto.IdCategoria);
                return await _produtoRepository.Alterar(produto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AtivarInativar(int idProduto, bool isAtivo)
        {
            try
            {
                await ValidarProdutoExistente(idProduto);
                await _produtoRepository.AtivarInativar(idProduto, isAtivo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Novo
        public async Task<Produto> Inserir(Produto produto)
        {
            try
            {
                await ValidarCategoriaExistente(produto.IdCategoria);
                return await _produtoRepository.Inserir(produto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Remover
        public async Task Remover(int idProduto)
        {
            try
            {
                await ValidarProdutoExistente(idProduto);
                await _produtoRepository.Remover(idProduto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private async Task ValidarProdutoExistente(int idProduto)
        {
            if (await _produtoRepository.SelecionarId(idProduto) == null)
                throw new KeyNotFoundException("Produto não encontrado");
        }

        private async Task ValidarCategoriaExistente(int idCategoria)
        {
            if (await _categoriaRepository.SelecionarId(idCategoria) == null)
                throw new KeyNotFoundException("Categoria não encontrada");
        }
    }
}