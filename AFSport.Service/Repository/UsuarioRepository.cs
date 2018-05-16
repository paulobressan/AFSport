using AFSport.DAO.Model;
using AFSport.Service.Base;
using AFSport.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Repository
{
    public class UsuarioRepository : BaseDAO, ICRUD<Usuario>
    {
        public async Task<Usuario> Remover(Usuario obj)
        {
            _context.Usuario.Attach(obj);
            _context.Entry(obj).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return obj;
        }

        public async Task<Usuario> Salvar(Usuario obj)
        {
            if(obj.Id == 0)
            {
                _context.Usuario.Attach(obj);
                _context.Entry(obj).State = EntityState.Added;
                await _context.SaveChangesAsync();
                return obj;
            }
            else
            {
                _context.Usuario.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return obj;
            }
        }

        public async Task<Usuario> SelecionarId(int id)
        {
            return await _context.Usuario
                .Where(u => u.Id == id)
                .SingleOrDefaultAsync();
        }

        public async Task<List<Usuario>> SelecionarTodos(bool selecionarTodos)
        {
            return await _context.Usuario
                .ToListAsync();
        }
    }
}
