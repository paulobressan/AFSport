using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Api.Controllers;
using AFSport.Web.Api.DTO.Produto;
using AFSport.Web.Core.Interface.Service;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AFSport.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[Controller]")]
    public class ProdutoController : BaseController
    {
        #region Objetos
        private readonly IProdutoService _produtoService;
        #endregion

        public ProdutoController(IProdutoService produtoService, IMapper mapper)
            : base(mapper)
        {
            _produtoService = produtoService;
        }

        #region Get
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<ProdutoDTO>>(await _produtoService.SelecionarTodos()));
        }
        #endregion
    }
}