using EFCoreMoviesForVue.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using EFCoreMoviesForVue.Entities.Seeding;

namespace EFCoreMoviesForVue
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        { }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            configurationBuilder.Properties<string>().HaveMaxLength(150);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            InitSeed.Seed(modelBuilder);


            modelBuilder.Entity<BaseEntity>().HasKey(x => x.Id);
            modelBuilder.Entity<BaseEntity>().Property(x => x.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<MovieGenre>().HasKey(x => new { x.GenreId, x.MovieId });
            
        }   

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
