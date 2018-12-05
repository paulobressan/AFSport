using AFSport.Web.Core.Interface.Service;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AFSport.Web.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController: BaseController
    {
        #region Objetos
        private readonly IMovimentacaoService _movimentacaoService;
        #endregion

        public DashboardController(IMapper mapper, IMovimentacaoService movimentacaoService) : base(mapper)
        {
            this._movimentacaoService = movimentacaoService;
        }

        #region Get
        
        #endregion
    }
}