using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> SelecionarTodos(bool selecionarTodos);
        Task<Cliente> SelecionarId(int id);
        Task<Cliente> Salvar(Cliente obj);
        Task Remover(Cliente obj);
        Task<List<Cliente>> SelecionarPorCidade(int idCidade);
        Task<List<Cliente>> SelecionarPesquisaNomeId(string valor);
        Task<int> TotalRegistros();
    }
}
