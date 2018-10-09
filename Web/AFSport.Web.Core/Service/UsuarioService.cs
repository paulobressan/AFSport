using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class UsuarioService : IUsuarioService
    {
        public Task<Usuario> Alterar(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public Task<Usuario> Inserir(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public Task<Usuario> SelecionarId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Usuario>> SelecionarTodos()
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Usuario>> SelecionarTodosAtivos()
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Usuario>> SelecionarTodosInativos()
        {
            throw new System.NotImplementedException();
        }
    }
}