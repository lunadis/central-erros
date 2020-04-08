using CentralErros.Domain.Modelo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentralErros.Controllers
{
    [Route("api/erro/[controller]")]
    [ApiController]
    public class ErroController
    {
        private readonly ErroController _erro;

        public ErroController()
        {
            _erro = new ErroController();
        }

        [HttpPost]
        public List<Erro> Post([FromBody] Erro value)
        {
            return _erro.Adicionar(value);
        }

        [HttpGet]
        public List<Erro> Get()
        {
            return _erro.ListarTodos(value);
        }

        [HttpGet]
        [Route("api/erro/[controller]/{id}")]
        public List<Erro> Editar(int id, [FromBody] Erro value)
        {
            return _erro.EditarErro(id, value);
        }

        [HttpDelete]
        [Route("api/erro/[controller]/{id}")]
        public List<Erro> Editar(int id)
        {
            return _erro.Deleter(id);
        }

        [HttpGet]
        [Route("api/erro/[controller]/{id}")]
        public Erro Detalhar(int id)
        {
            return _erro.findById(id);
        }

    }
}
