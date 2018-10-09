using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> SelecionarTodos();
        Task<Cliente> SelecionarId(int id);
        Task<Cliente> Inserir(Cliente cliente);
        Task<Cliente> Alterar(Cliente cliente);
        Task Remover(Cliente cliente);
        Task<IEnumerable<Cliente>> SelecionarPorCidade(int idCidade);
        Task<IEnumerable<Cliente>> SelecionarPesquisaNomeId(string valor);
        Task<int> TotalRegistros();
    }
}
