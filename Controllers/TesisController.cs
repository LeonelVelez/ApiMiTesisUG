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
        public ActionResult<Tesis> ObtenerId(int id)
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("obtener/{idcarrera}")]
        public ActionResult<Tesis> Obtener(int idcarrera)
        {
            return Ok();
        }

        
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("obtenerusuario/{idusuario}")]
        public ActionResult<Tesis> ObtenerUsuario(int idusuario)
        {
            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("crear")]
        public ActionResult<Tesis> Crear([FromBody]Tesis tesis)
        {
            
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("actualizar")]
        public ActionResult<Tesis> Actualizar([FromBody]int tesis)
        {
            
            return Ok();
        }

        
    }
}
