using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
              new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    Occupancy = 4,
                    rate = 200,
                    sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
              new Villa
              {
                  Id = 2,
                  Name = "Premium Pool Villa",
                  Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                  rate = 300,
                  sqft = 550,
                  Amenity = "",
                  CreatedDate = DateTime.Now
              },
              new Villa
              {
                  Id = 3,
                  Name = "Luxury Pool Villa",
                  Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                  Occupancy = 4,
                  rate = 400,
                  sqft = 750,
                  Amenity = "",
                  CreatedDate = DateTime.Now
              },
              new Villa
              {
                  Id = 4,
                  Name = "Diamond Villa",
                  Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                 
                  Occupancy = 4,
                  rate = 550,
                  sqft = 900,
                  Amenity = "",
                  CreatedDate = DateTime.Now
              },
              new Villa
              {
                  Id = 5,
                  Name = "Diamond Pool Villa",
                  Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
               
                  Occupancy = 4,
                  rate = 600,
                  sqft = 1100,
                  Amenity = "",
                  CreatedDate = DateTime.Now
              });
        }
    }
}
