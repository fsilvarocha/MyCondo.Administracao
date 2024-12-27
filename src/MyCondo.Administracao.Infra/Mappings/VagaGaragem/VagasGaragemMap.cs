using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCondo.Administracao.Domain.Entities.VagaGaragem;

namespace MyCondo.Administracao.Infra.Mappings.VagaGaragem;

public class VagasGaragemMap : IEntityTypeConfiguration<VagasGaragem>
{
    public void Configure(EntityTypeBuilder<VagasGaragem> builder)
    {
        builder.ToTable(nameof(VagasGaragem));

        builder.HasKey(x => x.Id);

        builder.Property(p => p.DataCriacao)
            .HasDefaultValue(DateTime.Now)
            .HasColumnType("Date");

        builder.Property(p => p.DataAtualizado)
            .HasColumnType("Date");

        builder.Property(p => p.Nome)
            .HasColumnType("varchar(50)")
            .IsRequired();

        builder.HasOne(b => b.Apartamentos)
            .WithMany(a => a.VagasGaragem)
            .HasForeignKey(b => b.ApartamentoId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
