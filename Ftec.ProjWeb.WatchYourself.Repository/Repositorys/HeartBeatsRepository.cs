using Ftec.ProjWeb.WatchYourself.Domain.Interfaces.Repository;
using Ftec.ProjWeb.WatchYourself.Domain.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ftec.ProjWeb.WatchYourself.Repository.Repositorys
{
    public class HeartBeatsRepository: IHeartBeatsRepository
    {
        private WatchYourselfDbContext Context { get; }

        public HeartBeatsRepository(WatchYourselfDbContext Context)
        {
            this.Context = Context;
        }

        public List<HeartBeat> List(Guid id,DateTime? start, DateTime? end)
        {
            return Context.HeartBeats.
                    Where(x => x.UserId.Equals(id) && x.Date.CompareTo(start)>-1 && x.Date.CompareTo(end) < 1).
                    OrderBy(x => x.Date).ToList();
        }

        public int Insert(HeartBeat heartbeat)
        {
            Context.HeartBeats.Add(heartbeat);
            return Context.SaveChanges();
        }

        public int InsertList(List<HeartBeat> heartbeat)
        {
            Context.HeartBeats.AddRange(heartbeat);
            return Context.SaveChanges();
        }

        public int Delete(Guid id)
        {
            Context.HeartBeats.Remove(Context.HeartBeats.Find(id));
            return Context.SaveChanges();
        }
    }
}
