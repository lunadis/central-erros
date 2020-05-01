using System;
using System.Collections.Generic;
using System.Text;

namespace CentralErros.Domain.Interfaces {
        public interface IRepositorioBase<T> : IDisposable where T : class,IEntity{

        void Incluir(T entity);
        void Alterar(T entity);
        T Selecionar(int id);
        void Deletar(int id);
        IEnumerable<T> ListarTodos(); 
    }
}
