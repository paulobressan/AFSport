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
        public Categoria Ativar(Categoria obj)
        {
            Categoria categoria = SelecionarId(obj.Id);
            categoria = obj;
            categoria.IsAtivo = true;
            this._context.SaveChanges();
            return categoria;
        }

        public Categoria Inativar(Categoria obj)
        {
            Categoria categoria = SelecionarId(obj.Id);
            categoria = obj;
            categoria.IsAtivo = false;
            this._context.SaveChanges();
            return categoria;
        }

        public Categoria Salvar(Categoria obj)
        {
            if (obj.Id == 0)
            {
                this._context.Categorias
                    .Add(obj);
                this._context.SaveChanges();
                return _context.Categorias.ToList().LastOrDefault();
                   
            }
            this._context.Categorias.Attach(obj);
            this._context.Entry(obj).State = EntityState.Modified;
            this._context.SaveChanges();
            return obj;

        }

        public Categoria SelecionarId(int id)
        {
            return this._context.Categorias
                .Where(c => c.Id == id)
                .SingleOrDefault();
        }

        public List<Categoria> SelecionarTodos()
        {
            return this._context.Categorias
                .ToList();
        }
    }
}
