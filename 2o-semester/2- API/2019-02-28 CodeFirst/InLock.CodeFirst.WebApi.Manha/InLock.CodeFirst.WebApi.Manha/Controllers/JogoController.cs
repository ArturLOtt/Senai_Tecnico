using InLock.CodeFirst.WebApi.Manha.Domains;
using InLock.CodeFirst.WebApi.Manha.Interfaces;
using InLock.CodeFirst.WebApi.Manha.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InLock.CodeFirst.WebApi.Manha.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {


            private IJogoRepository jogosRepository { get; set; }

            public JogoController()
            {
                jogosRepository = new JogoRepository();
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
            [HttpGet("{id}")]
            public IActionResult GetJogoById(int id)
            {
                try
                {
                    return Ok(jogosRepository.ListaPorId(id));
                }
                catch (Exception)
                {

                    return BadRequest();
                }


            }


            [HttpPost]
            public IActionResult Post(JogoDomain jogo)
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
