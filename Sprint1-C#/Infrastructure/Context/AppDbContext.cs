using Microsoft.EntityFrameworkCore;
using Sprint1_C_.Domain.Entities;

namespace Sprint1_C_.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Moto> Moto { get; set; }
        public DbSet<Patio> Patio { get; set; }
        public DbSet<Filial> Filial { get; set; }
        
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Moto>().ToTable("CP_MOTOS");
            modelBuilder.Entity<Patio>().ToTable("CP_PATIOS");
            modelBuilder.Entity<Filial>().ToTable("CP_FILIAIS");
            
            // Relacionamentos aqui...


            modelBuilder.Entity<Moto>()
                .HasOne(m => m.Patio)
                .WithMany(p => p.Motos)
                .HasForeignKey(m => m.PatioId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Patio>()
                .HasOne(p => p.Filial)
                .WithMany(f => f.Patios)
                .HasForeignKey(p => p.FilialId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
