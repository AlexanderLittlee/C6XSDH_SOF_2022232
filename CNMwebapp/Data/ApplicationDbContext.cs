using CNMwebapp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CNMwebapp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Worker> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Job>()
                .HasOne(t => t.Owner)
                .WithMany()
                .HasForeignKey(t => t.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(builder);
        }

    }
}