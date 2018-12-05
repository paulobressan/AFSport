using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Interface.Repository
{
    public interface IDashboardRepository
    {
         Task<IEnumerable<Dashboard>> GraficoMovimentacaoMensal();
    }
}