using Ftec.ProjWeb.WatchYourself.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ftec.ProjWeb.WatchYourself.Repository
{
    public class WatchYourselfDbContext:DbContext
    {
        public WatchYourselfDbContext() : base("PgWatchyourself"){}

        public DbSet<Goal> Goals { get; set; }
        public DbSet<HeartBeat> HeartBeats { get; set; }
        public DbSet<Steps> Steps { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<WatchYourselfDbContext>(null);
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Goal>().ToTable("goals", "public");
            modelBuilder.Entity<HeartBeat>().ToTable("heartbeats", "public");
            modelBuilder.Entity<Steps>().ToTable("steps", "public");
            modelBuilder.Entity<User>().ToTable("users", "public");
        }

    }
}
