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
        public DbSet<Interview> Interviews { get; set; }


        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Interview>().HasOne(i => i.Candidate).WithMany(a => a.CandidateInterviews).HasForeignKey(i => i.CandidateId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Interview>().HasOne(i => i.Recruiter).WithMany(a => a.RecruiterInterviews).HasForeignKey(i => i.RecruiterId).OnDelete(DeleteBehavior.Restrict).HasConstraintName("FK_Interviews_Recruiters");
            modelBuilder.Entity<Message>().HasOne(m => m.Sender).WithMany(a => a.SentMessages).HasForeignKey(m => m.SenderId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Message>().HasOne(m => m.Recipient).WithMany(a => a.ReceivedMessages).HasForeignKey(m => m.RecipientId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserConnection>().HasOne(uc => uc.Requestor).WithMany(a => a.RequestorConnections).HasForeignKey(uc => uc.RequestorId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserConnection>().HasOne(uc => uc.Requested).WithMany(a => a.RequestedConnections).HasForeignKey(uc => uc.RequestedId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserEndorsement>().HasOne(ue => ue.Endorser).WithMany(a => a.GivenEndorsements).HasForeignKey(ue => ue.EndorserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserEndorsement>().HasOne(ue => ue.Endorsed).WithMany(a => a.ReceivedEndorsements).HasForeignKey(ue => ue.EndorsedId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Account>().Property(a => a.ExpectedSalary).HasColumnType("decimal(18, 2)");
            modelBuilder.Entity<JobOffer>().Property(j => j.OfferedSalary).HasColumnType("decimal(18, 2)");
            modelBuilder.Entity<Interview>().HasCheckConstraint("CK_Interviews_RecruiterRole",
              @"EXISTS(SELECT 1 FROM Accounts a WHERE a.Id = RecruiterId AND a.Role = 'Recruiter')");
        }
    }
}
