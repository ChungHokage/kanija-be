using kanija_database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace kanija_database.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers"); // Đặt tên bảng

            builder.Property(u => u.DisplayName)
                .IsRequired()
                .HasMaxLength(255); // Giới hạn độ dài

            builder.Property(u => u.CreatedTime).HasDefaultValue(DateTime.UtcNow)
                .IsRequired(false); // Cho phép null

            builder.HasOne(u => u.UserInfor) // Quan hệ 1-1 với UserInfor
                .WithOne(u => u.AppUser)
                .HasForeignKey<UserInfor>(u => u.UserId) // UserId là khóa ngoại
                .OnDelete(DeleteBehavior.Cascade); // Xóa AppUser sẽ xóa UserInfor
        }
    }
}