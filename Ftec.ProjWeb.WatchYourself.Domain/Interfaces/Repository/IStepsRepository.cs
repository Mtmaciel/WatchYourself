using Ftec.ProjWeb.WatchYourself.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ftec.ProjWeb.WatchYourself.Domain.Interfaces.Repository
{
    public interface IStepsRepository
    {
        List<Steps> List(Guid id, DateTime? start, DateTime? end);

        int Insert(Steps steps);

        int InsertList(List<Steps> steps);

        int Delete(Guid id);
    }
}
