using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Service
{
    public interface IUsuarioService
    {
        /// <summary>
        /// Selecionar todos usuários
        /// </summary>
        /// <returns></returns>
        Task<IList<Usuario>> SelecionarTodos();
        /// <summary>
        /// Selecionar todos usuários ativos
        /// </summary>
        /// <returns></returns>
        Task<IList<Usuario>> SelecionarTodosAtivos();
        /// <summary>
        /// Selecionar todos usuários inativos
        /// </summary>
        /// <returns></returns>
        Task<IList<Usuario>> SelecionarTodosInativos();
        /// <summary>
        /// Selecionar usuário por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Usuario> SelecionarId(int id);
        /// <summary>
        /// Inserir novo usuário
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        Task<Usuario> Inserir(Usuario usuario);
        /// <summary>
        /// Alterar usuário
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        Task<Usuario> Alterar(Usuario usuario);
    }
}
