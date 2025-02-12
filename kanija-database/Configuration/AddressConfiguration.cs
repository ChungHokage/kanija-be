using kanija_database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace kanija_database.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name)
                .HasMaxLength(100);

            builder.Property(a => a.PhoneNumber)
                .HasMaxLength(15);

            builder.Property(a => a.Province)
                .HasMaxLength(100);

            builder.Property(a => a.District)
                .HasMaxLength(100);

            builder.Property(a => a.Ward)
                .HasMaxLength(100);

            builder.Property(a => a.AddressDetail)
                .HasMaxLength(255);

            builder.Property(a => a.AddressType)
                .HasConversion<int>(); // Lưu dưới dạng số nguyên

            builder.Property(a => a.IsDefault)
                .HasDefaultValue(false);
        }
    }
}