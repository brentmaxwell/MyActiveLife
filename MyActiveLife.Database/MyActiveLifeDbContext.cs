using Microsoft.EntityFrameworkCore;
using MyActiveLife.Database.Entities;

namespace MyActiveLife.Database
{
    public class MyActiveLifeDbContext : DbContext
    {
        public DbSet<UserProfile> Profiles { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<StravaActivity> StravaActivities { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<Diary> Diaries { get; set; }
        public DbSet<Phq9> Phq9s { get; set; }
        public DbSet<Weather> Weather { get; set; }

        public MyActiveLifeDbContext(DbContextOptions<MyActiveLifeDbContext> options)
            : base(options)
        {
        }
    }
}