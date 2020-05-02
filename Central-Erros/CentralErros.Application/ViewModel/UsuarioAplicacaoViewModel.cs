namespace CentralErros.Application.ViewModel
{
    public class UsuarioAplicacaoViewModel
    {
        public int Id { get; set; }
        public bool Permissao { get; set; }


        public int UsuarioId { get; set; }
        public UsuarioViewModel Usuario { get; set; }

        public int AplicacaoId { get; set; }
        public AplicacaoViewModel Aplicacao { get; set; }
    }
}
