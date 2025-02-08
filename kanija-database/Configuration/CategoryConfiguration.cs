using kanija_database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace kanija_database.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.ParentCategory).IsRequired(false);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(255);
            builder.Property(c => c.Description).HasMaxLength(500);
            builder.Property(c => c.SeoAlias).HasMaxLength(255);
            builder.Property(c => c.CreatedTime).HasDefaultValueSql("GETUTCDATE()").IsRequired();
            builder.Property(c => c.LastModified).IsRequired(false);
        }
    }
}