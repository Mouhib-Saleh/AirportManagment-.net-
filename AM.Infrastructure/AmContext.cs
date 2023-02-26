using Microsoft.EntityFrameworkCore;
using AM.ApplicationCore.Domain;
namespace AM.Infrastructure
{
    public class AmContext: DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Traveller> Travellers { get; set; }
        public DbSet<Passanger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=(localdb)\mssqllocaldb;initial catalog = MouhibSaleh;integrated security = true");
        }

    }
}