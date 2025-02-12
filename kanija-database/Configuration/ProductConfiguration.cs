using kanija_database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace kanija_database.Configuration
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Description).HasMaxLength(500);
            builder.Property(p => p.ProductCode).IsRequired().HasMaxLength(50);
            builder.HasIndex(p => p.ProductCode).IsUnique();
            builder.Property(p => p.Material).HasMaxLength(100);
            builder.Property(p => p.Usage).HasMaxLength(500);
            builder.Property(p => p.SeoAlias).HasMaxLength(255);
            builder.Property(p => p.Price).IsRequired().HasPrecision(18, 2).HasDefaultValue(0);
            builder.Property(p => p.Discount).IsRequired().HasPrecision(5, 2).HasDefaultValue(0);
        }
    }
}