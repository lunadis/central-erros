using System;
using System.Collections.Generic;
using System.Linq;
using CentralErros.Domain.Interfaces;

namespace CentralErros.Data.Repository
{
    public class RepositoryBase<T> : IRepositorioBase<T> where T : class, IEntity
    {
        protected readonly Contexto _contexto;

        public RepositoryBase(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Alterar(T entity)
        {
            _contexto.Set<T>().Update(entity);
            _contexto.SaveChanges();
        }

        public void Deletar(int id)
        {
            var entity = Selecionar(id);
            _contexto.Set<T>().Remove(entity);
            _contexto.SaveChanges();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        public void Incluir(T entity)
        {
            _contexto.Set<T>().Add(entity);
            _contexto.SaveChanges();
        }

        public IEnumerable<T> ListarTodos()
        {
            return _contexto.Set<T>().ToList();
        }

        public T Selecionar(int id)
        {
            return _contexto.Set<T>().FirstOrDefault(x => x.Id == id);
        }
    }
}
