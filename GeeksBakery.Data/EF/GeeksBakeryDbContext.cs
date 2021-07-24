using GeeksBakery.Data.Configurations;
using GeeksBakery.Data.Entities;
using GeeksBakery.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace GeeksBakery.Data.EF
{
    public class GeeksBakeryDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public GeeksBakeryDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API in config file
            modelBuilder
                .ApplyConfiguration(new OrderConfiguration())
                .ApplyConfiguration(new CartConfiguration())
                .ApplyConfiguration(new OrderDetailConfiguration())
                .ApplyConfiguration(new AppUserConfiguration())
                .ApplyConfiguration(new CakeConfiguration())
                .ApplyConfiguration(new AppRoleConfiguration())
                .ApplyConfiguration(new CategoryConfiguration())
                .ApplyConfiguration(new ReviewConfiguration())
                .ApplyConfiguration(new CakeImageConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            // Data seeding in ModelBuilderExtenions
            modelBuilder.Seed();
        }

        public DbSet<Cake> Cakes { get; set; }
        public DbSet<CakeImage> CakeImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        private DbSet<AppUser> appUsers;

        public DbSet<AppUser> GetAppUsers()
        {
            return appUsers;
        }

        public void SetUsers(DbSet<AppUser> value)
        {
            appUsers = value;
        }

        private DbSet<AppRole> appRoles;

        public DbSet<AppRole> GetAppRoles()
        {
            return appRoles;
        }

        public void SetAppRoles(DbSet<AppRole> value)
        {
            appRoles = value;
        }
    }
}