using System.Collections.Generic;
using CentralErros.Application.ViewModel;

namespace CentralErros.Application
{
    public interface IAvisoApp {
        bool Incluir(AvisoViewModel entity);
        void Alterar(AvisoViewModel entity);
        AvisoViewModel Selecionar(int id);
        bool Deletar(int id);
        IEnumerable<AvisoViewModel> ListarTodos();
    }

}
