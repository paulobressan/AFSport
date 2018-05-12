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
    public class MovimentacaoDAO : BaseDAO, ICRUD<Movimentacao>
    {
        public Task<Movimentacao> Remover(Movimentacao obj)
        {
            throw new NotImplementedException();
        }

        public async Task<Movimentacao> Salvar(Movimentacao obj)
        {
            if(obj.Id== 0)
            {
                _context.Movimentacao.Attach(obj);
                _context.Entry(obj).State = EntityState.Added;
                await _context.SaveChangesAsync();
                return obj;
            }
            else
            {
                _context.Movimentacao.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return obj;
            }
        }

        public async Task<Movimentacao> SelecionarId(int id)
        {
            return await _context.Movimentacao
                .Include(m => m.Operacao)
                .Include(m => m.Pedido)
                .Where(m => m.Id == id)
                .SingleOrDefaultAsync();
        }

        public async Task<List<Movimentacao>> SelecionarTodos(bool selecionarTodos)
        {
            return await _context.Movimentacao
                .Include(m=>m.Operacao)
                .Include(m => m.Pedido)
                .ToListAsync();
        }

        public async Task<List<Movimentacao>> SelecionarTodosPorOperacao(int id)
        {
            return await _context.Movimentacao
                .Include(m => m.Operacao)
                .Include(m => m.Pedido)
                .Where(m=>m.Operacao.Id == id)
                .ToListAsync();
        }

        public async Task<Movimentacao> SelecionarTodosPorPedido(int id)
        {
            return await _context.Movimentacao
                .Include(m => m.Operacao)
                .Include(m => m.Pedido)
                .Where(m => m.Pedido.Id == id)
                .SingleOrDefaultAsync();
        }

        public async Task<List<Movimentacao>> SelecionarTodosPorDatas(DateTime dataInicio,DateTime dataFim)
        {
            return await _context.Movimentacao
                .Include(m => m.Operacao)
                .Include(m => m.Pedido)
                .Where(m=>m.Data >= dataInicio && m.Data <= dataFim)
                .ToListAsync();
        }

        public async Task<List<Movimentacao>> SelecionarTodosPorData(DateTime data)
        {
            return await _context.Movimentacao
                .Include(m => m.Operacao)
                .Include(m => m.Pedido)
                .Where(m => m.Data == data)
                .ToListAsync();
        }
    }
}
