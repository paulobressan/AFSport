namespace AFSport.Web.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController: BaseController
    {
        #region Objetos
        private readonly IClienteService _clienteService;
        #endregion

        public DashboardController(IMapper mapper, IClienteService clienteService) : base(mapper)
        {
            this._clienteService = clienteService;
        }
    }
}