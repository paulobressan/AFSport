using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class PrecoService : IPrecoService
    {
        public Task Remover(int idPreco)
        {
            throw new System.NotImplementedException();
        }

        public Task<Preco> Salvar(Preco preco)
        {
            throw new System.NotImplementedException();
        }

        public Task<Preco> SelecionarId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Preco>> SelecionarTodos(bool selecionarTodos)
        {
            throw new System.NotImplementedException();
        }
    }
}