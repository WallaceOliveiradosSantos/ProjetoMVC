using Microsoft.EntityFrameworkCore;

namespace ProjetoMVC.Models
{
    public class DbSistemaContext : DbContext
    {
        public DbSistemaContext(DbContextOptions<DbSistemaContext> options)
            : base(options)
        {
        }

        public DbSet<Reserva> Reserva { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reserva>().ToTable("Reserva");
        }
    }
}

