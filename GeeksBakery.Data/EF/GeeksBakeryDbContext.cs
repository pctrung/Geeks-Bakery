using GeeksBakery.Data.Configurations;
using GeeksBakery.Data.Entities;
using GeeksBakery.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.Data.EF
{
    public class GeeksBakeryDbContext : DbContext
    {
        public GeeksBakeryDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new CartConfiguration())
                .ApplyConfiguration(new OrderDetailConfiguration());

            // Data seeding in ModelBuilderExtenions
            modelBuilder.Seed();
        }
        public DbSet<Cake> Cakes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
