using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjetoMVC.Models;

public partial class DboficinaContext : DbContext
{
    public DboficinaContext()
    {
    }

    public DboficinaContext(DbContextOptions<DboficinaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Veiculo> Veiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Garante que o appsettings.json/Program.cs tenha prioridade
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=PC03LAB2829\\SENAI;Database=DBoficina;User Id=sa;Password=senai.123;TrustServerCertificate=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Veiculo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__Veiculo__06370DAD3367B5F1");

            entity.ToTable("Veiculo");

            entity.HasIndex(e => e.Placa, "UQ__Veiculo__8310F99D5D506DBA").IsUnique();

            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}