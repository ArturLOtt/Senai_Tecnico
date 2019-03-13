using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SPMEDGROUP_MANHA.Domains;
using SPMEDGROUP_MANHA.Interfaces;
using SPMEDGROUP_MANHA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMEDGROUP_MANHA.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private IUsuarioRepository usuarioRepository { get; set; }

        public UsuarioController() => usuarioRepository = new UsuarioRepository();

        [Authorize(Roles = "3")]
        [HttpPost]
        public IActionResult Post(Usuarios usuario)
        {
            try
            {
                using (SPMEDGROUPContext ctx = new SPMEDGROUPContext())
                {
                    ctx.Usuarios.Add(usuario);
                    ctx.SaveChanges();
                }
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }


    }
}
