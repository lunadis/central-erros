using System;
using CentralErros.Domain.Models;
using CentralErros.Domain.Interfaces;

namespace CentralErros.Data.Repository
{
    public class UsuarioAplicacaoRepository : RepositoryBase<UsuarioAplicacao>, IUsuarioAplicacaoRepositorio
    {
        public UsuarioAplicacaoRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
