using Microsoft.EntityFrameworkCore;
using DreamGarage.Models;

namespace DreamGarage.Data;

public class CarContext : DbContext
{
    public CarContext(DbContextOptions<CarContext> options) : base(options)
    {
    }

    public DbSet<Car> Cars => Set<Car>();
    public DbSet<CarReview> CarReviews => Set<CarReview>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>().HasData(
        new Car { Id = 1, Make = "McLaren", Model = "720S", Trim = "Performance", Year = 2020, Color = "Orange", Price = 275000, Horsepower = 710, IsElectric = false, IsHybrid = false, Drivetrain = "RWD", ImageUrl = "/images/mclaren720s.jpg" },
        new Car { Id = 2, Make = "Porsche", Model = "911", Trim = "Turbo S", Year = 2018, Color = "Black", Price = 200000, Horsepower = 580, IsElectric = false, IsHybrid = false, Drivetrain = "AWD", ImageUrl = "https://media.carsandbids.com/cdn-cgi/image/width=2080,quality=70/9004500a220bf3a3d455d15ee052cf8c332606f8/photos/3gq6xaNP-5Zzhy1THp9-(edit).jpg?t=165820835234" },
        new Car { Id = 3, Make = "Lamborghini", Model = "Aventador", Trim = "SVJ", Year = 2022, Color = "Lime", Price = 550000, Horsepower = 759, IsElectric = false, IsHybrid = false, Drivetrain = "AWD", ImageUrl = "https://www.exclusiveautomotivegroup.com/imagetag/3448/main/l/Used-2022-Lamborghini-Aventador-1669662938.jpg" },
        new Car { Id = 4, Make = "BMW", Model = "M5", Trim = "CS", Year = 2021, Color = "Blue", Price = 145000, Horsepower = 627, IsElectric = false, IsHybrid = false, Drivetrain = "AWD", ImageUrl = "https://images.hgmsites.net/med/2021-bmw-5-series_100749425_m.jpg" },
        new Car { Id = 5, Make = "Audi", Model = "RS Q8", Trim = "Performance", Year = 2025, Color = "Red", Price = 135000, Horsepower = 631, IsElectric = false, IsHybrid = true, Drivetrain = "AWD", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRCzXMrQ-8uctEwhXVIFMlsXrUwDXIsD-10xRob7ip8Yg&s=10" },
        new Car { Id = 6, Make = "Rimac", Model = "Nevera", Trim = "R", Year = 2024, Color = "Silver", Price = 2500000, Horsepower = 2107, IsElectric = true, IsHybrid = false, Drivetrain = "AWD", ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/2025-rimac-nevera-pr-101-691b428773e01.jpg?crop=0.780xw:0.656xh;0.175xw,0.344xh&resize=2048:*" }
        );
    }
}