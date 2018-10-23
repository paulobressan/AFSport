using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Api.DTO.Movimentacao;
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
    public class MovimentacaoController : BaseController
    {
        #region Objetos
        private readonly IMovimentacaoService _movimentacaoService;
        #endregion

        #region Construtor
        public MovimentacaoController(IMapper mapper, IMovimentacaoService movimentacaoService) :
            base(mapper)
        {
            this._movimentacaoService = movimentacaoService;
        }
        #endregion

        #region Get
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<MovimentacaoListaDTO>>(await _movimentacaoService.SelecionarTodos()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(_mapper.Map<MovimentacaoListaDTO>(await _movimentacaoService.SelecionarId(id)));
        }
        #endregion

        #region Post
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MovimentacaoSalvarDTO movimentacao)
        {
            if (ModelState.IsValid)
                return Ok(_mapper.Map<MovimentacaoListaDTO>(await _movimentacaoService.Inserir(_mapper.Map<Movimentacao>(movimentacao))));
            return BadRequest();
        }
        #endregion

        #region Put
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] MovimentacaoSalvarDTO movimentacao)
        {
            if (ModelState.IsValid)
                return Accepted(_mapper.Map<MovimentacaoListaDTO>(await _movimentacaoService.Alterar(id, _mapper.Map<Movimentacao>(movimentacao))));
            return BadRequest();
        }
        #endregion  
    }
}