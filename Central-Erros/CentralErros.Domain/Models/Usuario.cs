using CentralErros.Domain.Interfaces;
using System.Collections.Generic;

namespace CentralErros.Domain.Models
{
    public class Usuario : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int NivelUsuario { get; set; }

        public IEnumerable<UsuarioAviso> UsuarioAvisos { get; set; }
        public IEnumerable<UsuarioAplicacao> UsuarioAplicacaos { get; set; }
    }
}