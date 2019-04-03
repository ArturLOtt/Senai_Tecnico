using InLock.DatabaseFirst.Solution.Domains;
using InLock.DatabaseFirst.Solution.Interfaces;
using InLock.DatabaseFirst.Solution.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace InLock.DatabaseFirst.Solution.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        private IJogosRepository jogosRepository { get; set; }

        public JogoController()
        {
            jogosRepository = new JogosRepository();
        }



        [HttpGet]
        public IActionResult GetJogo()
        {
            try
            {
                return Ok(jogosRepository.Listar());
            }
            catch (Exception)
            {

                return BadRequest();
            }
            

        }

        [Produces("application/json")]
        [Route("api/[controller]")]
        [HttpGet]
        public IActionResult GetJogoById()
        {
            try
            {
                return Ok(jogosRepository.Listar());
            }
            catch (Exception)
            {

                return BadRequest();
            }


        }


        [HttpPost]
        public IActionResult Post(Jogos jogo)
        {
            try
            {
                jogosRepository.Cadastrar(jogo);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }



    }
}
