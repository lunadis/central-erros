using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using CentralErros.Application.ViewModel;

namespace CentralErros.Application.Interface
{
    public interface IUsuarioAvisoApp
    {
        bool Incluir(UsuarioAvisoViewModel entity);
        void Alterar(UsuarioAvisoViewModel entity);
        UsuarioAvisoViewModel Selecionar(int id);
        bool Deletar(int id);
        IEnumerable<UsuarioAvisoViewModel> ListarTodos();

    }
}