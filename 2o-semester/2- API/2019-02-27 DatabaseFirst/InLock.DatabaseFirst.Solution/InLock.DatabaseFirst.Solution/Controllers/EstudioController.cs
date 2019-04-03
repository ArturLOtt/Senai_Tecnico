using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InLock.DatabaseFirst.Solution.Domains;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InLock.DatabaseFirst.Solution.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EstudioController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                using (InLockContext ctx = new InLockContext())
                {
                    return Ok(ctx.Estudios.ToList());
                }
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }

        [HttpGet("estudioComJogos")]
        public IActionResult GetEstudioComJogos()
        {
            try
            {
                using (InLockContext ctx = new InLockContext())
                {
                    return Ok(ctx.Estudios.Include("Jogos").ToList());
                }
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Post(Estudios estudio)
        {
            try
            {
                using (InLockContext ctx = new InLockContext())
                {
                    ctx.Estudios.Add(estudio);
                    ctx.SaveChanges();
                }
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Put(Estudios estudio)
        {
            try
            {

                using (InLockContext ctx = new InLockContext())
                {

                    Estudios estudioExiste = ctx.Estudios.Find(estudio.Estudioid);

                    if (estudioExiste == null)
                    {
                        return NotFound();
                    }

                    estudioExiste.Nomeestudio = estudio.Nomeestudio;
                     ctx.Estudios.Update(estudio);
                    // ctx.Estudios.Attach(estudio);
                    ctx.SaveChanges();
                }
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                using (InLockContext ctx = new InLockContext())
                {

                    Estudios estudioExiste = ctx.Estudios.Find(id);

                    if (estudioExiste == null)
                    {
                        return NotFound();
                    }

                    ctx.Estudios.Remove(ctx.Estudios.Find(id));
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