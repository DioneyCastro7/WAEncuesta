using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WAEncuesta.Models
{
    public partial class EncuestaContext : DbContext
    {
        public EncuestaContext()
        {
        }

        public EncuestaContext(DbContextOptions<EncuestaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbCuestionario> TbCuestionarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Conn");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbCuestionario>(entity =>
            {
                entity.ToTable("TbCuestionario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Preguntacinco)
                    .IsUnicode(false)
                    .HasColumnName("preguntacinco");

                entity.Property(e => e.Preguntacuatro)
                    .IsUnicode(false)
                    .HasColumnName("preguntacuatro");

                entity.Property(e => e.Preguntadiez)
                    .IsUnicode(false)
                    .HasColumnName("preguntadiez");

                entity.Property(e => e.Preguntados)
                    .IsUnicode(false)
                    .HasColumnName("preguntados");

                entity.Property(e => e.Preguntanueve)
                    .IsUnicode(false)
                    .HasColumnName("preguntanueve");

                entity.Property(e => e.Preguntaocho)
                    .IsUnicode(false)
                    .HasColumnName("preguntaocho");

                entity.Property(e => e.Preguntaseis)
                    .IsUnicode(false)
                    .HasColumnName("preguntaseis");

                entity.Property(e => e.Preguntasiete)
                    .IsUnicode(false)
                    .HasColumnName("preguntasiete");

                entity.Property(e => e.Preguntatres)
                    .IsUnicode(false)
                    .HasColumnName("preguntatres");

                entity.Property(e => e.Preguntauno)
                    .IsUnicode(false)
                    .HasColumnName("preguntauno");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
