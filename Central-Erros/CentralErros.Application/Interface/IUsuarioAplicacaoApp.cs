using System.Collections.Generic;
using CentralErros.Application.ViewModel;

namespace CentralErros.Application.Interface
{
    public interface IUsuarioAplicacaoApp
    {
        bool Incluir(UsuarioAplicacaoViewModel entity);
        void Alterar(UsuarioAplicacaoViewModel entity);
        UsuarioAplicacaoViewModel Selecionar(int id);
        bool Deletar(int id);
        IEnumerable<UsuarioAplicacaoViewModel> ListarTodos();
    }
}
