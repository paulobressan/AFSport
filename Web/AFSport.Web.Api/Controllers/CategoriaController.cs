using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Api.DTO.Categoria;
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
    public class CategoriaController : BaseController
    {
        #region Objetos
        private readonly ICategoriaService _categoriaService;
        #endregion
        public CategoriaController(ICategoriaService categoriaService, IMapper mapper) : base(mapper)
        {
            _categoriaService = categoriaService;
        }
        #region Get
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<CategoriaListaDTO>>(await _categoriaService.SelecionarTodos()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(_mapper.Map<CategoriaListaDTO>(await _categoriaService.SelecionarId(id)));
        }

        [HttpGet("ativas")]
        public async Task<IActionResult> GetAtivas()
        {
            return Ok(_mapper.Map<List<CategoriaListaDTO>>(await _categoriaService.SelecionarTodosAtivo()));
        }
        #endregion

        #region Post
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CategoriaSalvarDTO categoria)
        {
            if (ModelState.IsValid)
                return Ok(_mapper.Map<CategoriaListaDTO>(await _categoriaService.Inserir(_mapper.Map<Categoria>(categoria))));
            return BadRequest("Campos inválidos");
        }
        #endregion

        #region Put
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CategoriaSalvarDTO categoria)
        {
            if (ModelState.IsValid)
                return Ok(_mapper.Map<CategoriaListaDTO>(await _categoriaService.Alterar(id, _mapper.Map<Categoria>(categoria))));
            return BadRequest("Campos inválidos");
        }
        [HttpPut("ativar-inativar/{id}")]
        public async Task<IActionResult> PutAtivarInativar(int id, [FromBody] CategoriaSalvarDTO categoria)
        {
            await _categoriaService.AtivarInativar(id, categoria.IsAtivo);
            return Ok();
        }
        #endregion  
        #region Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoriaService.Remover(id);
            return Ok();
        }
        #endregion
    }
}