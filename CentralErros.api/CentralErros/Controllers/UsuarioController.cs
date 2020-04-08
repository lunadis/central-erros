using CentralErros.Domain.Modelo;
using CentralErros.Domain.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CentralErros.Controllers
{
    [ApiController]
    [Route("api/usuario/[controller]/")]
    public class UsuarioController
    {

        private UsuarioRepositorio _Usuario;

        public UsuarioController()
        {
            _Usuario = new UsuarioRepositorio();
        }

        [HttpGet]
        [Route("id:{id}")]
        public List<Usuario> PuxarUsuarios()
        {
            return _Usuario;
        }

        [HttpPost]
        [Route("CriarUsuarios")]
        public List<Usuario> CadastrarUsuarios()
        {
            return _Usuario;
        }

        [HttpPost]
        [Route("Login")]
        public string Login([FromBody] Usuario usuario )
        {
            return "";
        }


        [HttpPut]
        [Route("EditarUsuarios")]
        public List<Usuario> EditarUsuarios()
        {
            return _Usuario;
        }
        [HttpDelete]
        [Route("DeletarUsuarios")]
        public List<Usuario> DeletarUsuarios()
        {
            return _Usuario;
        }


    }
}