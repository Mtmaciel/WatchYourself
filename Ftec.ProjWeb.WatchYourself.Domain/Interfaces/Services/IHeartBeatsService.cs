using Ftec.ProjWeb.WatchYourself.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ftec.ProjWeb.WatchYourself.Domain.Interfaces.Services
{
    public interface IHeartBeatsService
    {
        bool InsertData(SmartWatchData data);
    }
}
