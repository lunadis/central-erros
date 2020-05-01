using CentralErros.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CentralErros.Domain.Models
{
    public class UsuarioAplicacao : IEntity
    {
        public int Id { get; set; }
        public bool Permissao { get; set; }


        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int AplicacaoId { get; set; }
        public Aplicacao Aplicacao { get; set; }
    }
}
