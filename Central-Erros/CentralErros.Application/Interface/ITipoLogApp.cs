using System.Collections.Generic;
using CentralErros.Application.ViewModel;

namespace CentralErros.Application.Interface
{
    public interface ITipoLogApp
    {
        void Incluir(TipoLogViewModel entity);
        void Alterar(TipoLogViewModel entity);
        TipoLogViewModel Selecionar(int id);
        void Deletar(int id);
        IEnumerable<TipoLogViewModel> ListarTodos();
    }




}
