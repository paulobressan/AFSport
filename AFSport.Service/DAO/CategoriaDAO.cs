using AFSport.DAO;
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
    public class CategoriaDAO : BaseDAO, ICRUD<Categoria>
    {
        public async Task<Categoria> Remover(Categoria obj)
        {
            this._context.Categorias.Attach(obj);
            this._context.Entry(obj).State = EntityState.Deleted;
            await this._context.SaveChangesAsync();
            return obj;
        }

        public async Task<Categoria> Salvar(Categoria obj)
        {
            if (obj.Id == 0)
            {
                this._context.Categorias
                    .Add(obj);
                await this._context.SaveChangesAsync();
                return obj;
            }
            else
            {
                this._context.Categorias.Attach(obj);
                this._context.Entry(obj).State = EntityState.Modified;
                await this._context.SaveChangesAsync();
                return obj;
            } 
        }

        public async Task<Categoria> SelecionarId(int id)
        {
            return await this._context.Categorias
                .Where(c => c.Id == id && c.IsAtivo == true)
                .SingleOrDefaultAsync();
                
        }

        public async Task<List<Categoria>> SelecionarTodos(bool selecionarTodos)
        {
            return selecionarTodos
                ? await this._context.Categorias
                .ToListAsync()
                : await this._context.Categorias
                .Where(c => c.IsAtivo == true)
                .ToListAsync();
        }
    }
}
