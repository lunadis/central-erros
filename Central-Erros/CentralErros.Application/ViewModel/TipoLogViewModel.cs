using System.Collections.Generic;

namespace CentralErros.Application.ViewModel
{
    public class TipoLogViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<LogViewModel> Logs { get; set; }
    }




}
