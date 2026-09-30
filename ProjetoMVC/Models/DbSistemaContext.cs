using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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

    public DbSet<Hospede> Hospedes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=PC03LAB2832\\SENAI;Database=DB_Sistema;User Id=sa;Password=senai.123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hospede>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__Hospede__06370DAD34A6EE51");

            entity.ToTable("Hospede");

            entity.HasIndex(e => e.Cpf, "UQ__Hospede__C1F8973168803677").IsUnique();

            entity.Property(e => e.Cpf)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("CPF");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
