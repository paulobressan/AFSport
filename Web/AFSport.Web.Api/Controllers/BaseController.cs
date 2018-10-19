using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using AFSport.Web.Api.infra;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AFSport.Web.Api.Controllers
{
    /// <summary>
    /// Controlador base para injeção de dependencia mais utilizada e outros recursos
    /// </summary>
    public class BaseController : ControllerBase
    {
        #region Objetos
        protected readonly IMapper _mapper;
        protected UserLogged userLogged;
        #endregion
        public BaseController(IMapper mapper)
        {
            _mapper = mapper;
        }

        protected void DecodeToken(HttpContext context)
        {
            var token = new JwtSecurityTokenHandler()
                .ReadJwtToken(context.Request.Headers["Authorization"]
                .ToString()
                .Replace("Bearer ", string.Empty)) as JwtSecurityToken;

            userLogged = new UserLogged
            {
                Id = Convert.ToInt32(token.Claims.First(claim => claim.Type == "nameid").Value),
                Nome = token.Subject
            };
        }
    }
}