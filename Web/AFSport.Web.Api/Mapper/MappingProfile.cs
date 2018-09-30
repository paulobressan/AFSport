using AFSport.Web.Api.DTO.Auth;
using AFSport.Web.Api.DTO.Produto;
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
        }
    }
}