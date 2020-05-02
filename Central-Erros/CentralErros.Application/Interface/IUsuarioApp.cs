using System.Collections.Generic;
using CentralErros.Application.ViewModel;

namespace CentralErros.Application.Interface
{
    public interface IUsuarioApp 
    {
        void Incluir(UsuarioViewModel entity);
        void Alterar(UsuarioViewModel entity);
        UsuarioViewModel Selecionar(int id);
        void Deletar(int id);
        IEnumerable<UsuarioViewModel> ListarTodos();
    }
}