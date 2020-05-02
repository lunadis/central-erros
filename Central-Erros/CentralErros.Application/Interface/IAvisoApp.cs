using System.Collections.Generic;
using CentralErros.Application.ViewModel;

namespace CentralErros.Application
{
    public interface IAvisoApp {
        void Incluir(AvisoViewModel entity);
        void Alterar(AvisoViewModel entity);
        AvisoViewModel Selecionar(int id);
        void Deletar(int id);
        IEnumerable<AvisoViewModel> ListarTodos();
    }

}
