using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Api.Controllers;
using AFSport.Web.Api.DTO.Produto;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AFSport.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
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
            return Ok(_mapper.Map<List<ProdutoListaDTO>>(await _produtoService.SelecionarTodos()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(_mapper.Map<ProdutoListaDTO>(await _produtoService.SelecionarId(id)));
        }

        [HttpGet("categoria/{id}")]
        public async Task<IActionResult> GetCategoria(int id)
        {
            return Ok(_mapper.Map<List<ProdutoListaDTO>>(await _produtoService.SelecionarProdutosPorCategoria(id)));
        }

        [HttpGet("ativo")]
        public async Task<IActionResult> GetAtivo()
        {
            return Ok(_mapper.Map<List<ProdutoListaDTO>>(await _produtoService.SelecionarTodosAtivos()));
        }

        [HttpGet("inativo")]
        public async Task<IActionResult> GetInativo()
        {
            return Ok(_mapper.Map<List<ProdutoListaDTO>>(await _produtoService.SelecionarTodosInativos()));
        }

        [HttpGet("comEstoque")]
        public async Task<IActionResult> GetComEstoque()
        {
            return Ok(_mapper.Map<List<ProdutoListaDTO>>(await _produtoService.SelecionarProdutosComEstoque()));
        }

        [HttpGet("semEstoque")]
        public async Task<IActionResult> GetSemEstoque()
        {
            return Ok(_mapper.Map<List<ProdutoListaDTO>>(await _produtoService.SelecionarProdutosSemEstoque()));
        }
        #endregion

        #region Post
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ProdutoSalvarDTO produto)
        {
            if (ModelState.IsValid)
                return Ok(_mapper.Map<ProdutoListaDTO>(await _produtoService.Inserir(_mapper.Map<Produto>(produto))));
            return BadRequest("Formato inválido");
        }
        #endregion

        #region Put
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]ProdutoSalvarDTO produto)
        {
            if (ModelState.IsValid)
                return Ok(_mapper.Map<ProdutoListaDTO>(await _produtoService.Alterar(id, _mapper.Map<Produto>(produto))));
            return BadRequest("Formato inválido");
        }
        #endregion

        #region Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _produtoService.Remover(id);
            return Ok();
        }
        #endregion
    }
}