using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Api.DTO.Dashboard;
using AFSport.Web.Core.Interface.Service;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AFSport.Web.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : BaseController
    {
        #region Objetos
        private readonly IDashboardService _dashboardService;
        #endregion

        public DashboardController(IMapper mapper, IDashboardService dashboardService) : base(mapper)
        {
            this._dashboardService = dashboardService;
        }

        #region Get
        [HttpGet("grafico-movimentacao-mensal")]
        public async Task<IActionResult> GetGraficoMovimentacao()
        {
            return Ok(_mapper.Map<IList<DashboardDTO>>(await _dashboardService.GraficoMovimentacaoMensal()));
        }
        #endregion
    }
}