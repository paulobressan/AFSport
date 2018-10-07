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
        #endregion

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
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
        public async Task<Produto> Alterar(int id, Produto obj)
        {
            try
            {
                await SelecionarId(id);
                return await _produtoRepository.Alterar(obj);
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
                var categoria = await SelecionarId(idProduto);
                await _produtoRepository.AtivarInativar(idProduto, isAtivo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Novo
        public async Task<Produto> Inserir(Produto obj)
        {
            try
            {
                return await _produtoRepository.Inserir(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Remover
        public async Task Remover(int id)
        {
            try
            {
                var produto = await SelecionarId(id);
                await _produtoRepository.Remover(produto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}