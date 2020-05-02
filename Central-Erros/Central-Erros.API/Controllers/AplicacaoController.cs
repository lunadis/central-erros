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
    public class AplicacaoController : ControllerBase
    {
        private readonly IAplicacaoApp _app;

        public AplicacaoController(IAplicacaoApp app)
        {
            _app = app;
        }

        // GET: api/Aplicacao
        [HttpGet]
        public ActionResult<IEnumerable<AplicacaoViewModel>> Get()
        {
            return Ok(_app.ListarTodos());
        }

        // GET: api/Aplicacao/5
        [HttpGet("{id}")]
        public ActionResult<AplicacaoViewModel> Get(int? id)
        {
            if (id != null)
            {
                var aplicacao = _app.Selecionar(id.Value);
                if (aplicacao != null)
                    return Ok(aplicacao);

                return NoContent();
            }
            else
            {
                return BadRequest(new { menssagem = "Requisição inválida" });
            }
        }

        // POST: api/Aplicacao
        [HttpPost]
        public ActionResult<bool> Post([FromBody] AplicacaoViewModel entity)
        {

            if (_app.Incluir(entity))
                return Ok();
            else
                return BadRequest();
        }

        // PUT: api/Aplicacao/5
        [HttpPut("{id}")]
        public ActionResult<AplicacaoViewModel> Put([FromBody] AplicacaoViewModel entity)
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
