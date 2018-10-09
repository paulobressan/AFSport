using System.Threading.Tasks;
using AFSport.Web.Api.Controllers;
using AFSport.Web.Api.DTO.Auth;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AFSport.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : BaseController
    {
        #region Objetos
        private readonly IAuthService _authService;
        #endregion

        #region Construtor
        public AuthController(IAuthService authService, IMapper mapper)
            : base(mapper)
        {   
            _authService = authService;
        }
        #endregion

        [HttpPost]
        public async Task<IActionResult> Post(AuthDTO auth)
        {
            if (ModelState.IsValid)
                return Ok(await _authService.Auth(_mapper.Map<Usuario>(auth)));
            return BadRequest("Usuário ou senha inválido.");
        }
    }
}