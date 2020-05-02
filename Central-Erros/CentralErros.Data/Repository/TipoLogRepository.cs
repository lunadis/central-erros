using System;
using CentralErros.Domain.Models;
using CentralErros.Domain.Interfaces;

namespace CentralErros.Data.Repository
{
    public class TipoLogRepository : RepositoryBase<TipoLog>, ITipoLogRepositorio
    {
        public TipoLogRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
