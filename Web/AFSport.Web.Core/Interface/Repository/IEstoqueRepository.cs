using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IEstoqueRepository
    {
        /// <summary>
        /// Selecionar todos estoques
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Estoque>> SelecionarTodos();
        /// <summary>
        /// Selecionar estoque por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Estoque> SelecionarId(int id);
        /// <summary>
        /// Inserir novo estoque
        /// </summary>
        /// <param name="estoque"></param>
        /// <returns></returns>
        Task<Estoque> Inserir(Estoque estoque);
        /// <summary>
        /// Alterar estoque
        /// </summary>
        /// <param name="estoque"></param>
        /// <returns></returns>
        Task<Estoque> Alterar(Estoque estoque);
        /// <summary>
        /// Remover estoque
        /// </summary>
        /// <param name="estoque"></param>
        /// <returns></returns>
        Task Remover(Estoque estoque);
        Task<Estoque> SelecionarEstoquePorProduto(int idProduto);
    }
}
