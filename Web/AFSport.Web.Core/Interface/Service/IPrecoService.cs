using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Service
{
    public interface IPrecoService
    {
        /// <summary>
        /// Selecionar todos preços
        /// </summary>
        /// <param name="selecionarTodos"></param>
        /// <returns></returns>
        Task<IList<Preco>> SelecionarTodos(bool selecionarTodos);
        /// <summary>
        /// Selecionar preço por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Preco> SelecionarId(int id);
        /// <summary>
        /// Salvar preço
        /// </summary>
        /// <param name="preco"></param>
        /// <returns></returns>
        Task<Preco> Salvar(Preco preco);
        /// <summary>
        /// Remover preço
        /// </summary>
        /// <param name="idPreco"></param>
        /// <returns></returns>
        Task Remover(int idPreco);
    }
}
