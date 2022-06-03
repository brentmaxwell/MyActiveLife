using Microsoft.EntityFrameworkCore;
using MyActiveLife.Database.Entities;

namespace MyActiveLife.Database
{
    public class MyActiveLifeDbContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Source> Sources { get; set; }

        public MyActiveLifeDbContext(DbContextOptions<MyActiveLifeDbContext> options)
            : base(options)
        {
        }
    }
}