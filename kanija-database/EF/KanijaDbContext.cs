using kanija_database.Configuration;
using kanija_database.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace kanija_database.EF
{
    public class KanijaDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public KanijaDbContext(DbContextOptions<KanijaDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Gọi cấu hình mặc định của Identity
            modelBuilder.ApplyConfiguration(new AppUserConfiguration()); // Đăng ký cấu hình
            modelBuilder.ApplyConfiguration(new UserInforConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            //     modelBuilder.ApplyConfiguration(new ProductDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ColorConfiguration());
            /*       modelBuilder.ApplyConfiguration(new FileConfiguration());
                   modelBuilder.ApplyConfiguration(new FileInProductDetailConfiguration());*/
            modelBuilder.ApplyConfiguration(new UserInforConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductInCategory> ProductInCategories { get; set; }
        public DbSet<Color> Colors { get; set; }
        /* public DbSet<Entities.File> Files { get; set; }
         public DbSet<FileInProductDetail> FilesInProductDetails { get; set; }*/
        public DbSet<UserInfor> UserInfors { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}