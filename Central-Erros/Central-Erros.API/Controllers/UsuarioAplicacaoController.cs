using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CentralErros.Application.Interface;
using CentralErros.Application.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;

namespace Central_Erros.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioAplicacaoController : ControllerBase
    {
        private readonly IUsuarioAplicacaoApp _app;

        public UsuarioAplicacaoController(IUsuarioAplicacaoApp app)
        {
            _app = app;
        }



        // GET: api/UsuarioAplicacao
        [HttpGet]
        public ActionResult<IEnumerable<UsuarioAplicacaoViewModel>> Get()
        {
            return Ok(_app.ListarTodos());
        }

        // GET: api/UsuarioAplicacao/5
        [HttpGet("{id}")]
        public ActionResult<UsuarioAplicacaoViewModel> Get(int? id)
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

        // POST: api/UsuarioAplicacao
        [HttpPost]
        public ActionResult<bool> Post([FromBody] UsuarioAplicacaoViewModel value)
        {
            if (_app.Incluir(value))
                return Ok();
            else
                return BadRequest();
        }

        // PUT: api/UsuarioAplicacao/5
        [HttpPut("{id}")]
        public ActionResult<UsuarioAplicacaoViewModel> Put([FromBody] UsuarioAplicacaoViewModel value)
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
