using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AFSport.Web.Api.Controllers
{
    /// <summary>
    /// Controlador base para injeção de dependencia mais utilizada e outros recursos
    /// </summary>
    public class BaseController : ControllerBase
    {
        #region Objetos
            protected readonly IMapper _mapper ;
        #endregion
        public BaseController(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}