using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext 
    {
       

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                                                 new FormaPagamento() {
                                                     Id =1,
                                                     Nome ="Boleto",
                                                     Descricao ="Forma de pagamento boleto"},
                                                 new FormaPagamento()
                                                 {
                                                     Id = 2,
                                                     Nome = "Cartao de credito",
                                                     Descricao = "Forma de pagamento Cartão de crédito"
                                                 },
                                                 new FormaPagamento()
                                                 {
                                                     Id = 3,
                                                     Nome = "Deposito",
                                                     Descricao = "Forma de pagamento deposito"
                                                 }
                                                 );


            base.OnModelCreating(modelBuilder);
        }
    }
}
