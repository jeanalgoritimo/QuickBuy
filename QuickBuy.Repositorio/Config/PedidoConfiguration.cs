using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder
               .Property(p => p.Cep)
               .IsRequired()
               .HasMaxLength(50)
               .HasColumnType("nvarchar");

            builder
              .Property(p => p.Cidade)
              .IsRequired()
              .HasMaxLength(50)
              .HasColumnType("nvarchar");

            builder
              .Property(p => p.Endereco)
              .IsRequired()
              .HasMaxLength(100)
              .HasColumnType("nvarchar");


            builder
              .Property(p => p.Estado)
              .IsRequired()
              .HasMaxLength(50)
              .HasColumnType("nvarchar");

            builder
              .Property(p => p.NumeroEndereco)
              .IsRequired()
              .HasMaxLength(20)
              .HasColumnType("nvarchar");

            builder
             .Property(p => p.DataPedido)
             .IsRequired();

            builder
             .Property(p => p.DataPrevisaoEntrega)
             .IsRequired();
        }
    }
}
