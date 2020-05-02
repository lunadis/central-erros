using System.Collections.Generic;
using CentralErros.Application.ViewModel;

namespace CentralErros.Application.Interface
{
    public interface IUsuarioAplicacaoApp
    {
        void Incluir(UsuarioAplicacaoViewModel entity);
        void Alterar(UsuarioAplicacaoViewModel entity);
        UsuarioAplicacaoViewModel Selecionar(int id);
        void Deletar(int id);
        IEnumerable<UsuarioAplicacaoViewModel> ListarTodos();
    }
}
