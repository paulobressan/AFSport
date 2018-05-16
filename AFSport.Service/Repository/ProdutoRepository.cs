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
    public class ProdutoRepository : BaseDAO, ICRUD<Produto>
    {
        public async Task<Produto> Salvar(Produto obj)
        {
            if(obj.Id == 0)
            {
                this._context.Produto.Attach(obj);
                this._context.Entry(obj).State = EntityState.Added;
                await this._context.SaveChangesAsync();
                return obj;
            }
            else
            {
                this._context.Produto.Attach(obj);
                this._context.Entry(obj).State = EntityState.Modified;
                await this._context.SaveChangesAsync();
                return obj;
            }
        }

        public async Task<Produto> SelecionarId(int id)
        {
            return await this._context.Produto
                .Include(p => p.Categoria)
                .Where(p => p.Id == id && p.IsAtivo == true && p.Categoria.IsAtivo == true)
                .SingleOrDefaultAsync();
        }

        public async Task<List<Produto>> SelecionarTodos(bool selecionarTodos)
        { 
            var valores = selecionarTodos
                ? await this._context.Produto
                .Include(p => p.Categoria)
                .ToListAsync()
                : await this._context.Produto
                .Where(p => p.Categoria.IsAtivo == true)
                .ToListAsync();
            return valores;
        }

        public async Task<List<Produto>> SelecionarProdutosPorCategoria(int idCategoria)
        {
            return await this._context.Produto
                .Include(p => p.Categoria)
                .Where(p => p.Categoria.Id == idCategoria)
                .ToListAsync();
        }

        public async Task<Produto> Remover(Produto obj)
        {
            _context.Produto.Attach(obj);
            _context.Entry(obj).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return obj;
        }
    }
}
