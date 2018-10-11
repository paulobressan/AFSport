using AFSport.Web.Api.DTO.Auth;
using AFSport.Web.Api.DTO.Caixa;
using AFSport.Web.Api.DTO.Categoria;
using AFSport.Web.Api.DTO.Cidade;
using AFSport.Web.Api.DTO.Cliente;
using AFSport.Web.Api.DTO.Estado;
using AFSport.Web.Api.DTO.Estoque;
using AFSport.Web.Api.DTO.ItemPedido;
using AFSport.Web.Api.DTO.Movimentacao;
using AFSport.Web.Api.DTO.Operacao;
using AFSport.Web.Api.DTO.Pedido;
using AFSport.Web.Api.DTO.Produto;
using AFSport.Web.Api.DTO.Usuario;
using AFSport.Web.Core.Model;
using AutoMapper;

namespace AFSport.Web.Api.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Auth
            CreateMap<AuthDTO, Usuario>();
            #endregion

            #region Produto
            CreateMap<Produto, ProdutoListaDTO>();
            CreateMap<ProdutoSalvarDTO, Produto>();
            #endregion

            #region Categoria
            CreateMap<Categoria, CategoriaListaDTO>();
            CreateMap<Categoria, CategoriaSalvarDTO>();
            #endregion

            #region Estado
            CreateMap<Estado, EstadoListaDTO>();
            CreateMap<Estado, EstadoSalvarDTO>();
            #endregion

            #region Cidade
            CreateMap<Cidade, CidadeListaDTO>();
            CreateMap<Cidade, CidadeSalvarDTO>();
            #endregion

            #region Cliente
            CreateMap<Cliente, ClienteListaDTO>();
            CreateMap<Cliente, ClienteSalvarDTO>();
            #endregion

            #region Usuario
            CreateMap<Usuario, UsuarioListaDTO>();
            CreateMap<Usuario, UsuarioSalvarDTO>();
            #endregion

            #region Pedido
            CreateMap<Pedido, PedidoListaDTO>();
            CreateMap<Pedido, PedidoSalvarDTO>();
            #endregion

            #region Pedido
            CreateMap<Pedido, PedidoListaDTO>();
            CreateMap<Pedido, PedidoSalvarDTO>();
            #endregion

            #region Operacao
            CreateMap<Operacao, OperacaoListaDTO>();
            CreateMap<Operacao, OperacaoSalvarDTO>();
            #endregion

            #region Movimentacao
            CreateMap<Movimentacao, MovimentacaoListaDTO>();
            CreateMap<Movimentacao, MovimentacaoSalvarDTO>();
            #endregion

            #region ItemPedido
            CreateMap<ItemPedido, ItemPedidoListaDTO>();
            CreateMap<ItemPedido, ItemPedidoSalvarDTO>();
            #endregion

            #region Estoque
            CreateMap<Estoque, EstoqueListaDTO>();
            CreateMap<Estoque, EstoqueSalvarDTO>();
            #endregion

            #region Caixa
            CreateMap<Caixa, CaixaListaDTO>();
            CreateMap<Caixa, CaixaSalvarDTO>();
            #endregion
        }
    }
}