using System;
using System.Collections.Generic;
using CentralErros.Application.Interface;
using CentralErros.Application.ViewModel;
using CentralErros.Application.ViewModel.TipoLog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CentralErros.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TipoLogController : ControllerBase
    {
        private readonly ITipoLogAplicacao _repo;
        public TipoLogController(ITipoLogAplicacao repo)
        {
            _repo = repo;
        }

        // GET: api/TipoLog
        [HttpGet]
        public IEnumerable<TipoLogViewModel> Get()
        {
            return _repo.ObterTodosTipoLogs();
        }

        // GET: api/TipoLog/5
        [HttpGet("{id}")]
        public TipoLogViewModel Get(int id)
        {
            return _repo.ObterTipoLogId(id);
        }

        [HttpGet("Ocorrencias")]
        public List<OcorrenciaTipoLogViewModel> GetOcorrenciasTipoLog()
        {
            return _repo.OcorrenciasTipoLog();
        }

        // POST: api/TipoLog
        [Authorize(Roles = "admin")]
        [HttpPost]
        public TipoLogViewModel Post([FromBody] CadastroTipoLogViewModel tipoLog)
        {
            var tipoLogViewModel = _repo.Incluir(tipoLog);
            return tipoLogViewModel;
        }

        // PUT: api/TipoLog/5
        [Authorize(Roles = "admin")]
        [HttpPut]
        public ActionResult<TipoLogViewModel> Put([FromBody] AlteraTipoLogViewModel tipoLog)
        {
            var tipoLogViewModel = _repo.Alterar(tipoLog);
            return tipoLogViewModel;
        }

        // DELETE: api/ApiWithActions/5
        [Authorize(Roles = "admin")]
        [HttpDelete("{id}")]
        public List<TipoLogViewModel> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.ObterTodosTipoLogs();
        }
    }
}
