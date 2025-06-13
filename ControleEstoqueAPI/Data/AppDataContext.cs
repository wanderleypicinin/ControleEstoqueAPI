using Microsoft.EntityFrameworkCore;
using ControleEstoqueAPI.Models;
namespace ControleEstoqueAPI.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }
        public DbSet<Produto> Produtos => Set<Produto>();
        public DbSet<Movimentação> Movimentacoes =>Set<Movimentação>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
               .HasIndex(p => p.CodigoBarras)
               . IsUnique();
            modelBuilder.Entity<Movimentação>()
                .HasOne(m => m.Produto)
                .WithMany()
               . HasForeignKey(modelBuilder => m.ProdutoId)
                .onDelete(DeleteBehavior.Cascade);
        }

    }       
}
