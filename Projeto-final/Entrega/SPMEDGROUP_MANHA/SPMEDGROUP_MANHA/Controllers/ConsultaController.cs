using Microsoft.AspNetCore.Authorization;
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

    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ConsultaController : ControllerBase
    {

        private IConsultaRepository consultaRepository;

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
        //[Authorize(Roles = "3, 1")]
        public IActionResult Put(Consulta consulta)
        {

            try
            {
                using (SPMEDGROUPContext ctx = new SPMEDGROUPContext())
                {

                    using (var context = new SPMEDGROUPContext())
                    {
                        var std = context.Consulta.Find(consulta.Id);
                        std.Descricao = consulta.Descricao;
                        context.SaveChanges();
                    }
                }
                return Ok();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.Message);
            }
        }
            

/**/}
}
