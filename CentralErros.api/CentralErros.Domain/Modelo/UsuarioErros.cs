using System;

namespace CentralErros.Domain.Modelo
{
    public class UsuarioErros
    {
        public int IdUsuario { get; set; }

        public Usuario Usuario { get; set; }

        public int IdErro { get; set; }

        public Erro Erro { get; set; }

    }
}
