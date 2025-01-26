using Microsoft.EntityFrameworkCore;
using SKEstoqueAPI.Data.Models;

namespace SKEstoqueAPI.Data
{
    public class SKEstoqueContext : DbContext
    {
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Caracteristica> Caracteristicas { get; set; }
        public SKEstoqueContext(DbContextOptions<SKEstoqueContext> options)
            : base(options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasMany(p => p.Caracteristicas)
                .WithOne(c => c.Produto)
                .HasForeignKey(c => c.ProdutoId)
                .HasPrincipalKey(p => p.Id);

        }
    }
}
