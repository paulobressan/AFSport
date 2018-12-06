using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Api.DTO.ItemPedido;
using AFSport.Web.Api.DTO.Movimentacao;
using AFSport.Web.Api.DTO.Pedido;
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

        #region Pedido
        #region Get
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<PedidoListaDTO>>(await _pedidoService.SelecionarTodos()));
        }

        [HttpGet("{idPedido}")]
        public async Task<IActionResult> Get([FromRoute]int idPedido)
        {
            return Ok(_mapper.Map<PedidoListaDTO>(await _pedidoService.SelecionarId(idPedido)));
        }

        #endregion

        #region Post
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PedidoSalvarDTO pedido)
        {
            if (ModelState.IsValid)
            {
                this.DecodeToken(HttpContext);
                pedido.IdUsuario = userLogged.Id;
                return Ok(_mapper.Map<PedidoListaDTO>(await _pedidoService.Inserir(_mapper.Map<Pedido>(pedido))));
            }
            return BadRequest();
        }

        #endregion
        #region Put
        [HttpPut("{idPedido}")]
        public async Task<IActionResult> Put([FromRoute]int idPedido, [FromBody] PedidoSalvarDTO pedido)
        {
            if (ModelState.IsValid)
            {
                this.DecodeToken(HttpContext);
                pedido.IdUsuario = userLogged.Id;
                return Accepted(_mapper.Map<PedidoListaDTO>(await _pedidoService.Alterar(idPedido, _mapper.Map<Pedido>(pedido))));
            }
            return BadRequest();
        }

        #endregion
        #region Patch
        [HttpPatch("{idPedido}/cancelar")]
        public async Task<IActionResult> Patch([FromRoute]int idPedido)
        {
            await _pedidoService.CancelarPedido(idPedido);
            return NoContent();
        }

        [HttpPatch("{idPedido}/finalizar")]
        public async Task<IActionResult> Patch([FromRoute]int idPedido, [FromBody] MovimentacaoSalvarDTO movimentacaoSalvarDTO)
        {
            if (ModelState.IsValid)
            {
                this.DecodeToken(HttpContext);
                movimentacaoSalvarDTO.IdUsuario = userLogged.Id;
                return Accepted(_mapper.Map<PedidoListaDTO>(await _pedidoService.FinalizarPedido(idPedido, _mapper.Map<Movimentacao>(movimentacaoSalvarDTO))));
            }
            return BadRequest();
        }
        #endregion
        #endregion

        #region PedidoItem
        [HttpGet("{idPedido}/itens-pedido")]
        public async Task<IActionResult> GetItensPedido([FromRoute]int idPedido)
        {
            return Ok(_mapper.Map<List<Pedido>>(await _itemPedidoService.SelecionarPorPedido(idPedido)));
        }

        [HttpPut("{idPedido}/item-pedido/{idItemPedido}")]
        public async Task<IActionResult> PutItemPedido([FromRoute] int idPedido, [FromRoute]int idItemPedido, [FromBody] ItemPedidoSalvarDTO itemPedido)
        {
            if (ModelState.IsValid)
                return Accepted(_mapper.Map<ItemPedidoListaDTO>(await _itemPedidoService.Alterar(idPedido, idItemPedido, _mapper.Map<ItemPedido>(itemPedido))));
            return BadRequest();
        }

        [HttpPost("{idPedido}/itens-pedido")]
        public async Task<IActionResult> PostItemPedido([FromRoute]int idPedido, [FromBody] ItemPedidoSalvarDTO itemPedido)
        {
            if (ModelState.IsValid)
                return Ok(_mapper.Map<ItemPedidoListaDTO>(await _itemPedidoService.Inserir(idPedido, _mapper.Map<ItemPedido>(itemPedido))));
            return BadRequest();
        }
        #endregion
    }
}