using CNMwebapp.Models;
using IdentityCore.Data;
using Microsoft.AspNetCore.Identity;
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
            List<Job> jobs = new List<Job>()
            {
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Balaton Sound", Date=new DateTime(2023,6,26,7,15,0), WorkersNeeded=6, Workers=new List<Worker>(6)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Balaton Sound", Date=new DateTime(2023,6,27,7,15,0), WorkersNeeded=6, Workers=new List<Worker>(6)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Balaton Sound", Date=new DateTime(2023,6,28,7,15,0), WorkersNeeded=6, Workers=new List<Worker>(6)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Balaton Sound", Date=new DateTime(2023,6,29,7,15,0), WorkersNeeded=6, Workers=new List<Worker>(6)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Balaton Sound", Date=new DateTime(2023,6,30,7,15,0), WorkersNeeded=6, Workers=new List<Worker>(6)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Balaton Sound", Date=new DateTime(2023,7,01,7,15,0), WorkersNeeded=6, Workers=new List<Worker>(6)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,7,10,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,7,11,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,7,12,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,7,13,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,7,14,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,7,15,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,7,16,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,7,17,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,7,18,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,7,19,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,7,20,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,7,21,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,7,22,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,7,23,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,7,24,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,7,25,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,7,26,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,7,27,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,7,28,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,7,29,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,7,30,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,7,31,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,01,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,02,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,03,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,04,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,05,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,06,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,07,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,08,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,09,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,10,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,11,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,12,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,13,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,14,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,15,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,16,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Sziget", Date=new DateTime(2023,8,17,7,15,0), WorkersNeeded=8, Workers=new List<Worker>(8)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="20.-i tüzijáték", Date=new DateTime(2023,8,18,7,15,0), WorkersNeeded=5, Workers=new List<Worker>(5)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="20.-i tüzijáték", Date=new DateTime(2023,8,19,7,15,0), WorkersNeeded=5, Workers=new List<Worker>(5)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="20.-i tüzijáték", Date=new DateTime(2023,8,20,7,15,0), WorkersNeeded=5, Workers=new List<Worker>(5)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,8,21,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,8,22,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,8,23,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,8,24,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,8,25,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,8,26,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,8,27,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,8,28,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,8,29,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,8,30,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)},
                new Job(){Uid= Guid.NewGuid().ToString(),Name ="Atlétikai VB", Date=new DateTime(2023,8,31,7,15,0), WorkersNeeded=3, Workers=new List<Worker>(3)}
            };



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


            builder.Entity<Job>().HasData(jobs);
        }

    }
}