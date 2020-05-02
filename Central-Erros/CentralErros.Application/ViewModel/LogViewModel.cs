using System;

namespace CentralErros.Application.ViewModel
{
    public class LogViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }

        public int LevelId { get; set; }
        public TipoLogViewModel Tipo { get; set; }

        public int AplicacaoId { get; set; }
        public AplicacaoViewModel Aplicacao { get; set; }

    }
}
