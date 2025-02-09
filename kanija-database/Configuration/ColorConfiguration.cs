using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using kanija_database.Entities;

namespace kanija_database.Configuration
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            // Đặt tên bảng
            builder.ToTable("Color");

            // Định nghĩa khóa chính
            builder.HasKey(c => c.Id);

            // Cấu hình cột Name
            builder.Property(c => c.Name)
                .IsRequired()  // Không cho phép null
                .HasMaxLength(100);

            // Cấu hình cột ColorCode
            builder.Property(c => c.ColorCode)
                .HasMaxLength(20);

            // Cấu hình cột RGBCode
            builder.Property(c => c.RGBCode)
                .HasMaxLength(20);
        }
    }
}