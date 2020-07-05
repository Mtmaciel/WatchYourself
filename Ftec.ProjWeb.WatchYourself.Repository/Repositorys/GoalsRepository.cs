using Ftec.ProjWeb.WatchYourself.Domain.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ftec.ProjWeb.WatchYourself.Repository.Repositorys
{
    public class GoalsRepository
    {
        private WatchYourselfDbContext Context { get; }

        public GoalsRepository(WatchYourselfDbContext Context)
        {
            this.Context = Context;
        }
        public Goal Select(Guid id)
        {
            return Context.Goals.Find(id);
        }

        public List<Goal> List(Guid id)
        {
            return Context.Goals.Where(x => x.UserId.Equals(id)).OrderBy(x => x.Title).ToList();
        }

        public int Insert(Goal goal)
        {
            Context.Goals.Add(goal);
            return Context.SaveChanges();
        }

        public int Delete(Guid id)
        {
            Context.Goals.Remove(Context.Goals.Find(id));
            return Context.SaveChanges();
        }
    }
}
