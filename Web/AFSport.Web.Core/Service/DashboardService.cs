using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class DashboardService : IDashboardService
    {
        #region Objetos
        private readonly IDashboardRepository _dashboardRepository;
        #endregion

        #region Construtor
        public DashboardService(IDashboardRepository dashboardRepository)
        {
            this._dashboardRepository = dashboardRepository;
        }
        #endregion

        public async Task<IList<Dashboard>> GraficoMovimentacaoMensal()
        {
            try
            {
                return (IList<Dashboard>)await _dashboardRepository.GraficoMovimentacaoMensal();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}