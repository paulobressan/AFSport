using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Api.DTO.Caixa;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AFSport.Web.Api.Controllers
{
    public class CaixaController : BaseController
    {
        #region Objetos
        private readonly ICaixaService _caixaService;
        #endregion

        #region Construtor
        public CaixaController(IMapper mapper, ICaixaService caixaService) :
            base(mapper)
        {
            this._caixaService = caixaService;
        }
        #endregion

        #region Get
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<CaixaListaDTO>>(await _caixaService.SelecionarTodos()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(_mapper.Map<CaixaListaDTO>(await _caixaService.SelecionarId(id)));
        }

        [HttpGet("data/{id}")]
        public async Task<IActionResult> GetPorData(DateTime dateTime)
        {
            return Ok(_mapper.Map<CaixaListaDTO>(await _caixaService.SelecionarPorData(dateTime)));
        }

        [HttpGet("data-atual")]
        public async Task<IActionResult> GetPorDataAtual()
        {
            return Ok(_mapper.Map<CaixaListaDTO>(await _caixaService.SelecionarPorDataAtual()));
        }
        #endregion

        #region Post
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CaixaSalvarDTO caixa)
        {
            if (ModelState.IsValid)
                return Ok(_mapper.Map<CaixaListaDTO>(await _caixaService.Inserir(_mapper.Map<Caixa>(caixa))));
            return BadRequest();
        }
        #endregion

        #region Put
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CaixaSalvarDTO caixa)
        {
            if (ModelState.IsValid)
                return Ok(_mapper.Map<CaixaListaDTO>(await _caixaService.Alterar(id, _mapper.Map<Caixa>(caixa))));
            return BadRequest();
        }
        #endregion  
    }
}