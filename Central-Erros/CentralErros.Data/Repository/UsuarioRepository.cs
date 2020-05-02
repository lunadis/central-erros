using System;
using CentralErros.Domain.Models;
using CentralErros.Domain.Interfaces;

namespace CentralErros.Data.Repository
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
