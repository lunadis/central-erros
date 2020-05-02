using System.Collections.Generic;
using CentralErros.Application.ViewModel;

namespace CentralErros.Application.Interface
{
    public interface IUsuarioApp 
    {
        bool Incluir(UsuarioViewModel entity);
        void Alterar(UsuarioViewModel entity);
        UsuarioViewModel Selecionar(int id);
        bool Deletar(int id);
        IEnumerable<UsuarioViewModel> ListarTodos();
    }
}