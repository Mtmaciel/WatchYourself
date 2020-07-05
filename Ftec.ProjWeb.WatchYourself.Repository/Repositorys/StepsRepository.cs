using Ftec.ProjWeb.WatchYourself.Domain.Interfaces.Repository;
using Ftec.ProjWeb.WatchYourself.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ftec.ProjWeb.WatchYourself.Repository.Repositorys
{
    public class StepsRepository : IStepsRepository
    {
        private WatchYourselfDbContext Context { get; }

        public StepsRepository(WatchYourselfDbContext Context)
        {
            this.Context = Context;
        }

        public List<Steps> List(Guid id, DateTime? start, DateTime? end)
        {
            return Context.Steps.
                    Where(x => x.UserId.Equals(id) && x.Date.CompareTo(start) > -1 && x.Date.CompareTo(end) < 1).
                    OrderBy(x => x.Date).ToList();
        }

        public int Insert(Steps steps)
        {
            Context.Steps.Add(steps);
            return Context.SaveChanges();
        }

        public int InsertList(List<Steps> steps)
        {
            Context.Steps.AddRange(steps);
            return Context.SaveChanges();
        }

        public int Delete(Guid id)
        {
            Context.Steps.Remove(Context.Steps.Find(id));
            return Context.SaveChanges();
        }
    }
}
