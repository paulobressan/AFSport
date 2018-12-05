using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Interface.Service
{
    public interface IDashboardService
    {
        Task<IList<Dashboard>> GraficoMovimentacaoMensal();
    }
}