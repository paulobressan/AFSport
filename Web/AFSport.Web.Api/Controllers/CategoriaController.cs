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

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<CategoriaListaDTO>>(await _categoriaService.SelecionarTodos()));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CategoriaSalvarDTO categoria)
        {
            return Ok(_mapper.Map<CategoriaListaDTO>(await _categoriaService.Inserir(_mapper.Map<Categoria>(categoria))));
        }

    }
}