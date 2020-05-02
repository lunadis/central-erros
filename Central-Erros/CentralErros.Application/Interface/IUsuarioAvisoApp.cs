using System.Collections.Generic;
using CentralErros.Application.ViewModel;

namespace CentralErros.Application.Interface
{
    public interface IUsuarioAvisoApp
    {
        void Incluir(UsuarioAvisoViewModel entity);
        void Alterar(UsuarioAvisoViewModel entity);
        UsuarioAvisoViewModel Selecionar(int id);
        void Deletar(int id);
        IEnumerable<UsuarioAvisoViewModel> ListarTodos();
    }
}