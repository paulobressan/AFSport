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
        #endregion

        #region Construtor
        public EstoqueService(IEstoqueRepository estoqueRepository, IProdutoRepository produtoRepository)
        {
            this._estoqueRepository = estoqueRepository;
            this._produtoRepository = produtoRepository;
        }
        #endregion

        public async Task<Estoque> Alterar(int idEstoque, Estoque estoque)
        {
            try
            {
                await SelecionarId(idEstoque);
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
                return await _estoqueRepository.Inserir(estoque);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                var produto = await _produtoRepository.SelecionarId(idProduto) ??
                    throw new KeyNotFoundException("Produto não encontrado");

                return await _estoqueRepository.SelecionarEstoquePorProduto(produto.IdProduto) ??
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
    }
}