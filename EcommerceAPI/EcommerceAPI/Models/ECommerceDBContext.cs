using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EcommerceAPI.Models
{
    public partial class ECommerceDBContext : DbContext
    {
        public ECommerceDBContext()
        {
        }

        public ECommerceDBContext(DbContextOptions<ECommerceDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCategory> TblCategories { get; set; }
        public virtual DbSet<TblLogin> TblLogins { get; set; }
        public virtual DbSet<TblProduct> TblProducts { get; set; }
        public virtual DbSet<TblUserProduct> TblUserProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.ToTable("tblCategory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.ToTable("tblLogin");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("password");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.ToTable("tblProduct");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.ProductDesciption)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProductDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductFinal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductImage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProductMrp).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblUserProduct>(entity =>
            {
                entity.ToTable("tblUserProduct");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.ProductDesciption)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProductDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductFinal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductImage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProductMrp).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
