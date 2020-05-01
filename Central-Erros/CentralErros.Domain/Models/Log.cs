using CentralErros.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CentralErros.Domain.Models
{
    public class Log : IEntity
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }

        public int LevelId { get; set; }
        public TipoLog Tipo { get; set; }

        public int AplicacaoId { get; set; }
        public Aplicacao Aplicacao { get; set; }

    }
}
