using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CentralErros.Application.Interface;
using CentralErros.Application.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Central_Erros.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoLogController : ControllerBase
    {
        private readonly ITipoLogApp _app;

        public TipoLogController(ITipoLogApp app)
        {
            _app = app;
        }


        // GET: api/TipoLog
        [HttpGet]
        public ActionResult<IEnumerable<TipoLogViewModel>> Get()
        {
            return Ok(_app.ListarTodos());
        }

        // GET: api/TipoLog/5
        [HttpGet("{id}")]
        public ActionResult<TipoLogViewModel> Get(int? id)
        {
            if (id != null)
            {
                var Aviso = _app.Selecionar(id.Value);
                if (Aviso != null)
                    return Ok(Aviso);

                return NoContent();
            }
            else
            {
                return BadRequest(new { menssagem = "Requisição inválida" });
            }
        }

        // POST: api/TipoLog
        [HttpPost]
        public ActionResult<bool> Post([FromBody] TipoLogViewModel value)
        {
            if (_app.Incluir(value))
                return Ok();
            else
                return BadRequest();
        }

        // PUT: api/TipoLog/5
        [HttpPut("{id}")]
        public ActionResult<TipoLogViewModel> Put([FromBody] TipoLogViewModel value)
        {
            _app.Alterar(value);
            return Ok(_app.Selecionar(value.Id));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (_app.Deletar(id))
                return Ok(true);
            else
                return BadRequest(false);
        }
    }
}
