using System;
using System.Collections.Generic;
using Examen2.Models;
using Microsoft.EntityFrameworkCore;

namespace Examen2.Context;

public partial class Examen2Context : DbContext
{
    public Examen2Context()
    {
    }

    public Examen2Context(DbContextOptions<Examen2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Habilidade> Habilidades { get; set; }

    public virtual DbSet<Misione> Misiones { get; set; }

    public virtual DbSet<Superhero> Superheroes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DETPC\\SQLEXPRESS; Initial Catalog=Examen2; Integrated Security=True; Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Habilidade>(entity =>
        {
            entity.HasKey(e => e.IdHabilidad).HasName("PK__Habilida__A6B5610AA0FA1BB9");

            entity.Property(e => e.IdHabilidad).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreHabilidad)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdSuperheroeNavigation).WithMany(p => p.Habilidades)
                .HasForeignKey(d => d.IdSuperheroe)
                .HasConstraintName("FK__Habilidad__IdSup__398D8EEE");
        });

        modelBuilder.Entity<Misione>(entity =>
        {
            entity.HasKey(e => e.IdMision).HasName("PK__Misiones__1BB41AA10BC66DE6");

            entity.Property(e => e.IdMision).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdSuperheroe).HasDefaultValue(0);
            entity.Property(e => e.NombreMision)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdSuperheroeNavigation).WithMany(p => p.Misiones)
                .HasForeignKey(d => d.IdSuperheroe)
                .HasConstraintName("FK__Misiones__IdSupe__3C69FB99");
        });

        modelBuilder.Entity<Superhero>(entity =>
        {
            entity.HasKey(e => e.IdSuperheroe).HasName("PK__Superher__11BA23C97D18BEEC");

            entity.Property(e => e.IdSuperheroe).ValueGeneratedNever();
            entity.Property(e => e.Alias)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("A");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Origen)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
