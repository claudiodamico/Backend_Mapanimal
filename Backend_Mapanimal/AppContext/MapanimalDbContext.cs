using Backend_Mapanimal.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Backend_Mapanimal.AppContext
{
    public class MapanimalDbContext : IdentityDbContext
    {
        public MapanimalDbContext(DbContextOptions<MapanimalDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Pet> Pets { get; set; }
    }
}
