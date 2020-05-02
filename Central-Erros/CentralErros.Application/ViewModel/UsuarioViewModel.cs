using System.Collections.Generic;

namespace CentralErros.Application.ViewModel
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int NivelUsuario { get; set; }

        public IEnumerable<UsuarioAvisoViewModel> UsuarioAvisos { get; set; }
        public IEnumerable<UsuarioAplicacaoViewModel> UsuarioAplicacaos { get; set; }
    }
}