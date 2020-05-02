using System.Collections.Generic;
using CentralErros.Application.ViewModel;

namespace CentralErros.Application.Interface
{
    public interface ILogApp
    {
        bool Incluir(LogViewModel entity);
        void Alterar(LogViewModel entity);
        LogViewModel Selecionar(int id);
        bool Deletar(int id);
        IEnumerable<LogViewModel> ListarTodos();

    }
}
