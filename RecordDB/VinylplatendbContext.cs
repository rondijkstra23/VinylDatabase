using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RecordDB
{
    public partial class VinylplatendbContext : DbContext
    {
        public VinylplatendbContext()
        {
        }

        public VinylplatendbContext(DbContextOptions<VinylplatendbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Vinylplaten> Vinylplatens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-TVDEQA7\\MSSQLSERVER01;Initial Catalog=VinylPlatenDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Vinylplaten>(entity =>
            {
                entity.HasKey(e => e.VinylId)
                    .HasName("PK__vinylpla__BCE9A8DB680E1082");

                entity.ToTable("vinylplaten");

                entity.Property(e => e.VinylId).HasColumnName("vinyl_ID");

                entity.Property(e => e.Afbeelding)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Album)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Artiest)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseDatum).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}