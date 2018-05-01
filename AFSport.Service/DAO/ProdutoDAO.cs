using AFSport.DAO.Model;
using AFSport.Service.Base;
using AFSport.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.DAO
{
    public class ProdutoDAO : BaseDAO, ICRUD<Produto>
    {
        public Produto Ativar(Produto obj)
        {
            throw new NotImplementedException();
        }
     
        public Produto Inativar(Produto obj)
        {
            throw new NotImplementedException();
        }

        public Produto Salvar(Produto obj)
        {
            throw new NotImplementedException();
        }

        public Produto SelecionarId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Produto> SelecionarTodos()
        {
            return this._context.Produto
                .ToList();
        }
    }
}
