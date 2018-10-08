using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Api.DTO.Estado;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;
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

        #region Get
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<EstadoListaDTO>>(await _estadoService.SelecionarTodos()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(_mapper.Map<EstadoListaDTO>(await _estadoService.SelecionarId(id)));
        }

        [HttpGet("ativas")]
        public async Task<IActionResult> GetAtivas()
        {
            return Ok(_mapper.Map<List<EstadoListaDTO>>(await _estadoService.SelecionarTodosAtivos()));
        }
        #endregion

        #region Post
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EstadoSalvarDTO estado)
        {
            if (ModelState.IsValid)
                return Ok(_mapper.Map<EstadoListaDTO>(await _estadoService.Inserir(_mapper.Map<Estado>(estado))));
            return BadRequest("Campos inválidos");
        }
        #endregion

        #region Put
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] EstadoSalvarDTO estado)
        {
            if (ModelState.IsValid)
                return Ok(_mapper.Map<EstadoListaDTO>(await _estadoService.Alterar(id, _mapper.Map<Estado>(estado))));
            return BadRequest("Campos inválidos");
        }
        [HttpPut("ativar-inativar/{id}")]
        public async Task<IActionResult> PutAtivarInativar(int id, [FromBody] EstadoSalvarDTO estado)
        {
            await _estadoService.AtivarInativar(id, estado.IsAtivo);
            return Ok();
        }
        #endregion  
        #region Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _estadoService.Remover(id);
            return Ok();
        }
        #endregion
    }
}