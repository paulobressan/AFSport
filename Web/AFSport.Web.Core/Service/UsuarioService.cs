using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class UsuarioService : IUsuarioService
    {
        #region Objetos
        private readonly IUsuarioRepository _usuarioRepository;
        #endregion

        #region Construtor
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            this._usuarioRepository = usuarioRepository;
        }
        #endregion

        public async Task<Usuario> Alterar(int idUsuario, Usuario usuario)
        {
            try
            {
                await SelecionarId(idUsuario);
                return await _usuarioRepository.Alterar(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Usuario> Inserir(Usuario usuario)
        {
            try
            {
                return await _usuarioRepository.Inserir(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Usuario> SelecionarId(int id)
        {
            try
            {
                return await _usuarioRepository.SelecionarId(id) ??
                    throw new KeyNotFoundException("Usuario não encontrada");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Usuario>> SelecionarTodos()
        {
            try
            {
                return (await _usuarioRepository.SelecionarTodos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Usuario>> SelecionarTodosAtivos()
        {
            try
            {
                return (await _usuarioRepository.SelecionarTodos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Usuario>> SelecionarTodosInativos()
        {
            try
            {
                return (await _usuarioRepository.SelecionarTodos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AtivarInativar(int idUsuario, bool isAtivo)
        {
            try
            {
                var Usuario = await SelecionarId(idUsuario);
                await _usuarioRepository.AtivarInativar(idUsuario, isAtivo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}