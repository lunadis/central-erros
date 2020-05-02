using System.Collections.Generic;
using CentralErros.Application.ViewModel;

namespace CentralErros.Application.Interface
{
    public interface ITipoLogApp
    {
        bool Incluir(TipoLogViewModel entity);
        void Alterar(TipoLogViewModel entity);
        TipoLogViewModel Selecionar(int id);
        bool Deletar(int id);
        IEnumerable<TipoLogViewModel> ListarTodos();
    }




}
