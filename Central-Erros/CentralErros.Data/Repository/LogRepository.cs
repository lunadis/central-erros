using System;
using CentralErros.Domain.Models;
using CentralErros.Domain.Interfaces;
using System.Collections.Generic;

namespace CentralErros.Data.Repository
{
    public class LogRepository : RepositoryBase<Log>, ILogRepositorio
    {
        public LogRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
