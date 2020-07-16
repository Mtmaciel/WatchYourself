using Ftec.ProjWeb.WatchYourself.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ftec.ProjWeb.WatchYourself.Domain.Interfaces.Repository
{
    public interface IGoalRepository
    {
        Goal Select(Guid id);
        List<Goal> List(Guid id);
        int Insert(Goal goal);
        int Delete(Guid id);

    }
}
