using Ftec.ProjWeb.WatchYourself.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ftec.ProjWeb.WatchYourself.Domain.Interfaces.Repository
{
    public interface IHeartBeatsRepository
    {
        List<HeartBeat> List(Guid id, DateTime? start, DateTime? end);

        int Insert(HeartBeat heartbeat);

        int InsertList(List<HeartBeat> heartbeat);

         int Delete(Guid id);
    }
}
