using CentralErros.Domain.Modelo;
using System;
using System.Collections.Generic;

namespace CentralErros.Domain.Repositorio
{
    public interface ITipoLogRepositorio : IRepositorioBase<TipoLog>
    {
        List<TipoLog> ObterTodosTipoLogs();
        TipoLog ObterTipoLogId(int id);
        Object OcorrenciasTipoLog();
    }
}
