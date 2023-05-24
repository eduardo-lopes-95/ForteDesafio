using Forte.Ecommerce.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forte.Ecommerce.Infraestrutura.Data.Mapeamentos;

public class MapBase<T> : IEntityTypeConfiguration<T> where T : Entidade
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
        builder.Property(c => c.CriadoEm).IsRequired().HasColumnName("CriadoEm");
    }
}
