using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Api.DTO.Operacao;
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
    public class OperacaoController : BaseController
    {
        #region Objetos
        private readonly IOperacaoService _operacaoService;
        #endregion

        #region Construtor
        public OperacaoController(IMapper mapper, IOperacaoService operacaoService) :
            base(mapper)
        {
            this._operacaoService = operacaoService;
        }
        #endregion
        
        #region Get
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<OperacaoListaDTO>>(await _operacaoService.SelecionarTodos()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(_mapper.Map<OperacaoListaDTO>(await _operacaoService.SelecionarId(id)));
        }

        [HttpGet("ativas")]
        public async Task<IActionResult> GetAtivas()
        {
            return Ok(_mapper.Map<List<OperacaoListaDTO>>(await _operacaoService.SelecionarTodosAtivos()));
        }
        #endregion

        #region Post
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OperacaoSalvarDTO operacao)
        {
            if (ModelState.IsValid)
                return Ok(_mapper.Map<OperacaoListaDTO>(await _operacaoService.Inserir(_mapper.Map<Operacao>(operacao))));
            return BadRequest();
        }
        #endregion

        #region Put
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] OperacaoSalvarDTO operacao)
        {
            if (ModelState.IsValid)
                return Accepted(_mapper.Map<OperacaoListaDTO>(await _operacaoService.Alterar(id, _mapper.Map<Operacao>(operacao))));
            return BadRequest();
        }
        [HttpPut("ativar-inativar/{id}")]
        public async Task<IActionResult> PutAtivarInativar(int id, [FromBody] OperacaoSalvarDTO operacao)
        {
            await _operacaoService.AtivarInativar(id, operacao.IsAtivo);
            return Accepted();
        }
        #endregion  
        #region Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _operacaoService.Remover(id);
            return NoContent();
        }
        #endregion
    }
}