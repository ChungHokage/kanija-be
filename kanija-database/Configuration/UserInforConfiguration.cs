using System;
using kanija_database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace kanija_database.Configuration
{
    internal class UserInforConfiguration : IEntityTypeConfiguration<UserInfor>
    {
        public void Configure(EntityTypeBuilder<UserInfor> builder)
        {
            builder.ToTable("UserInfor");
            builder.HasKey(u => u.Id);
            builder.HasOne(u => u.AppUser).WithOne().HasForeignKey<UserInfor>(u => u.UserId).OnDelete(DeleteBehavior.Cascade);
            builder.Property(u => u.DayOfBirth)
                .IsRequired(false);
            builder.Property(u => u.Gender)
                .HasConversion<int>()
                .IsRequired(false);
        }
    }
}