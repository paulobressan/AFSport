using AFSport.Web.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface ICaixaRepository
    {
        Task<List<Caixa>> SelecionarTodos(bool selecionarTodos);
        Task<Caixa> SelecionarId(int id);
        Task<Caixa> Inserir(Caixa obj);
        Task<Caixa> Alterar(Caixa obj);
        Task Remover(Caixa obj);
        Task<Caixa> SelecionarPorData(DateTime data);
        Task<Caixa> SelecionarPorDataAtual(DateTime data);
        Task<int> TotalRegistros();
    }
}
