using CentralErros.Domain.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace CentralErros.Domain.Models
{
    public class Aplicacao : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public IEnumerable<Log> Logs { get; set; }
        public IEnumerable<UsuarioAplicacao> UsuarioAplicacaos { get; set; }
    }
}