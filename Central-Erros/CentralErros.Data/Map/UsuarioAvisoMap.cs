using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CentralErros.Domain.Models;

namespace CentralErros.Data.Map
{
    public class UsuarioAvisoMap : IEntityTypeConfiguration<UsuarioAviso>
    {
        public void Configure(EntityTypeBuilder<UsuarioAviso> builder)
        {
            builder.ToTable("UsuarioAviso");

            builder.HasKey(k => new { k.AvisoId, k.UsuarioId});

            builder.HasOne(x => x.Usuario)
                .WithMany(i => i.UsuarioAvisos)
                .HasForeignKey(x => x.UsuarioId);

            builder.HasOne(x => x.Aviso)
                .WithMany(i => i.UsuarioAvisos)
                .HasForeignKey(x => x.AvisoId);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
