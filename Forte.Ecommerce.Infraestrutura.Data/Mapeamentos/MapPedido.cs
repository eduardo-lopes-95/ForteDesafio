﻿using Forte.Ecommerce.Dominio.Entidades;
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
            .HasMaxLength(255);

        builder
            .Property(p => p.QuantidadeProdutos)
            .IsRequired()
            .HasColumnName("QuantidadeProdutos")
            .HasMaxLength(255);

        builder
            .Property(p => p.ValorTotalPedido)
            .IsRequired()
            .HasColumnName("ValorTotalPedido")
            .HasMaxLength(255);

        builder
            .HasMany(p => p.Produtos)
            .WithOne(pe => pe.Pedido)
            .HasForeignKey(pe => pe.PedidoId);
    }
}
