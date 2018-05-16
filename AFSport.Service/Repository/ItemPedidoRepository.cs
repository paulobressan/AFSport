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
    public class ItemPedidoRepository : BaseDAO, ICRUD<ItemPedido>
    {
        public async Task<ItemPedido> Remover(ItemPedido obj)
        {
            _context.ItemPedido.Attach(obj);
            _context.Entry(obj).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return obj;
        }

        public async Task<ItemPedido> Salvar(ItemPedido obj)
        {
            if(obj.Id == 0)
            {
                _context.ItemPedido.Attach(obj);
                _context.Entry(obj).State = EntityState.Added;
                await _context.SaveChangesAsync();
                return obj;
            }
            else
            {
                _context.ItemPedido.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return obj;
            }
        }

        public async Task<ItemPedido> SelecionarId(int id)
        {
            return await _context.ItemPedido
                .Include(i => i.Pedidio)
                .Include(i => i.Produto)
                .SingleOrDefaultAsync();
        }

        public async Task<List<ItemPedido>> SelecionarTodos(bool selecionarTodos)
        {
            return await _context.ItemPedido
                .Include(i=>i.Pedidio)
                .Include(i => i.Produto)
                .ToListAsync();
        }

        public async Task<List<ItemPedido>> SelecionarTodosPorPedido(int id)
        {
            return await _context.ItemPedido
                .Include(i => i.Pedidio)
                .Include(i => i.Produto)
                .Where(i=>i.Pedidio.Id == id)
                .ToListAsync();
        }
    }
}
