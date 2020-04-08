using Microsoft.EntityFrameworkCore;
using CentralErros.Domain.Modelo;
using CentralErros.Data.Map;


namespace CentralErros.Data
{
    class CentralErroContext : DbContext 
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Erro> Erros { get; set; }

        public DbSet<UsuarioErros> UsuarioErros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1401;Initial Catalog=CentralErro;Persist Security Info=True;User ID=SA;Password=jfi72n6y@;MultipleActiveResultSets=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new ErroMap());
            modelBuilder.ApplyConfiguration(new UsuarioErrosMap());

            base.OnModelCreating(modelBuilder);

        }
    }
}
