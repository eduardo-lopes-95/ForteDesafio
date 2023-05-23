using Forte.Ecommerce.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forte.Ecommerce.Infraestrutura.Data.Mapeamentos;

public class MapProduto : MapBase<ProdutoEntidade>
{
    public override void Configure(EntityTypeBuilder<ProdutoEntidade> builder)
    {
        base.Configure(builder);

        builder.ToTable("Produto");

        builder
            .Property(p => p.Nome)
            .HasColumnName("Nome")
            .HasMaxLength(100)
            .IsRequired();
       
        builder
            .Property(p => p.Descricao)
            .IsRequired()
            .HasColumnName("Descricao")
            .HasMaxLength(255);
        
        builder
            .Property(p => p.ValorProduto)
            .HasColumnName("ValorProduto")
            .HasMaxLength(20)
            .IsRequired();
    }
}
