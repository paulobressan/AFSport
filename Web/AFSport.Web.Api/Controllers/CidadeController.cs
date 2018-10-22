using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Api.DTO.Cidade;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AFSport.Web.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CidadeController : BaseController
    {
        #region Objetos
        private readonly ICidadeService _cidadeService;
        #endregion
        public CidadeController(IMapper mapper, ICidadeService cidadeService) : base(mapper)
        {
            this._cidadeService = cidadeService;
        }

        #region Get
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<CidadeListaDTO>>(await _cidadeService.SelecionarTodos()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(_mapper.Map<CidadeListaDTO>(await _cidadeService.SelecionarId(id)));
        }

        [HttpGet("ativas")]
        public async Task<IActionResult> GetAtivas()
        {
            return Ok(_mapper.Map<List<CidadeListaDTO>>(await _cidadeService.SelecionarTodosAtivos()));
        }
        #endregion

        #region Post
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CidadeSalvarDTO cidade)
        {
            if (ModelState.IsValid)
                return Ok(_mapper.Map<CidadeListaDTO>(await _cidadeService.Inserir(_mapper.Map<Cidade>(cidade))));
            return BadRequest();
        }
        #endregion

        #region Put
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CidadeSalvarDTO cidade)
        {
            if (ModelState.IsValid)
                return Accepted(_mapper.Map<CidadeListaDTO>(await _cidadeService.Alterar(id, _mapper.Map<Cidade>(cidade))));
            return BadRequest();
        }
        [HttpPut("ativar-inativar/{id}")]
        public async Task<IActionResult> PutAtivarInativar(int id, [FromBody] CidadeSalvarDTO cidade)
        {
            await _cidadeService.AtivarInativar(id, cidade.IsAtivo);
            return Accepted();
        }
        #endregion  
        #region Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _cidadeService.Remover(id);
            return NoContent();
        }
        #endregion
    }
}