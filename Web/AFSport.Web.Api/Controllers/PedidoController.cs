using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Api.DTO.ItemPedido;
using AFSport.Web.Api.DTO.Pedido;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AFSport.Web.Api.Controllers
{
    public class PedidoController : BaseController
    {
        #region Objetos
        private readonly IPedidoService _pedidoService;
        private readonly IItemPedidoService _itemPedidoService;
        #endregion
        #region Construtor
        public PedidoController(
            IMapper mapper,
            IPedidoService pedidoService,
            IItemPedidoService itemPedidoService) : base(mapper)
        {
            this._pedidoService = pedidoService;
            this._itemPedidoService = itemPedidoService;
        }
        #endregion

        #region Get
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<Pedido>>(await _pedidoService.SelecionarTodos()));
        }

        [HttpGet("{idPedido}")]
        public async Task<IActionResult> Get(int idPedido)
        {
            return Ok(_mapper.Map<List<Pedido>>(await _pedidoService.SelecionarId(idPedido)));
        }

        [HttpGet("itens-pedido/{idPedido}")]
        public async Task<IActionResult> GetItensPedido(int idPedido)
        {
            return Ok(_mapper.Map<List<Pedido>>(await _itemPedidoService.SelecionarPorPedido(idPedido)));
        }
        #endregion

        #region Post
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PedidoSalvarDTO pedido)
        {
            if (ModelState.IsValid)
                return Ok(_mapper.Map<PedidoListaDTO>(await _pedidoService.Inserir(_mapper.Map<Pedido>(pedido))));
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> PostItemPedido([FromBody] ItemPedidoSalvarDTO itemPedido)
        {
            if (ModelState.IsValid)
                return Ok(_mapper.Map<ItemPedidoListaDTO>(await _itemPedidoService.Inserir(_mapper.Map<ItemPedido>(itemPedido))));
            return BadRequest();
        }
        #endregion
        #region Put
        [HttpPut("{idPedido}")]
        public async Task<IActionResult> Put(int idPedido, [FromBody] PedidoSalvarDTO pedido)
        {
            if (ModelState.IsValid)
                return Accepted(_mapper.Map<PedidoListaDTO>(await _pedidoService.Alterar(idPedido, _mapper.Map<Pedido>(pedido))));
            return BadRequest();
        }

        [HttpPut("item-pedido/{idItemPedido}")]
        public async Task<IActionResult> PostItemPedido(int idItemPedido, [FromBody] ItemPedidoSalvarDTO itemPedido)
        {
            if (ModelState.IsValid)
                return Accepted(_mapper.Map<ItemPedidoListaDTO>(await _itemPedidoService.Alterar(idItemPedido, _mapper.Map<ItemPedido>(itemPedido))));
            return BadRequest();
        }
        #endregion
        #region Delete

        #endregion
    }
}