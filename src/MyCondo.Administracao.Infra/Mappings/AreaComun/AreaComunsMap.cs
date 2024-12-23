using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCondo.Administracao.Domain.Entities.AreaComun;

namespace MyCondo.Administracao.Infra.Mappings.AreaComun;

public class AreaComunsMap : IEntityTypeConfiguration<AreaComuns>
{
    public void Configure(EntityTypeBuilder<AreaComuns> builder)
    {
        builder.ToTable(nameof(AreaComuns));
        builder.HasKey(x => x.Id);

        builder.Property(p => p.Id).ValueGeneratedOnAdd();

        builder.Property(p => p.Nome)
            .IsRequired()
            .HasColumnType("varchar(150)");

        builder.Property(p => p.Descricao)
            .IsRequired()
            .HasColumnType("varchar(500)");

        builder.Property(p => p.DataCriacao)
            .HasDefaultValue(DateTime.Now)
            .HasColumnType("Date");

        builder.Property(p => p.DataAtualizado)
            .HasColumnType("Date");

        builder.Property(p => p.ValorLocacao)
            .HasDefaultValue(0);

        builder.Property(p => p.ExcluirBoletoAoCancelar)
            .HasDefaultValue(true);

        builder.Property(p => p.LiberarBoletoAtoReserva)
            .HasDefaultValue(true);

        builder.Property(p => p.PagarBoletoAposReserva)
            .HasDefaultValue(true);

        builder.Property(p => p.DiasAntecedenciaLocacao)
            .HasDefaultValue(5);

        builder.HasOne(b => b.Condominios)
            .WithMany(c => c.AreaComuns)
            .HasForeignKey(b => b.CondominiosId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
