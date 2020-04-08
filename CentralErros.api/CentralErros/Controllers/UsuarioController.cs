using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CentralErros.Controllers
{
    [ApiController]
    [Route("api/usuario/[controller]")]

    public class UsuarioController
    {

        private readonly UsuarioController _usuarios;

        public UsuarioController()
        {
            _usuarios = new UsuarioController();
        }

        [HttpGet]
        [Route("id:{id}")]
        public List<Usuario> PuxarUsuarios()
        {
            return _Usuarios;
        }

        [HttpPost]

        [Route("CriarUsuarios")]
        public List<Usuario> CadastrarUsuarios()
        {
            return _Usuarios;
        }

        [Route("Login")]


        [HttpPut]
        [Route("EditarUsuarios")]
        public List<Usuario> EditarUsuarios()
        {
            return _Usuarios;
        }
        [HttpDelete]
        [Route("DeletarUsuarios")]
        public List<Usuario> DeletarUsuarios()
        {
            return _Usuarios;
         }


    }
}