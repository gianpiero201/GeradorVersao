using System;
using System.Collections.Generic;
using GeradorVersao.Domain.Bd.Models;
using Microsoft.EntityFrameworkCore;

namespace GeradorVersao.Domain.Bd;

public partial class ProjetosContext : DbContext
{
    public ProjetosContext()
    {
    }

    public ProjetosContext(DbContextOptions<ProjetosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Armazem> Armazems { get; set; }

    public virtual DbSet<Projeto> Projetos { get; set; }

    public virtual DbSet<TipoArmazem> TipoArmazems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=./Domain/Bd/Projetos.db;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Armazem>(entity =>
        {
            entity.ToTable("armazem");

            entity.HasIndex(e => e.Caminho, "IX_armazem_caminho").IsUnique();

            entity.HasIndex(e => e.Nome, "IX_armazem_nome").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Caminho).HasColumnName("caminho");
            entity.Property(e => e.IdTipoArmazem).HasColumnName("id_tipo_armazem");
            entity.Property(e => e.Nome).HasColumnName("nome");

            entity.HasOne(d => d.IdTipoArmazemNavigation).WithMany(p => p.Armazems).HasForeignKey(d => d.IdTipoArmazem);
        });

        modelBuilder.Entity<Projeto>(entity =>
        {
            entity.ToTable("projeto");

            entity.HasIndex(e => e.Caminho, "IX_projeto_caminho").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Caminho).HasColumnName("caminho");
            entity.Property(e => e.DeployAutomatico)
                .HasColumnType("INTEGER (1, 0)")
                .HasColumnName("deploy_automatico");
            entity.Property(e => e.IdArmazem).HasColumnName("id_armazem");
            entity.Property(e => e.Nome).HasColumnName("nome");

            entity.HasOne(d => d.IdArmazemNavigation).WithMany(p => p.Projetos).HasForeignKey(d => d.IdArmazem);
        });

        modelBuilder.Entity<TipoArmazem>(entity =>
        {
            entity.ToTable("tipo_armazem");

            entity.HasIndex(e => e.Nome, "IX_tipo_armazem_nome").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome).HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
