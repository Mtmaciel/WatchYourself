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

    }
}
