using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PersonasAutos.Models;

public partial class Practica2Context : DbContext
{
    public Practica2Context()
    {
    }

    public Practica2Context(DbContextOptions<Practica2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Auto> Autos { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-OVPFC5L\\SQLEXPRESS01; Encrypt=False; TrustServerCertificate=True; Database=Practica2; Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Auto>(entity =>
        {
            entity.HasKey(e => e.Matricula).HasName("PK__Autos__0FB9FB4E2037A856");

            entity.Property(e => e.Matricula).HasMaxLength(30);
            entity.Property(e => e.Color).HasMaxLength(30);
            entity.Property(e => e.CurpPersona).HasMaxLength(30);
            entity.Property(e => e.Marca).HasMaxLength(50);
            entity.Property(e => e.Modelo).HasMaxLength(50);
            entity.Property(e => e.Peso).HasColumnType("decimal(8, 3)");
            entity.Property(e => e.Precio).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Tipo).HasMaxLength(30);

            entity.HasOne(d => d.CurpPersonaNavigation).WithMany(p => p.Autos)
                .HasForeignKey(d => d.CurpPersona)
                .HasConstraintName("FK__Autos__CurpPerso__398D8EEE");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Curp).HasName("PK__Personas__AFAC52E4C7CDA568");

            entity.Property(e => e.Curp).HasMaxLength(30);
            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.Ciudad).HasMaxLength(30);
            entity.Property(e => e.EstadoCivil).HasMaxLength(30);
            entity.Property(e => e.Estatura).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.Genero).HasMaxLength(20);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Telefono).HasMaxLength(15);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
