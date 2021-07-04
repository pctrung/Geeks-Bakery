using GeeksBakery.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.Data.Extensions
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cake>().HasData(
                new Cake { Id = 1, Name = "Blue bery mousse", Price = 300000, OriginalPrice = 300000, Size = 19, Description = "Blueberry, Kem cheese, Kem tươi.", CategoryId = 3 },
                new Cake { Id = 2, Name = "Caramel mousse", Price = 250000, OriginalPrice = 250000, Size = 21, Description = "Caramel, Socola", CategoryId = 3 },
                new Cake { Id = 3, Name = "Cherry cheese mousse", Price = 150000, OriginalPrice = 150000, Size = 20, Description = "Cherry, Kem cheese ,Kem tươi.", CategoryId = 3 },
                new Cake { Id = 4, Name = "Red chocolate mousse", Price = 200000, OriginalPrice = 200000, Size = 19, Description = "Kem tươi, Socola,Trà xanh.", CategoryId = 3 },
                new Cake { Id = 5, Name = "Dark chocolate cake", Price = 150000, OriginalPrice = 150000, Size = 20, Description = "Gato, kem bơ vị rượu rum, socola.", CategoryId = 1 },
                new Cake { Id = 6, Name = "White chocolate and coconut cake", Price = 300000, OriginalPrice = 300000, Size = 19, Description = "Gato, kem bơ vị rượu rum, socola bào trắng, dừa sấy.", CategoryId = 1 },
                new Cake { Id = 7, Name = "Car dollar cake", Price = 290000, OriginalPrice = 290000, Size = 21, Description = "Gato, kem, có phụ kiện trên mặt bánh", CategoryId = 2 },
                new Cake { Id = 8, Name = "Green tea four love", Price = 170000, OriginalPrice = 170000, Size = 20, Description = "Gato, kem vị trà xanh.", CategoryId = 2 },
                new Cake { Id = 9, Name = "Tiramisu", Price = 160000, OriginalPrice = 160000, Size = 21, Description = "Gato, kem tươi vị coffee", CategoryId = 4 });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Bread" },
                new Category { Id = 2, Name = "Mousse" },
                new Category { Id = 3, Name = "Cookies" },
                new Category { Id = 4, Name = "Donuts" });
        }
    }
}
