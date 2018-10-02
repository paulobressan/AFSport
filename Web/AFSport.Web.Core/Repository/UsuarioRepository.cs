using AFSport.Web.Core.Base;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Model;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Repository
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {
        public UsuarioRepository(IConfiguration configuration)
            : base(configuration) { }

        public async Task<Usuario> Inserir(Usuario usuario)
        {
            return (await _context.QueryAsync<Usuario>(@"insert into usuario(nome, email, login, senha, isAtivo) values (@nome, @email, @login, @senha, @isAtivo);
                select idUsuario, nome, email, login, senha from usuario 
                where idUsuario = (select last_insert_id() as id);", usuario))
                .Single();
        }

        public async Task<Usuario> Alterar(Usuario usuario)
        {
            return (await _context.QueryAsync<Usuario>(@"update usuario set nome = @nome, email = @email, login = @login, senha = @senha where idUsuario = @idUsuario;
                select idUsuario, nome, email, login, senha from usuario 
                where idUsuario = @idUsuario;", usuario))
                .Single();
        }

        public async Task<Usuario> SelecionarId(int id)
        {
            return (await _context.QueryAsync<Usuario>(@"select idUsuario, nome, email, login, senha 
                from usuario where idUsuario = @idUsuario;", new { idUsuario = id }))
                .SingleOrDefault();
        }

        public async Task<IEnumerable<Usuario>> SelecionarTodos()
        {
            return await _context.QueryAsync<Usuario>(@"select idUsuario, nome, email, login, senha from usuario;", null);
        }

        public async Task<IEnumerable<Usuario>> SelecionarTodosAtivos()
        {
            return await _context.QueryAsync<Usuario>(@"select idUsuario, nome, email, login, senha 
                from usuario where isAtivo = true;", null);
        }

        public async Task<IEnumerable<Usuario>> SelecionarTodosInativos()
        {
            return await _context.QueryAsync<Usuario>(@"select idUsuario, nome, email, login, senha 
                from usuario where isAtivo = false;", null);
        }

        public async Task<Usuario> AutenticarUsuario(string login, string senha)
        {
            return (await _context.QueryAsync<Usuario>(@"select idUsuario, nome, email, login, senha from usuario 
                where login = @login and senha = @senha;", new { login, senha }))
                .SingleOrDefault();
        }
    }
}
