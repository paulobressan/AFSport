using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Service
{
    public interface IClienteService
    {
        /// <summary>
        /// Selecionar todos clientes
        /// </summary>
        /// <returns></returns>
        Task<IList<Cliente>> SelecionarTodos();
        /// <summary>
        /// Selecionar cliente por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Cliente> SelecionarId(int id);
        /// <summary>
        /// Inserir novo cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        Task<Cliente> Inserir(Cliente cliente);
        /// <summary>
        /// Alterar cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        Task<Cliente> Alterar(int idCliente, Cliente cliente);
        /// <summary>
        /// Selecionar cliente por cidade
        /// </summary>
        /// <param name="idCidade"></param>
        /// <returns></returns>
        Task<IList<Cliente>> SelecionarPorCidade(int idCidade);
        /// <summary>
        /// Pesquisar cliente por nome ou id
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        Task<IList<Cliente>> SelecionarPesquisaNomeId(string valor);
        /// <summary>
        /// Total de clientes cadastrado na base
        /// </summary>
        /// <returns></returns>
        Task<int> TotalRegistros();
    }
}
