using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CentralErros.Domain.Models;

namespace CentralErros.Data.Map
{
    public class TipoLogMap : IEntityTypeConfiguration<TipoLog>
    {
        public void Configure(EntityTypeBuilder<TipoLog> builder)
        {
            builder.ToTable("TipoLog");

            builder.HasKey(x => x.Id);

            builder.Property(d => d.Descricao)
                .HasColumnType("varchar(255)")
                .IsRequired();
        }
    }
}
