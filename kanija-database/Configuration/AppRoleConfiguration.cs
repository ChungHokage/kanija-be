using System.Threading.Tasks;
using kanija_database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace kanija_database.Configuration
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable("AppRole");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Description)
                .HasMaxLength(500);
        }
    }
}