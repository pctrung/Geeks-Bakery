using GeeksBakery.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace GeeksBakery.Data.Extensions
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cake>().HasData(
                new Cake { Id = 1, Stock = 0, Name = "Blue bery mousse", Price = 300000, OriginalPrice = 300000, Size = 19, Description = "Blueberry, Kem cheese, Kem tươi.", CategoryId = 3 },
                new Cake { Id = 2, Stock = 0, Name = "Caramel mousse", Price = 250000, OriginalPrice = 250000, Size = 21, Description = "Caramel, Socola", CategoryId = 3 },
                new Cake { Id = 3, Stock = 0, Name = "Cherry cheese mousse", Price = 150000, OriginalPrice = 150000, Size = 20, Description = "Cherry, Kem cheese ,Kem tươi.", CategoryId = 3 },
                new Cake { Id = 4, Stock = 0, Name = "Red chocolate mousse", Price = 200000, OriginalPrice = 200000, Size = 19, Description = "Kem tươi, Socola,Trà xanh.", CategoryId = 3 },
                new Cake { Id = 5, Stock = 0, Name = "Dark chocolate cake", Price = 150000, OriginalPrice = 150000, Size = 20, Description = "Gato, kem bơ vị rượu rum, socola.", CategoryId = 1 },
                new Cake { Id = 6, Stock = 0, Name = "White chocolate and coconut cake", Price = 300000, OriginalPrice = 300000, Size = 19, Description = "Gato, kem bơ vị rượu rum, socola bào trắng, dừa sấy.", CategoryId = 1 },
                new Cake { Id = 7, Stock = 0, Name = "Car dollar cake", Price = 290000, OriginalPrice = 290000, Size = 21, Description = "Gato, kem, có phụ kiện trên mặt bánh", CategoryId = 2 },
                new Cake { Id = 8, Stock = 0, Name = "Green tea four love", Price = 170000, OriginalPrice = 170000, Size = 20, Description = "Gato, kem vị trà xanh.", CategoryId = 2 },
                new Cake { Id = 9, Stock = 0, Name = "Tiramisu", Price = 160000, OriginalPrice = 160000, Size = 21, Description = "Gato, kem tươi vị coffee", CategoryId = 4 });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Bread" },
                new Category { Id = 2, Name = "Mousse" },
                new Category { Id = 3, Name = "Cookies" },
                new Category { Id = 4, Name = "Donuts" });

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), DateCreated = new DateTime(2021, 5, 21, 12, 45, 0), DeliveryDate = new DateTime(2021, 5, 21, 12, 45, 0), Status = Enums.Status.Completed },
                new Order { Id = 2, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), DateCreated = new DateTime(2021, 5, 22, 13, 41, 0), DeliveryDate = new DateTime(2021, 5, 22, 10, 50, 0), Status = Enums.Status.Completed },
                new Order { Id = 3, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), DateCreated = new DateTime(2021, 5, 22, 15, 23, 0), DeliveryDate = new DateTime(2021, 5, 23, 9, 34, 0), Status = Enums.Status.Completed },
                new Order { Id = 4, UserId = new Guid("BFF91054-DC92-421E-A233-D1080F630928"), DateCreated = new DateTime(2021, 5, 23, 12, 11, 0), DeliveryDate = new DateTime(2021, 5, 23, 16, 23, 0), Status = Enums.Status.Completed },
                new Order { Id = 5, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), DateCreated = new DateTime(2021, 5, 24, 12, 11, 0), Status = Enums.Status.Shipping },
                new Order { Id = 6, UserId = new Guid("BFF91054-DC92-421E-A233-D1080F630928"), DateCreated = new DateTime(2021, 5, 24, 12, 30, 0), Status = Enums.Status.Pending });

            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { OrderId = 1, CakeId = 1, Amount = 2 },
                new OrderDetail { OrderId = 2, CakeId = 2, Amount = 1 },
                new OrderDetail { OrderId = 3, CakeId = 3, Amount = 1 },
                new OrderDetail { OrderId = 3, CakeId = 1, Amount = 2 },
                new OrderDetail { OrderId = 4, CakeId = 1, Amount = 1 },
                new OrderDetail { OrderId = 5, CakeId = 3, Amount = 1 },
                new OrderDetail { OrderId = 5, CakeId = 2, Amount = 1 },
                new OrderDetail { OrderId = 6, CakeId = 4, Amount = 1 });

            // create any guid
            var adminRoleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var customerRoleId = new Guid("54BA416F-6B89-4C53-873D-4FBD48506E6D");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            var customerId = new Guid("BFF91064-DC92-421E-A233-D1080F630928");
            var customerId2 = new Guid("BFF91054-DC92-421E-A233-D1080F630928");
            modelBuilder.Entity<AppRole>().HasData(
                new AppRole
                {
                    Id = adminRoleId,
                    Name = "admin",
                    NormalizedName = "admin",
                    Description = "Administrator role"
                },
                new AppRole
                {
                    Id = customerRoleId,
                    Name = "customer",
                    NormalizedName = "customer",
                    Description = "Customer role"
                });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = adminId,
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "trung@gmail.com",
                    NormalizedEmail = "trung@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!"),
                    SecurityStamp = string.Empty,
                    Name = "Pham Chi Trung",
                    DoB = new DateTime(2000, 02, 11)
                },
                new AppUser
                {
                    Id = customerId,
                    UserName = "customer 1",
                    NormalizedUserName = "customer",
                    Email = "customer1@gmail.com",
                    NormalizedEmail = "customer1@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!"),
                    SecurityStamp = string.Empty,
                    Name = "Pham Chi Trung Customer",
                    DoB = new DateTime(2000, 02, 22)
                },
                new AppUser
                {
                    Id = customerId2,
                    UserName = "customer 2",
                    NormalizedUserName = "customer",
                    Email = "customer2@gmail.com",
                    NormalizedEmail = "customer2@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!"),
                    SecurityStamp = string.Empty,
                    Name = "David",
                    DoB = new DateTime(1996, 02, 22)
                });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>
                {
                    RoleId = adminRoleId,
                    UserId = adminId,
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = customerRoleId,
                    UserId = customerId,
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = customerRoleId,
                    UserId = customerId2,
                });

        }
    }
}
