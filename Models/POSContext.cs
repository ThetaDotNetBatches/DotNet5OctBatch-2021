using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DotNet5OctBatch_2021.Models;

#nullable disable

namespace DotNet5OctBatch_2021.Models
{
    public partial class POSContext : DbContext
    {
        public POSContext()
        {
        }

        public POSContext(DbContextOptions<POSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemCategory> ItemCategories { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=THETATEAM12\\SQLEXPRESS01;Database=POS;Trusted_Connection=True; User ID=sa; Password=admin;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ItemCategory).HasColumnName("Item_Category");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(50)
                    .HasColumnName("Item_Code");

                entity.Property(e => e.ItemMaxStock).HasColumnName("Item_MaxStock");

                entity.Property(e => e.ItemMinStock).HasColumnName("Item_MinStock");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .HasColumnName("Item_Name");

                entity.Property(e => e.ItemOpeningStock).HasColumnName("Item_OpeningStock");

                entity.Property(e => e.ItemPrice).HasColumnName("Item_Price");

                entity.Property(e => e.ItemQuantity).HasColumnName("Item_Quantity");

                entity.Property(e => e.ItemSerial).HasColumnName("Item_Serial");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.OpeningStockDate)
                    .HasColumnType("datetime")
                    .HasColumnName("OpeningStock_Date");
            });

            modelBuilder.Entity<ItemCategory>(entity =>
            {
                entity.Property(e => e.CatCode)
                    .HasMaxLength(50)
                    .HasColumnName("Cat_Code");

                entity.Property(e => e.CatLevel).HasColumnName("Cat_Level");

                entity.Property(e => e.CatName)
                    .HasMaxLength(50)
                    .HasColumnName("Cat_Name");

                entity.Property(e => e.CatSerial).HasColumnName("Cat_Serial");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyBy).HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<DotNet5OctBatch_2021.Models.ViewItems> ViewItems { get; set; }
    }
}
