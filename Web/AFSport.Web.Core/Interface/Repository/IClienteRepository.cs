using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IClienteRepository
    {
        /// <summary>
        /// Selecionar todos clientes
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Cliente>> SelecionarTodos();
        /// <summary>
        /// Selecionar cliente por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Cliente> SelecionarId(int id);
        /// <summary>
        /// Inserir cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        Task<Cliente> Inserir(Cliente cliente);
        /// <summary>
        /// Alterar cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        Task<Cliente> Alterar(Cliente cliente);
        /// <summary>
        /// Selecionar cliente por cidade
        /// </summary>
        /// <param name="idCidade"></param>
        /// <returns></returns>
        Task<IEnumerable<Cliente>> SelecionarPorCidade(int idCidade);
        /// <summary>
        /// Selecionar cliente por nome ou id
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        Task<IEnumerable<Cliente>> SelecionarPesquisaNomeId(string valor);
        /// <summary>
        /// Selecionar total de registro
        /// </summary>
        /// <returns></returns>
        Task<int> TotalRegistros();
        /// <summary>
        /// Ativar ou inativar categoria
        /// </summary>
        /// <param name="idCliente"></param>
        /// <param name="isAtivo"></param>
        /// <returns></returns>
        Task AtivarInativar(int idCliente, bool isAtivo);
        /// <summary>
        /// Selecionar todos clientes ativos
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Cliente>> SelecionarTodosAtivos();
        /// <summary>
        /// Selecionar todos clientes inativos
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Cliente>> SelecionarTodosInativos();
    }
}
