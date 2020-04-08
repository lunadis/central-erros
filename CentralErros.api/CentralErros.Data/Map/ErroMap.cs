using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CentralErros.Domain.Modelo;

namespace CentralErros.Data.Map
{
    public class ErroMap : IEntityTypeConfiguration<Erro>
    {
        public void Configure(EntityTypeBuilder<Erro> builder)
        {
            builder.ToTable("Erro");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Status)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(300)");
        }
    }
}
