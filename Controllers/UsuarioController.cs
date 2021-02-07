using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMiTesisUG.Entities;
using ApiMiTesisUG.Entities.MyBdContext;
using ApiMiTesisUG.Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiMiTesisUG.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {        

        private readonly ILogger<UsuarioController> _logger;
        private readonly MyBdContext _con;

        public UsuarioController(ILogger<UsuarioController> logger, MyBdContext con)
        {
            _logger = logger;
            _con = con;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("obtenerid/{usuario}")]
        public ActionResult<IUsuario> ObtenerId(string usuario)
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("obtener/{idcarrera}/{idrol}")]
        public ActionResult<IUsuario> Obtener(int idcarrera, int idrol)
        {
            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("crear")]
        public ActionResult<IHttpOption> Crear([FromBody] Usuarios usuario )
        {
                                    
            return Ok(new ActionResponse());
        }

        
    }
}
