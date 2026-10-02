using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjetoMVC.Models;

public partial class DbSistema2Context : DbContext
{
    public DbSistema2Context()
    {
    }

    public DbSistema2Context(DbContextOptions<DbSistema2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Entrega> Entregas { get; set; }

    public virtual DbSet<Motoristum> Motorista { get; set; }

    public virtual DbSet<Veiculo> Veiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PC03LAB2831\\SENAI;Database=DB_Sistema2;User id=sa; Password=senai.123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Entrega>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__Entrega__06370DAD6B3B0EBF");

            entity.ToTable("Entrega");

            entity.Property(e => e.DescricaoCarga)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Destino)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Peso).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Motoristum>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__Motorist__06370DADD07CF7E3");

            entity.HasIndex(e => e.Cpf, "UQ__Motorist__C1F89731318ABA83").IsUnique();

            entity.HasIndex(e => e.Cnh, "UQ__Motorist__C1FF677544BD8914").IsUnique();

            entity.Property(e => e.Cnh)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CNH");
            entity.Property(e => e.Cpf)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("CPF");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Veiculo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__Veiculo__06370DADFFFDBAC1");

            entity.ToTable("Veiculo");

            entity.HasIndex(e => e.Placa, "UQ__Veiculo__8310F99DA2E00C53").IsUnique();

            entity.Property(e => e.CapacidadeCarga).HasColumnType("decimal(10, 2)");
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
