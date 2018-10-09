using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IPrecoRepository
    {
        Task<List<Preco>> SelecionarTodos(bool selecionarTodos);
        Task<Preco> SelecionarId(int id);
        Task<Preco> Salvar(Preco obj);
        Task Remover(Preco obj);
        Task<Preco> SelecionarPorIdProdutoEIntervaloData(int idProduto);
    }
}
