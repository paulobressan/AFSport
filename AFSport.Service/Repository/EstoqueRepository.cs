using AFSport.DAO.Model;
using AFSport.Service.Base;
using AFSport.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Repository
{
    public class EstoqueRepository : BaseDAO, ICRUD<Estoque>
    {
        public Task<Estoque> Remover(Estoque obj)
        {
            throw new NotImplementedException();
        }

        public Task<Estoque> Salvar(Estoque obj)
        {
            throw new NotImplementedException();
        }

        public Task<Estoque> SelecionarId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Estoque>> SelecionarTodos(bool selecionarTodos)
        {
            throw new NotImplementedException();
        }
    }
}
