using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Project01Group4.Models
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=citizen.manukautech.info,6305;Database=FS_Q1_Team4_CC4SD;UID=FS_Q1_Team4;PWD=fBit$47179;encrypt=true;trustservercertificate=true");
        }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<ExerciseHistory> ExerciseHistories { get; set; }
        public virtual DbSet<ExerciseType> ExerciseTypes { get; set; }
        public virtual DbSet<MuscleGroup> MuscleGroups { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public IEnumerable<object> Person { get; internal set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Exercise>(entity =>
            {
                entity.ToTable("Exercise");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.Equipment1Navigation)
                    .WithMany(p => p.ExerciseEquipment1Navigations)
                    .HasForeignKey(d => d.Equipment1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExerciseEquipment1");

                entity.HasOne(d => d.Equipment2Navigation)
                    .WithMany(p => p.ExerciseEquipment2Navigations)
                    .HasForeignKey(d => d.Equipment2)
                    .HasConstraintName("FK_ExerciseEquipment2");

                entity.HasOne(d => d.Equipment3Navigation)
                    .WithMany(p => p.ExerciseEquipment3Navigations)
                    .HasForeignKey(d => d.Equipment3)
                    .HasConstraintName("FK_ExerciseEquipment3");

                entity.HasOne(d => d.Equipment4Navigation)
                    .WithMany(p => p.ExerciseEquipment4Navigations)
                    .HasForeignKey(d => d.Equipment4)
                    .HasConstraintName("FK_ExerciseEquipment4");

                entity.HasOne(d => d.Equipment5Navigation)
                    .WithMany(p => p.ExerciseEquipment5Navigations)
                    .HasForeignKey(d => d.Equipment5)
                    .HasConstraintName("FK_ExerciseEquipment5");

                entity.HasOne(d => d.MuscleGroup1Navigation)
                    .WithMany(p => p.ExerciseMuscleGroup1Navigations)
                    .HasForeignKey(d => d.MuscleGroup1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExerciseMuscle1");

                entity.HasOne(d => d.MuscleGroup2Navigation)
                    .WithMany(p => p.ExerciseMuscleGroup2Navigations)
                    .HasForeignKey(d => d.MuscleGroup2)
                    .HasConstraintName("FK_ExerciseMuscle2");

                entity.HasOne(d => d.Type1Navigation)
                    .WithMany(p => p.ExerciseType1Navigations)
                    .HasForeignKey(d => d.Type1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExerciseType1");

                entity.HasOne(d => d.Type2Navigation)
                    .WithMany(p => p.ExerciseType2Navigations)
                    .HasForeignKey(d => d.Type2)
                    .HasConstraintName("FK_ExerciseType2");

                entity.HasOne(d => d.Type3Navigation)
                    .WithMany(p => p.ExerciseType3Navigations)
                    .HasForeignKey(d => d.Type3)
                    .HasConstraintName("FK_ExerciseType3");
            });

            modelBuilder.Entity<ExerciseHistory>(entity =>
            {
                entity.ToTable("ExerciseHistory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EnergyBurned).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<ExerciseType>(entity =>
            {
                entity.ToTable("ExerciseType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<MuscleGroup>(entity =>
            {
                entity.ToTable("MuscleGroup");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Bmi)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("BMI");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(1);

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.Password).HasMaxLength(30);

                entity.Property(e => e.Username).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
