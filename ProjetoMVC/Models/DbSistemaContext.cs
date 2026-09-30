using Microsoft.EntityFrameworkCore;
using ProjetoMVC.TempModels;

namespace ProjetoMVC.Models;

public partial class DbSistemaContext : DbContext
{
    public DbSistemaContext()
    {
    }

    public DbSistemaContext(DbContextOptions<DbSistemaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Hospede> Hospedes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hospede>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("Hospede");

            entity.HasIndex(e => e.Cpf).IsUnique();

            entity.Property(e => e.Cpf)
                .HasMaxLength(14)
                .HasColumnName("CPF");

            entity.Property(e => e.Email)
                .HasMaxLength(100);

            entity.Property(e => e.Nome)
                .HasMaxLength(100);

            entity.Property(e => e.Telefone)
                .HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}