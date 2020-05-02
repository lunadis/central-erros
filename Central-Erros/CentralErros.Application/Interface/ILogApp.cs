using System.Collections.Generic;
using CentralErros.Application.ViewModel;

namespace CentralErros.Application.Interface
{
    public interface ILogApp
    {
        void Incluir(LogViewModel entity);
        void Alterar(LogViewModel entity);
        LogViewModel Selecionar(int id);
        void Deletar(int id);
        IEnumerable<LogViewModel> ListarTodos();

    }
}
