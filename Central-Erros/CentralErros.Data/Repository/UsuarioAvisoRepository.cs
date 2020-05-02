using System;
using CentralErros.Domain.Models;
using CentralErros.Domain.Interfaces;

namespace CentralErros.Data.Repository
{
    public class UsuarioAvisoRepository : RepositoryBase<UsuarioAviso>, IUsuarioAvisoRepositorio
    {
        public UsuarioAvisoRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
