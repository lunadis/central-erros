using System;
using CentralErros.Domain.Models;
using CentralErros.Domain.Interfaces;

namespace CentralErros.Data.Repository
{
    public class AvisoRepository : RepositoryBase<Aviso>, IAvisoRepositorio
    {
        public AvisoRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
