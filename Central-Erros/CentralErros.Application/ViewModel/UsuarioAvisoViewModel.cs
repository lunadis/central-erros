namespace CentralErros.Application.ViewModel
{
    public class UsuarioAvisoViewModel
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public UsuarioViewModel Usuario { get; set; }

        public int AvisoId { get; set; }
        public AvisoViewModel Aviso { get; set; }

    }
}