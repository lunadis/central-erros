using System;
using CentralErros.Domain.Models;
using CentralErros.Domain.Interfaces;

namespace CentralErros.Data.Repository
{
    public class AplicacaoRepository : RepositoryBase<Aplicacao>, IAplicacaoRepositorio
    {
        public AplicacaoRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
