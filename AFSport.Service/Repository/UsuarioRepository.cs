using AFSport.Service.Base;
using AFSport.Service.Interfaces;
using AFSport.Service.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Repository
{
    public class UsuarioRepository : BaseRepository, ICRUD<Usuario>
    {
        public void Remover(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> Salvar(Usuario obj)
        {
            if(obj.IdUsuario == 0)
            {
                var result = await _context.QueryAsync<Usuario>(@"insert into usuario(nome, email, login, senha, isAtivo) values (@nome, @email, @login, @senha, @isAtivo);
                    select idUsuario, nome, email, login, senha from usuario 
                    where idUsuario = (select last_insert_id() as id);", obj);
                return result.Single();
            }
            else
            {
                var result = await _context.QueryAsync<Usuario>(@"update usuario set nome = @nome, email = @email, login = @login, senha = @senha where idUsuario = @idUsuario;
                    select idUsuario, nome, email, login, senha from usuario 
                    where idUsuario = @idUsuario;", obj);
                return result.Single();
            }
        }

        public async Task<Usuario> SelecionarId(int id)
        {
            var result = await _context.QueryAsync<Usuario>(@"select idUsuario, nome, email, login, senha from usuario where idUsuario = @idUsuario;", new { idUsuario = id });
            return result.SingleOrDefault();
        }

        public async Task<List<Usuario>> SelecionarTodos(bool selecionarTodos)
        {
            var result = selecionarTodos
                ? await _context.QueryAsync<Usuario>(@"select idUsuario, nome, email, login, senha from usuario;", null)
                : await _context.QueryAsync<Usuario>(@"select idUsuario, nome, email, login, senha from usuario where isAtivo = true;", null);
            return result.ToList();
        }

        public async Task<Usuario> AutenticarUsuario(string login, string senha)
        {
            var result = await _context.QueryAsync<Usuario>(@"select idUsuario, nome, email, login, senha from usuario 
                where login = @login and senha = @senha;", new { login, senha });
            return result.SingleOrDefault();
        }
    }
}
