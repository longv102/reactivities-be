using Microsoft.EntityFrameworkCore;

namespace Reactivities.Persistence
{
    public class ReactivitiesContext : DbContext
    {
        public ReactivitiesContext(DbContextOptions<ReactivitiesContext> options) : base(options)
        {
        }

        public DbSet<Reactivities.Domain.Activity> Activities { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Seed();
        }
    }
}
