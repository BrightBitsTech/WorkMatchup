using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using webapi.Entities;
using webapi.Entities.AccountDetails;
using webapi.Models;

namespace webapi.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbSet<Account> Accounts { get; set; }
        public DbSet<JobOffer> JobOffers { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Network> Networks { get; set; }
        public DbSet<ProfessionalEvent> ProfessionalEvents { get; set; }


        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }
    }
}
