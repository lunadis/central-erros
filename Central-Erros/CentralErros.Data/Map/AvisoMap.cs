using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CentralErros.Domain.Models;

namespace CentralErros.Data.Map
{
    public class AvisoMap : IEntityTypeConfiguration<Aviso>
    {
        public void Configure(EntityTypeBuilder<Aviso> builder)
        {
            builder.ToTable("Aviso");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(x => x.Visualizado)
                .HasColumnType("TINYINT");
        }
    }
}
