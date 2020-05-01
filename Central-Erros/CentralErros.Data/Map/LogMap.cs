using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CentralErros.Domain.Models;

namespace CentralErros.Data.Map
{
    public class LogMap : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.ToTable("Log");

            builder.HasKey(x => new { x.Id, x.AplicacaoId });

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(x => x.Data)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(i => i.Id)
                .UseIdentityColumn();
        }
    }
}
