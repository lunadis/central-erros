using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CentralErros.Domain.Models;

namespace CentralErros.Data.Map
{
    public class UsuarioAplicacaoMap : IEntityTypeConfiguration<UsuarioAplicacao>
    {
        public void Configure(EntityTypeBuilder<UsuarioAplicacao> builder)
        {
            builder.ToTable("UsuarioAplicacao");

            builder.HasKey(k => new { k.UsuarioId, k.AplicacaoId });

            builder.HasOne(x => x.Aplicacao)
                .WithMany(s => s.UsuarioAplicacaos)
                .HasForeignKey(x => x.AplicacaoId);

            builder.HasOne(x => x.Usuario)
                .WithMany(u => u.UsuarioAplicacaos)
                .HasForeignKey(x => x.UsuarioId);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
