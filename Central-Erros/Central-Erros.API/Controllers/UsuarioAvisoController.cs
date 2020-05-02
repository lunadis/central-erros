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
    public class UsuarioAvisoController : ControllerBase
    {
        private readonly IUsuarioAvisoApp _app;

        public UsuarioAvisoController(IUsuarioAvisoApp app)
        {
            _app = app;
        }



        // GET: api/UsuarioAviso
        [HttpGet]
        public ActionResult<IEnumerable<UsuarioAvisoViewModel>> Get()
        {
            return Ok(_app.ListarTodos());
        }

        // GET: api/UsuarioAviso/5
        [HttpGet("{id}")]
        public ActionResult<UsuarioAvisoViewModel> Get(int? id)
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

        // POST: api/UsuarioAviso
        [HttpPost]
        public ActionResult<bool> Post([FromBody] UsuarioAvisoViewModel value)
        {
            if (_app.Incluir(value))
                return Ok();
            else
                return BadRequest();
        }

        // PUT: api/UsuarioAviso/5
        [HttpPut("{id}")]
        public ActionResult<UsuarioAvisoViewModel> Put([FromBody] UsuarioAvisoViewModel value)
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
