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
    public class OperacaoDAO : BaseDAO, ICRUD<Operacao>
    {
        public async Task<Operacao> Remover(Operacao obj)
        {
            _context.Operacao.Attach(obj);
            _context.Entry(obj).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return obj;
        }

        public async Task<Operacao> Salvar(Operacao obj)
        {
            if(obj.Id == 0)
            {
                _context.Operacao.Attach(obj);
                _context.Entry(obj).State = EntityState.Added;
                await _context.SaveChangesAsync();
                return obj;
            }
            else
            {
                _context.Operacao.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return obj;
            }
        }

        public async Task<Operacao> SelecionarId(int id)
        {
            return await _context.Operacao
                .Where(o => o.Id == id)
                .SingleOrDefaultAsync();
        }

        public async Task<List<Operacao>> SelecionarTodos(bool selecionarTodos)
        {
            return await _context.Operacao
                .ToListAsync();
        }
    }
}
