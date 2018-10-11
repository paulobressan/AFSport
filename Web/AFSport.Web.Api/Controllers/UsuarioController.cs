using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Api.DTO.Usuario;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AFSport.Web.Api.Controllers
{
    public class UsuarioController : BaseController
    {
        #region Objetos
        private readonly IUsuarioService _usuarioService;
        #endregion

        #region Construtor
        public UsuarioController(IMapper mapper, IUsuarioService usuarioService) :
            base(mapper)
        {
            this._usuarioService = usuarioService;
        }
        #endregion

        #region Get
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<UsuarioListaDTO>>(await _usuarioService.SelecionarTodos()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(_mapper.Map<UsuarioListaDTO>(await _usuarioService.SelecionarId(id)));
        }

        #endregion

        #region Post
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UsuarioSalvarDTO usuario)
        {
            if (ModelState.IsValid)
                return Ok(_mapper.Map<UsuarioListaDTO>(await _usuarioService.Inserir(_mapper.Map<Usuario>(usuario))));
            return BadRequest();
        }
        #endregion

        #region Put
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UsuarioSalvarDTO usuario)
        {
            if (ModelState.IsValid)
                return Ok(_mapper.Map<UsuarioListaDTO>(await _usuarioService.Alterar(id, _mapper.Map<Usuario>(usuario))));
            return BadRequest();
        }
        [HttpPut("ativar-inativar/{id}")]
        public async Task<IActionResult> PutAtivarInativar(int id, [FromBody] UsuarioSalvarDTO usuario)
        {
            await _usuarioService.AtivarInativar(id, usuario.IsAtivo);
            return Ok();
        }
        #endregion  
    }
}