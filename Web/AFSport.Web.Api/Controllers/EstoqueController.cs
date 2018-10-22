using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Api.DTO.Estoque;
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
    public class EstoqueController : BaseController
    {
        #region Objetos
        private readonly IEstoqueService _estoqueService;
        #endregion

        #region Construtor
        public EstoqueController(IMapper mapper, IEstoqueService estoqueService) :
            base(mapper)
        {
            this._estoqueService = estoqueService;
        }
        #endregion

        #region Get
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<EstoqueListaDTO>>(await _estoqueService.SelecionarTodos()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(_mapper.Map<EstoqueListaDTO>(await _estoqueService.SelecionarId(id)));
        }

        [HttpGet("produto/{idProduto}")]
        public async Task<IActionResult> GetPorProduto(int idProduto)
        {
            return Ok(_mapper.Map<List<EstoqueListaDTO>>(await _estoqueService.SelecionarEstoquePorProduto(idProduto)));
        }

        #endregion

        #region Post
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EstoqueSalvarDTO estoque)
        {
            if (ModelState.IsValid)
            {
                this.DecodeToken(HttpContext);
                estoque.IdUsuario = userLogged.Id;
                return Ok(_mapper.Map<EstoqueListaDTO>(await _estoqueService.Inserir(_mapper.Map<Estoque>(estoque))));
            }
            return BadRequest();
        }
        #endregion

        #region Put
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] EstoqueSalvarDTO estoque)
        {
            if (ModelState.IsValid)
            {
                this.DecodeToken(HttpContext);
                estoque.IdUsuario = userLogged.Id;
                return Accepted(_mapper.Map<EstoqueListaDTO>(await _estoqueService.Alterar(id, _mapper.Map<Estoque>(estoque))));
            }
            return BadRequest();
        }
        #endregion  

        #region Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _estoqueService.Remover(id);
            return NoContent();
        }
        #endregion
    }
}