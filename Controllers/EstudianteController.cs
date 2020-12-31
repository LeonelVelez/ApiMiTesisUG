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
    public class EstudianteController : ControllerBase
    {        

        private readonly ILogger<EstudianteController> _logger;

        public EstudianteController(ILogger<EstudianteController> logger)
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
        
    }
}
