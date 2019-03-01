using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.Interfaces;
using Senai.InLock.WebApi.Repositories;

namespace Senai.InLock.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiosController : ControllerBase
    {

        private IEstudiosRepository estudiosRepository { get; set; }

            public EstudiosController()
            {
                estudiosRepository = new EstudiosRepository();
            }

            [HttpGet]
            public IActionResult Get()
            {
                return Ok(estudiosRepository.Listar());
            }
                                   
        }
    }
