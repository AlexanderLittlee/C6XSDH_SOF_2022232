using CNMwebapp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CNMwebapp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Worker> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<SquadMember> SquadMembers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Job>()
                .HasMany(j => j.Workers)
                .WithMany(w => w.Schedule)
                .UsingEntity<SquadMember>
                (
                    w => w.HasOne(x => x.Worker)
                           .WithMany()
                           .HasForeignKey(x => x.WorkerId)
                           .OnDelete(DeleteBehavior.Cascade),
                
                    j => j.HasOne(x => x.Job)
                          .WithMany()
                          .HasForeignKey(x => x.JobId)
                          .OnDelete(DeleteBehavior.Cascade)
                );

            


        }

    }
}