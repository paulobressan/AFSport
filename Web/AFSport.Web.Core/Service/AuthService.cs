using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace AFSport.Web.Core.Service
{
    public class AuthService : IAuthService
    {
        #region Objetos
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IConfiguration _configuration;
        #endregion

        public AuthService(IUsuarioRepository usuarioRepository, IConfiguration configuration)
        {
            _usuarioRepository = usuarioRepository;
            _configuration = configuration;
        }

        public async Task<string> Auth(Usuario usuario)
        {
            return await CriarToken(await _usuarioRepository.AutenticarUsuario(usuario.Login, usuario.Senha) ??
                throw new KeyNotFoundException("Usuário ou senha incorretos."));
        }

        private async Task<string> CriarToken(Usuario usuario)
        {
            return await Task.Factory.StartNew(() =>
            {
                var direitos = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, usuario.Nome),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                var chave = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("alura-webapi-authentication-valid"));

                var credenciais = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "AFSport.Web.Api",
                    audience: "Service-Mobile",
                    claims: direitos,
                    signingCredentials: credenciais,
                    expires: DateTime.Now.AddMinutes(30)
                );

                return new JwtSecurityTokenHandler().WriteToken(token);
            });
        }
    }
}