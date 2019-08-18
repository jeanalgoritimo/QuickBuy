﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder
              .Property(p => p.Descricao)
              .IsRequired()
              .HasMaxLength(150)
              .HasColumnType("nvarchar");


            builder
             .Property(p => p.Preco)
             .IsRequired();
        }


    }
}
