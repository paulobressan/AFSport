using AFSport.Web.Api.DTO.Auth;
using AFSport.Web.Api.DTO.Caixa;
using AFSport.Web.Api.DTO.Categoria;
using AFSport.Web.Api.DTO.Cidade;
using AFSport.Web.Api.DTO.Cliente;
using AFSport.Web.Api.DTO.Dashboard;
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
            CreateMap<CategoriaSalvarDTO, Categoria>();
            #endregion

            #region Estado
            CreateMap<Estado, EstadoListaDTO>();
            CreateMap<EstadoSalvarDTO, Estado>();
            #endregion

            #region Cidade
            CreateMap<Cidade, CidadeListaDTO>();
            CreateMap<CidadeSalvarDTO, Cidade>();
            #endregion

            #region Cliente
            CreateMap<Cliente, ClienteListaDTO>();
            CreateMap<ClienteSalvarDTO, Cliente>();
            #endregion

            #region Usuario
            CreateMap<Usuario, UsuarioListaDTO>();
            CreateMap<UsuarioSalvarDTO, Usuario>();
            #endregion

            #region Pedido
            CreateMap<Pedido, PedidoListaDTO>();
            CreateMap<PedidoSalvarDTO, Pedido>();
            #endregion

            #region Operacao
            CreateMap<Operacao, OperacaoListaDTO>();
            CreateMap<OperacaoSalvarDTO, Operacao>();
            #endregion

            #region Movimentacao
            CreateMap<Movimentacao, MovimentacaoListaDTO>();
            CreateMap<MovimentacaoSalvarDTO, Movimentacao>();
            #endregion

            #region ItemPedido
            CreateMap<ItemPedido, ItemPedidoListaDTO>();
            CreateMap<ItemPedidoSalvarDTO, ItemPedido>();
            #endregion

            #region Estoque
            CreateMap<Estoque, EstoqueListaDTO>();
            CreateMap<EstoqueSalvarDTO, Estoque>();
            #endregion

            #region Caixa
            CreateMap<Caixa, CaixaListaDTO>();
            CreateMap<CaixaSalvarDTO, Caixa>();
            #endregion

            #region Dashboard
            CreateMap<Dashboard, DashboardDTO>()
                .ForMember(dto => dto.data, d => d.MapFrom(dash => dash.data.ToShortDateString()))
                .ForMember(dto => dto.ValorFormat, d => d.MapFrom(dash => string.Format("{0:C}", dash.Valor)));
            #endregion
        }
    }
}