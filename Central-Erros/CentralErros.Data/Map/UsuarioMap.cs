using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CentralErros.Domain.Models;

namespace CentralErros.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(k => k.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Senha)
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}
