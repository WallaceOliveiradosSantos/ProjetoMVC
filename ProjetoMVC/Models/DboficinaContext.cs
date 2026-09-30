using Microsoft.EntityFrameworkCore;

namespace ProjetoMVC.Models
{
    public class DboficinaContext : DbContext
    {
        public DboficinaContext()
        {
        }

        public DboficinaContext(DbContextOptions<DboficinaContext> options)
            : base(options)
        {
        }

        public DbSet<Servico> Servicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=PC03LAB2833\\SENAI;Database=DBoficina;User id=sa;Password=senai.123;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Servico>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("Servico");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TempoEstimado);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}