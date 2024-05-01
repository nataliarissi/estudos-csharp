using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Exo.WebApi.Crud.Models;
using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace Exo.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/usuario")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuarioRepository _repository;
    
        public UsuariosController(UsuarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_repository.Listar());
        }

        // [HttpPost]
        // public IActionResult Cadastrar(Usuario usuario)
        // {
        //     _repository.Cadastrar(usuario);
        //     return StatusCode(201);
        // }

        public IActionResult Post(Usuario usuario)
        {
            Usuario usuarioBuscado = _repository.Login(usuario.Email, usuario.Senha);
            if(usuarioBuscado == null)
            {
                return NotFound("Email ou senha inválidos");
            }

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
            new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.Id.ToString()),
        };

        var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("exoapi-chave-autenticacao"));

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        
        var token = new JwtSecurityToken(
            issuer : "exoapi.webapi",
            audience : "exoapi.webapi",
            claims : claims,
            expires : DateTime.Now.AddMinutes(30),
            signingCredentials : creds 
        );
        return Ok(
            new { token = new JwtSecurityTokenHandler().WriteToken(token) }
        );
    }

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Usuario usuario = _repository.BuscarPorId(id);
            if(usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [Authorize]
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Usuario usuario)
        {
            _repository.Atualizar(id, usuario);
            return StatusCode(204);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _repository.Deletar(id);
                return StatusCode(204);
            }
            catch(Exception e)
            {
                return BadRequest();
            }
        }
    }
}