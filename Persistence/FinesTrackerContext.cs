using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Persistence.Configurations;

namespace Persistence
{
    public partial class FinesTrackerContext : DbContext
    {
        public FinesTrackerContext()
        {
        }

        public FinesTrackerContext(DbContextOptions<FinesTrackerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Fines> Fines { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<FinePost> FinePosts { get; set; }
        public virtual DbSet<Vote> Votes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            if (!optionsBuilder.IsConfigured)

                optionsBuilder.UseSqlServer("Server=JACOBMUZ-PC;Database=FinesTracker;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FinesConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new FinePostConfiguration());
            modelBuilder.ApplyConfiguration(new VoteConfiguration());
        }
    }
}
