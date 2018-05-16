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
    public class ClienteRepository : BaseDAO, ICRUD<Cliente>
    {
        public async Task<Cliente> Remover(Cliente obj)
        {
            _context.Cliente.Attach(obj);
            _context.Entry(obj).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return obj;
        }

        public async Task<Cliente> Salvar(Cliente obj)
        {
            if(obj.Id == 0)
            {
                _context.Cliente.Attach(obj);
                _context.Entry(obj).State = EntityState.Added;
                await _context.SaveChangesAsync();
                return obj;
            }
            else
            {
                _context.Cliente.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return obj;
            }
        }

        public async Task<Cliente> SelecionarId(int id)
        {
            return await _context.Cliente
                .Include(c => c.Cidade)
                .Where(c => c.Id == id)
                .SingleOrDefaultAsync();
        }

        public async Task<List<Cliente>> SelecionarTodos(bool selecionarTodos)
        {
            return await _context.Cliente
                .Include(c=>c.Cidade)
                .ToListAsync();
        }
    }
}
