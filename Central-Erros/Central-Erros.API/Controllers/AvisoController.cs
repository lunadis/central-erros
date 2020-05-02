using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using CentralErros.Application;
using CentralErros.Application.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Central_Erros.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvisoController : ControllerBase
    {
        private readonly IAvisoApp _app;

        public AvisoController(IAvisoApp app)
        {
            _app = app;
        }

        // GET: api/Aviso
        [HttpGet]
        public ActionResult<IEnumerable<AvisoViewModel>> Get()
        {
            var AvisoLista = _app.ListarTodos();
            if (AvisoLista.Count() == 0)
                return NoContent();

            return Ok(AvisoLista);

        }

        // GET: api/Aviso/5
        [HttpGet("{id}")]
        public ActionResult<AvisoViewModel> Get(int? id)
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

        // POST: api/Aviso
        [HttpPost]
        public ActionResult<bool> Post([FromBody] AvisoViewModel entity)
        {
            if (_app.Incluir(entity))
                return Ok();
            else
                return BadRequest();
        }

        // PUT: api/Aviso/5
        [HttpPut("{id}")]
        public ActionResult<AvisoViewModel> Put([FromBody] AvisoViewModel entity)
        {
            _app.Alterar(entity);
            return Ok(_app.Selecionar(entity.Id));
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
