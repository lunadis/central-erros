using System;
using System.Collections.Generic;
using System.Text;

namespace CentralErros.Domain.Modelo
{
    public class Erro
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Status { get; set; }

        public string Descricao { get; set; }

        public List<UsuarioErros> UsuarioErros { get; set; }
    }
}
