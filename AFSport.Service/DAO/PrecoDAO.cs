using AFSport.DAO.Model;
using AFSport.Service.Base;
using AFSport.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.DAO
{
    public class PrecoDAO : BaseDAO, ICRUD<Preco>
    {
        public async Task<Preco> Remover(Preco obj)
        {
            _context.Preco.Attach(obj);
            _context.Entry(obj).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return obj;
        }

        public async Task<Preco> Salvar(Preco obj)
        {
            if(obj.Id == 0)
            {
                _context.Preco.Attach(obj);
                _context.Entry(obj).State = EntityState.Added;
                await _context.SaveChangesAsync();
                return obj;
            }
            else
            {
                _context.Preco.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return obj;
            }
        }

        public async Task<Preco> SelecionarId(int id)
        {
            return await _context.Preco
                .Include(p => p.Produto)
                .Where(p => p.Id == id)
                .SingleOrDefaultAsync();
        }

        public async Task<List<Preco>> SelecionarTodos(bool selecionarTodos)
        {
            return await _context.Preco
                .Include(p => p.Produto)
                .ToListAsync();
        }

        public async Task<List<Preco>> SelecionarPrecoProduto(int id)
        {
            return await _context.Preco
                .Include(p=>p.Produto)
                .Where(p => p.Produto.Id == id)
                .ToListAsync();
        }
    }
}
