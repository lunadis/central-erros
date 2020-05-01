using CentralErros.Domain.Interfaces;

namespace CentralErros.Domain.Models
{
    public class UsuarioAviso : IEntity
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int AvisoId { get; set; }
        public Aviso Aviso { get; set; }

    }
}