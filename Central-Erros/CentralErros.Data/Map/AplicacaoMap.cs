using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CentralErros.Domain.Models;

namespace CentralErros.Data.Map
{
    public class AplicacaoMap : IEntityTypeConfiguration<Aplicacao>
    {
        public void Configure(EntityTypeBuilder<Aplicacao> builder)
        {
            builder.ToTable("Aplicacao");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.HasMany<Log>(x => x.Logs)
                .WithOne(a => a.Aplicacao)
                .HasForeignKey(a => a.AplicacaoId);
           
        }
    }
}
