using Microsoft.EntityFrameworkCore;

namespace Projeto_Otilio.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options){}
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Vendedor>? Vendedores { get; set; }
        public DbSet<Transportadora>? Transportadoras { get; set; }
        public DbSet<FormaDePagamento>? TiposDePagamento { get; set; }
        public DbSet<PagamentoComCartao>? PagamentosComCartao { get; set; }
        public DbSet<PagamentoComCheque>? PagamentosComBoleto { get; set; }
        public DbSet<Marca>? Marcas { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
        public DbSet<Item>? Items { get; set; }
        public DbSet<NotaDeVenda>? NotasDeVendas { get; set; }
        public DbSet<Pagamento>? Pagamento { get; set; }
    }
}