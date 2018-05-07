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
    public class ProdutoDAO : BaseDAO, ICRUD<Produto>
    {
        public async Task<Produto> Salvar(Produto obj)
        {
            if(obj.Id == 0)
            {
                this._context.Produto.Add(obj);
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
                .Where(p => p.Id == id && p.IsAtivo == true && p.Categoria.IsAtivo == true)
                .SingleOrDefaultAsync();
        }

        public async Task<List<Produto>> SelecionarTodos(bool selecionarTodos)
        {
            return selecionarTodos
                ? await this._context.Produto
                .ToListAsync()
                : await this._context.Produto
                .Where(p => p.Categoria.IsAtivo == true)
                .ToListAsync();
        }

        public async Task<List<Produto>> SelecionarProdutosPorCategoria(int idCategoria)
        {
            return await this._context.Produto
                .Where(p => p.Categoria.Id == idCategoria)
                .ToListAsync();
        }

        public Task<Produto> Remover(Produto obj)
        {
            throw new NotImplementedException();
        }
    }
}
