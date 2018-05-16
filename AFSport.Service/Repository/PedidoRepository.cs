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
    public class PedidoRepository : BaseDAO, ICRUD<Pedido>
    {
        public async Task<Pedido> Remover(Pedido obj)
        {
            _context.Pedido.Attach(obj);
            _context.Entry(obj).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return obj;
        }

        public async Task<Pedido> Salvar(Pedido obj)
        {
            if(obj.Id== 0)
            {
                _context.Pedido.Attach(obj);
                _context.Entry(obj).State = EntityState.Added;
                await _context.SaveChangesAsync();
                return obj;
            }
            else
            {
                _context.Pedido.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return obj;
            }
        }

        public async Task<Pedido> SelecionarId(int id)
        {
            return await _context.Pedido
                .Include(p => p.Cliente)
                .Include(p => p.Usuario)
                .Where(p=>p.Id == id)
                .SingleOrDefaultAsync();
        }

        public async Task<List<Pedido>> SelecionarTodos(bool selecionarTodos)
        {
            return await _context.Pedido
                .Include(p=>p.Cliente)
                .Include(p => p.Usuario)
                .ToListAsync();
        }

        public async Task<List<Pedido>> SelecionarTodosPorCliente(int id)
        {
            return await _context.Pedido
                .Include(p => p.Cliente)
                .Include(p => p.Usuario)
                .Where(p=>p.Cliente.Id== id)
                .ToListAsync();
        }

        public async Task<List<Pedido>> SelecionarTodosPorUsuario(int id)
        {
            return await _context.Pedido
                .Include(p => p.Cliente)
                .Include(p => p.Usuario)
                .Where(p => p.Usuario.Id == id)
                .ToListAsync();
        }
    }
}
