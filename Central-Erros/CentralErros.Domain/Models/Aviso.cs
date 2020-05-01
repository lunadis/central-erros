using CentralErros.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CentralErros.Domain.Models
{
    public class Aviso : IEntity
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Visualizado { get; set; }

        public IEnumerable<UsuarioAviso> UsuarioAvisos { get; set; }

    }
}
