﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GanttEF.Models
{
    public partial class MasterContext : DbContext
    {
        public MasterContext()
        {
        }

        public MasterContext(DbContextOptions<MasterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GanttData> GanttData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLOCALDB;Database=MT;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GanttData>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Edate)
                    .HasColumnName("Edate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Progress).HasMaxLength(50);
                entity.Property(e => e.Naresh).HasMaxLength(50);
                entity.Property(e => e.ParentId);

                entity.Property(e => e.Sdate)
                    .HasColumnName("Sdate")
                    .HasColumnType("datetime");
                entity.Property(e => e.BaselineStartDate)
                    .HasColumnName("BaselineStartDate")
                    .HasColumnType("datetime");
                entity.Property(e => e.BaselineEndDate)
                    .HasColumnName("BaselineEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Duration).HasMaxLength(50);
                entity.Property(e => e.Predecessor).HasMaxLength(50);
                entity.Property(e => e.Notes).HasMaxLength(50);
                entity.Property(e => e.TaskType).HasMaxLength(50);
            

             });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
