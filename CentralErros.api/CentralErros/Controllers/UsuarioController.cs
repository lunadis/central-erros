using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CentralErros.Controllers
{
    [ApiController]
    [Route("api/usuario/[controller]")]

    public class UsuarioController
    {

        private static List<Usuario> Usuarios = new List<Usuario>();

        [HttpGet]
        [Route("id:{id}")]
        public List<Usuario> PuxarUsuarios()
        {
            return Usuarios;
        }

        [HttpPost]

        [Route("CriarUsuarios")]
        public List<Usuario> CadastrarUsuarios()
        {
            return Usuarios;
        }

        [Route("Login")]


        [HttpPut]
        [Route("EditarUsuarios")]
        public List<Usuario> EditarUsuarios()
        {
            return Usuarios;
        }
        [HttpDelete]
        [Route("DeletarUsuarios")]
        public List<Usuario> DeletarUsuarios()
        {
            return Usuarios
         }


    }
}