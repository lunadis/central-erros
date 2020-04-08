using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CentralErros.Domain.Modelo;

namespace CentralErros.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario> 
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Login)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(x => x.DataCadastro)
                .HasColumnType("smalldatetime")
                .IsRequired();

            builder.Property(x => x.Ativo)
                .IsRequired();


        }
    }
}
