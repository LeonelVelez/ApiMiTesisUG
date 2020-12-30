using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMiTesisUG.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiMiTesisUG.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class ProfesorController : ControllerBase
    {        

        private readonly ILogger<ProfesorController> _logger;

        public ProfesorController(ILogger<ProfesorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("obtener")]
        public ActionResult<Profesor> Obtener(int id)
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("obtener/{idcarrera}")]
        public ActionResult<Profesor> ObtenerCarrera(int idcarrera)
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("obtener/{idestado}")]
        public ActionResult<Profesor> ObtenerEstadoTesis(int idestado)
        {
            return Ok();
        }
        
    }
}
