using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> SelecionarTodos(bool selecionarTodos);
        Task<Usuario> SelecionarId(int id);
        Task<Usuario> Salvar(Usuario obj);
        Task Remover(Usuario obj);
        Task<Usuario> AutenticarUsuario(string login, string senha);
    }
}
