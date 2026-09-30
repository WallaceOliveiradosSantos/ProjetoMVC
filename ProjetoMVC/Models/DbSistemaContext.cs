using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjetoMVC.Models;

public partial class DbSistemaContext : DbContext
{

    public DbSistemaContext(DbContextOptions<DbSistemaContext> options)
        : base(options)
    {
    }

    public DbSet<Medico> Medicos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PC03LAB2828\\SENAI;Database=DB_Sistema;User id=sa; Password=senai.123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Medico>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__Medico__06370DAD302B6D7D");

            entity.ToTable("Medico");

            entity.HasIndex(e => e.Crm, "UQ__Medico__C1F887FF894DB1D2").IsUnique();

            entity.Property(e => e.Crm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CRM");
            entity.Property(e => e.Especialidade)
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
