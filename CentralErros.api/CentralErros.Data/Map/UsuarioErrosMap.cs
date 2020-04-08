using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CentralErros.Domain.Modelo;
    
namespace CentralErros.Data.Map
{
    public class UsuarioErrosMap : IEntityTypeConfiguration<UsuarioErros>
    {
        public void Configure(EntityTypeBuilder<UsuarioErros> builder)
        {
            builder.ToTable("UsuarioErros");

            builder.ToTable("UsuarioErros");

            builder.HasKey(k => new {k.IdErro, k.IdUsuario});

            builder.HasOne(e => e.Erro)
                .WithMany(er => er.UsuarioErros)
                .HasForeignKey(e => e.IdErro);

            builder.HasOne(u => u.Usuario)
                .WithMany(us => us.UsuarioErros)
                .HasForeignKey(u => u.IdUsuario);
        }
    }
}
