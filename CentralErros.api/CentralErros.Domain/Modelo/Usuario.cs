using System;
using System.Collections.Generic;
using System.Text;

namespace CentralErros.Domain.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public List<UsuarioErros> UsuarioErros { get; set; }
    }
}
