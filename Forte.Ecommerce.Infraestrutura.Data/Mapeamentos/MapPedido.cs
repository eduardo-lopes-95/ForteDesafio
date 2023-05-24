using Forte.Ecommerce.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forte.Ecommerce.Infraestrutura.Data.Mapeamentos;

public class MapPedido : MapBase<PedidoEntidade>
{
    public override void Configure(EntityTypeBuilder<PedidoEntidade> builder)
    {
        base.Configure(builder);
        
        builder.ToTable("Pedido");

        builder
            .Property(p => p.Codigo)
            .IsRequired()
            .HasColumnName("CodigoProduto")
            .HasMaxLength(10);

        builder
            .Property(p => p.QuantidadeProdutos)
            .IsRequired()
            .HasColumnName("QuantidadeProdutos")
            .HasMaxLength(10);

        builder
            .Property(p => p.ValorTotalPedido)
            .IsRequired()
            .HasColumnName("ValorTotalPedido")
            .HasMaxLength(255);
    }
}
