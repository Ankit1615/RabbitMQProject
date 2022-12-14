// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace project.Models
{
    public partial class projectdbContext : DbContext
    {
        public projectdbContext()
        {
        }

        public projectdbContext(DbContextOptions<projectdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Apply> Apply { get; set; }
        public virtual DbSet<Companydetails> Companydetails { get; set; }
        public virtual DbSet<Jobdetails> Jobdetails { get; set; }
        public virtual DbSet<Jobregister> Jobregister { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Register> Register { get; set; }
        public virtual DbSet<Userorders> Userorders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=BAN-B715VQ3;Initial Catalog=projectdb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apply>(entity =>
            {
                entity.HasKey(e => e.Aid)
                    .HasName("PK__apply__DE508E2E2DDBE7C2");

                entity.ToTable("apply");

                entity.Property(e => e.Aid).HasColumnName("aid");

                entity.Property(e => e.Companyid).HasColumnName("companyid");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Companydetails>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__companyd__D837D05F08A64093");

                entity.ToTable("companydetails");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Jobdetails>(entity =>
            {
                entity.ToTable("jobdetails");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Compdesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("compdesc");

                entity.Property(e => e.Compname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("compname");

                entity.Property(e => e.Comptitle)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("comptitle");
            });

            modelBuilder.Entity<Jobregister>(entity =>
            {
                entity.ToTable("jobregister");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("fname");

                entity.Property(e => e.Mobile).HasColumnName("mobile");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Resumes)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("resumes");

                entity.Property(e => e.Workstatus).HasColumnName("workstatus");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__products__DD37D91A1D4792AF");

                entity.ToTable("products");

                entity.Property(e => e.Pid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("pid");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Pimage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pimage");

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.HasKey(e => e.Uname)
                    .HasName("PK__Register__C7D2484FDD5158B5");

                entity.Property(e => e.Uname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("uname");

                entity.Property(e => e.Desgination)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Userorders>(entity =>
            {
                entity.HasKey(e => e.Tranid)
                    .HasName("PK__userorde__9A599E03313F13E1");

                entity.ToTable("userorders");

                entity.Property(e => e.Tranid).HasColumnName("tranid");

                entity.Property(e => e.Pid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("pid");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("transdate");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}