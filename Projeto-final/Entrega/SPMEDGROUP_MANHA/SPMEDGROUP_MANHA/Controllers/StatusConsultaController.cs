using Microsoft.AspNetCore.Mvc;
using SPMEDGROUP_MANHA.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMEDGROUP_MANHA.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class StatusConsultaController : ControllerBase
    {

        [HttpPut]
        public IActionResult Put(StatusConsulta status)
        {
            try
            {
                using (SPMEDGROUPContext ctx = new SPMEDGROUPContext())
                {
                    StatusConsulta seStatusExiste = ctx.StatusConsulta.Find(status.Id);

                    if (seStatusExiste == null)
                    {
                        return NotFound();
                    }

                    seStatusExiste.Status = status.Status;
                    ctx.StatusConsulta.Update(status);
                    ctx.SaveChanges();
                }

                return Ok();
            }
            catch (Exception exc)
            {
                return BadRequest();
            }
        }
    }
}

