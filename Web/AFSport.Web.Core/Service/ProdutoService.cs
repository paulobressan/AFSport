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
        public Task<Produto> Alterar(Produto obj)
        {
            throw new System.NotImplementedException();
        }

        public Task<Produto> Inserir(Produto obj)
        {
            throw new System.NotImplementedException();
        }

        public Task Remover(Produto obj)
        {
            throw new System.NotImplementedException();
        }

        public Task<Produto> SelecionarId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Produto>> SelecionarPorNomeId(string valor)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Produto>> SelecionarProdutosComEstoque()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Produto>> SelecionarProdutosPorCategoria(int idCategoria)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Produto>> SelecionarProdutosSemEstoque()
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Produto>> SelecionarTodos()
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

        public Task<List<Produto>> SelecionarTodosAtivos()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Produto>> SelecionarTodosInativos()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> TotalRegistros()
        {
            throw new System.NotImplementedException();
        }
    }
}