﻿using Forte.Ecommerce.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forte.Ecommerce.Infraestrutura.Data.Mapeamentos;

public class MapFornecedor : MapBase<FornecedorEntidade>
{
    public override void Configure(EntityTypeBuilder<FornecedorEntidade> builder)
    {
        base.Configure(builder);

        builder.ToTable("Fornecedor");

        builder
            .Property(f => f.NomeCompleto)
            .IsRequired()
            .HasColumnName("NomeCompleto")
            .HasMaxLength(100);

        builder
            .Property(f => f.Email)
            .IsRequired()
            .HasColumnName("Email")
            .HasMaxLength(100);

        builder
            .Property(f => f.RazaoSocial)
            .IsRequired()
            .HasColumnName("RazaoSocial")
            .HasMaxLength(100);

        builder
            .Property(f => f.Cnpj)
            .IsRequired()
            .HasColumnName("Cnpj")
            .HasMaxLength(14);
       
        builder
            .Property(f => f.Uf)
            .IsRequired()
            .HasColumnName("Uf")
            .HasMaxLength(2);

    }
}
