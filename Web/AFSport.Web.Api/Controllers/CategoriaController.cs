using AFSport.Web.Core.Interface.Service;
using AutoMapper;

namespace AFSport.Web.Api.Controllers
{
    public class CategoriaController : BaseController
    {
        #region Objetos
        private readonly ICategoriaService _categoriaService;
        #endregion
        public CategoriaController(IMapper mapper) : base(mapper)
        {
        }
    }
}