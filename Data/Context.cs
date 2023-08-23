using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using System.Data;
using System.Reflection;

namespace WebApplication1.Data
{
    public class Context : DbContext
    {

      

        public Context(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Model> models { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Car> cars { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderCar> orderCars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Brand>().HasData(new[]
            {
                new Brand
                {
                    Id = 1,
                    Name = "Toyota"
                },
                new Brand
                {
                    Id = 2,
                    Name = "Ford"
                },
                new Brand
                {
                    Id = 3,
                    Name = "Honda"
                },
                new Brand
                {
                    Id = 4,
                    Name = "BMW"
                },
                new Brand
                {
                    Id = 5,
                    Name = "Chevrolet"
                },
                new Brand
                {
                    Id = 6,
                    Name = "Nissan"
                },
                new Brand
                {
                    Id = 7,
                    Name = "Audi"
                },
                new Brand
                {
                    Id = 8,
                    Name = "Volkswagen"
                },
                new Brand
                {
                    Id = 9,
                    Name = "Mercedes"
                },
                new Brand
                {
                    Id = 10,
                    Name = "Hyundai"
                },
                // Add more Brand records here...
            });

                modelBuilder.Entity<Model>().HasData(new[]
                {
                new Model
                {
                    Id = 1,
                    Type = "Sedan",
                    Name = "Camry",
                    BrandID = 1
                },
                new Model
                {
                    Id = 2,
                    Type = "SUV",
                    Name = "Escape",
                    BrandID = 2
                },
                new Model
                {
                    Id = 3,
                    Type = "Sedan",
                    Name = "Accord",
                    BrandID = 3
                },
                new Model
                {
                    Id = 4,
                    Type = "Coupe",
                    Name = "3 Series",
                    BrandID = 4
                },
                new Model
                {
                    Id = 5,
                    Type = "Hatch",
                    Name = "Spark",
                    BrandID = 5
                },
                new Model
                {
                    Id = 6,
                    Type = "Sedan",
                    Name = "Altima",
                    BrandID = 6
                },
                new Model
                {
                    Id = 7,
                    Type = "Sedan",
                    Name = "A4",
                    BrandID = 7
                },
                new Model
                {
                    Id = 8,
                    Type = "Sedan",
                    Name = "Jetta",
                    BrandID = 8
                },
                new Model
                {
                    Id = 9,
                    Type = "Sedan",
                    Name = "C-Class",
                    BrandID = 9
                },
                new Model
                {
                    Id = 10,
                    Type = "Hatch",
                    Name = "i20",
                    BrandID = 10
                },
                new Model
                {
                    Id = 11,
                    Type = "SUV",
                    Name = "RAV4",
                    BrandID = 1
                },
                new Model
                {
                    Id = 12,
                    Type = "SUV",
                    Name = "Explorer",
                    BrandID = 2
                },
                new Model
                {
                    Id = 13,
                    Type = "SUV",
                    Name = "CR-V",
                    BrandID = 3
                },
                new Model
                {
                    Id = 14,
                    Type = "Coupe",
                    Name = "4 Series",
                    BrandID = 4
                },
                new Model
                {
                    Id = 15,
                    Type = "Sedan",
                    Name = "Malibu",
                    BrandID = 5
                },
                new Model
                {
                    Id = 16,
                    Type = "SUV",
                    Name = "Rogue",
                    BrandID = 6
                },
                new Model
                {
                    Id = 17,
                    Type = "Sedan",
                    Name = "A6",
                    BrandID = 7
                },
                new Model
                {
                    Id = 18,
                    Type = "Sedan",
                    Name = "Passat",
                    BrandID = 8
                },
                new Model
                {
                    Id = 19,
                    Type = "SUV",
                    Name = "GLE-Class",
                    BrandID = 9
                },
                new Model
                {
                    Id = 20,
                    Type = "Sedan",
                    Name = "Elantra",
                    BrandID = 10
                },
                // Add more Model records here...
            });

                modelBuilder.Entity<Car>().HasData(new[]
                {
                new Car
                {
                    Id = 1,
                    ModelID = 1,
                    Power = 180,
                    Year = 2022
                },
                new Car
                {
                    Id = 2,
                    ModelID = 2,
                    Power = 200,
                    Year = 2021
                },
                new Car
                {
                    Id = 3,
                    ModelID = 3,
                    Power = 190,
                    Year = 2022
                },
                new Car
                {
                    Id = 4,
                    ModelID = 4,
                    Power = 250,
                    Year = 2023
                },
                new Car
                {
                    Id = 5,
                    ModelID = 5,
                    Power = 100,
                    Year = 2022
                },
                new Car
                {
                    Id = 6,
                    ModelID = 6,
                    Power = 180,
                    Year = 2022
                },
                new Car
                {
                    Id = 7,
                    ModelID = 7,
                    Power = 200,
                    Year = 2021
                },
                new Car
                {
                    Id = 8,
                    ModelID = 8,
                    Power = 190,
                    Year = 2022
                },
                new Car
                {
                    Id = 9,
                    ModelID = 9,
                    Power = 250,
                    Year = 2023
                },
                new Car
                {
                    Id = 10,
                    ModelID = 10,
                    Power = 100,
                    Year = 2022
                }
                

             });
         }

    }
}
