using System.Collections.Generic;
using CentralErros.Application.ViewModel;

namespace CentralErros.Application.Interface
{
    public interface IAplicacaoApp 
    {
        bool Incluir(AplicacaoViewModel entity);
        void Alterar(AplicacaoViewModel entity);
        AplicacaoViewModel Selecionar(int id);
        bool Deletar(int id);
        IEnumerable<AplicacaoViewModel> ListarTodos();

    }
}