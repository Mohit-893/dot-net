using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DbFirstCrud.Models;

namespace DbFirstCrud.Data
{
    public partial class DbFirstCrudContext : DbContext
    {
        public DbFirstCrudContext()
        {
        }

        public DbFirstCrudContext(DbContextOptions<DbFirstCrudContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(local);initial catalog=DbFirstCrud;trusted_connection=yes;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CtCode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IX_Products_7");

                entity.Property(e => e.Category)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
