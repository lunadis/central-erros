using System.Collections.Generic;

namespace CentralErros.Application.ViewModel
{
    public class AvisoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Visualizado { get; set; }

        public IEnumerable<UsuarioAvisoViewModel> UsuarioAvisos { get; set; }

    }
}
