using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SPMEDGROUP_MANHA.Domains;
using SPMEDGROUP_MANHA.Interfaces;
using SPMEDGROUP_MANHA.Repositories;
using SPMEDGROUP_MANHA.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

//using Microsoft.AspNetCore.Http;


namespace SPMEDGROUP_MANHA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository UsuarioRepository { get; set; }


        public LoginController() => UsuarioRepository = new UsuarioRepository();

        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {

            try
            {
                Usuarios loginUsuario = UsuarioRepository.BuscarPorEmailESenha(login);

                if (loginUsuario == null)
                {
                    return NotFound();
                }

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, loginUsuario.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, loginUsuario.Id.ToString()),
                    new Claim(ClaimTypes.Role, loginUsuario.IdTipoUsuario.ToString())
                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("spmedgroup-chave-autenticacao"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "SpMedGroup.WebApi",
                    audience: "SpMedGroup.WebApi",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds
                );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });

            }
            catch (Exception mex)
            {
                return BadRequest(new
                {
                    mensagem = mex
                });
            }

        }
    }
}
