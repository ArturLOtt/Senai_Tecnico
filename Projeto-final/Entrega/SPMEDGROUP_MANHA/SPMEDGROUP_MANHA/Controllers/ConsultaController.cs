using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class ConsultaController : ControllerBase
    {

        private IConsultaRepository consultaRepository { get; set; }

        public ConsultaController() => consultaRepository = new ConsultaRepository();

        [HttpPost]
        public IActionResult Post(Consulta consulta)
        {
            try
            {
                using (SPMEDGROUPContext ctx = new SPMEDGROUPContext())
                {
                    ctx.Consulta.Add(consulta);
                    ctx.SaveChanges();
                }
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }
                                   
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                using (SPMEDGROUPContext ctx = new SPMEDGROUPContext())
                {
                    return Ok(ctx.Consulta.ToList());
                }
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }

        [HttpGet("{Id}")]
        //[HttpGet("Medico/{Id}")]
        public IActionResult GetDoPaciente()
        {
            try
            {
                using (SPMEDGROUPContext ctx = new SPMEDGROUPContext())
                {
                    return Ok(ctx.Consulta.Include("Consulta").ToList());
                }
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }
               
        [HttpGet("consulta pelo Medico")]
        public IActionResult GetDoMedico()
        {
            try
            {
                using (SPMEDGROUPContext ctx = new SPMEDGROUPContext())
                {
                    return Ok(ctx.Consulta.Include("Consulta").ToList());
                }
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Put(Consulta consulta)
        {
            try
            {
                using (SPMEDGROUPContext ctx = new SPMEDGROUPContext())
                {
                    Consulta seConsultaExiste = ctx.Consulta.Find(consulta.Id);

                    if (seConsultaExiste == null)
                    {
                        return NotFound();
                    }

                    seConsultaExiste.Descricao = consulta.Descricao;
                    ctx.Consulta.Update(consulta);
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




        /*
         
         
         
         
         
       
        

        

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

                 
         
         */


    }
}
