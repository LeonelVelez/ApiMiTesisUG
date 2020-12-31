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
    public class TesisController : ControllerBase
    {        

        private readonly ILogger<TesisController> _logger;

        public TesisController(ILogger<TesisController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("obtenerid/{id}")]
        public ActionResult<Profesor> ObtenerId(int id)
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("obtener/{idcarrera}/{idestudiante}")]
        public ActionResult<Profesor> Obtener(int idcarrera, int idestudiante)
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("crear")]
        public ActionResult<Profesor> Crear([FromBody]int tesis)
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("actualizar")]
        public ActionResult<Profesor> Actualizar([FromBody]int tesis)
        {
            return Ok();
        }

        
    }
}
