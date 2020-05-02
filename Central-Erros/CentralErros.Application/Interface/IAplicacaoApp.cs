using System.Collections.Generic;
using CentralErros.Application.ViewModel;

namespace CentralErros.Application.Interface
{
    public interface IAplicacaoApp 
    {
        void Incluir(AplicacaoViewModel entity);
        void Alterar(AplicacaoViewModel entity);
        AplicacaoViewModel Selecionar(int id);
        void Deletar(int id);
        IEnumerable<AplicacaoViewModel> ListarTodos();

    }
}