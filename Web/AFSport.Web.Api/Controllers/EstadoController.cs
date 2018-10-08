using System.Threading.Tasks;
using AFSport.Web.Api.DTO.Estado;
using AFSport.Web.Core.Interface.Service;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AFSport.Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstadoController : BaseController
    {
        #region Objetos
        private readonly IEstadoService _estadoService;
        #endregion
        public EstadoController(IMapper mapper, IEstadoService estadoService) : base(mapper)
        {
            this._estadoService = estadoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<EstadoListaDTO>(await _estadoService.SelecionarTodos()));
        }
    }
}