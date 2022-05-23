using Microsoft.EntityFrameworkCore;
using MyActiveLife.Database.Entities;

namespace MyActiveLife.Database
{
    public class MyActiveLifeDbContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
    }
}