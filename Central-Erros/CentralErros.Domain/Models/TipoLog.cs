using CentralErros.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace CentralErros.Domain.Models
{
    public class TipoLog : IEntity
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<Log> Logs { get; set; }
    }




}
