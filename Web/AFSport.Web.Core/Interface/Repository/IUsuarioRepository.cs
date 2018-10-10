using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Selecionar todos usuários
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Usuario>> SelecionarTodos();
        /// <summary>
        /// Selecionar todos usuários ativos
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Usuario>> SelecionarTodosAtivos();
        /// <summary>
        /// Selecionar todos usuários inativos
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Usuario>> SelecionarTodosInativos();
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
        /// <summary>
        /// Ativar ou inativar usuário
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="isAtivo"></param>
        /// <returns></returns>
        Task AtivarInativar(int idUsuario, bool isAtivo);
        /// <summary>
        /// Verificar auticidade do usuário
        /// </summary>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        Task<Usuario> AutenticarUsuario(string login, string senha);
    }
}
