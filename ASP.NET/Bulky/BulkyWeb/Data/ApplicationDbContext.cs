using Microsoft.EntityFrameworkCore;
using BulkyWeb.Models;
namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Catagory> Catagories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catagory>().HasData(
                new Catagory { Id = 1, Name = "Jalindranth", City = 1 },
                                
                new Catagory { Id = 2, Name = "Akash", City = 2 },
                new Catagory { Id = 3, Name = "Rohit", City = 3 }



                );
        }
    }
}
