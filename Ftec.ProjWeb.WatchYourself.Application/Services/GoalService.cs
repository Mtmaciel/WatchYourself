using Ftec.ProjWeb.WatchYourself.Domain.Interfaces.Repository;
using Ftec.ProjWeb.WatchYourself.Domain.Models;
using Ftec.ProjWeb.WatchYourself.Repository;
using Ftec.ProjWeb.WatchYourself.Repository.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ftec.ProjWeb.WatchYourself.Application.Services
{
    public class GoalService
    {
        private readonly IGoalRepository _repository;
 
        public GoalService(){
            _repository = new GoalsRepository(new WatchYourselfDbContext());
        }

        public List<Goal> List(Guid userId)
        {
            var list = new List<Goal>(); 
            return list;
        }

        public Goal Select(Guid id)
        {
            var goal = new Goal();
            return goal;
        }

        public bool Insert(Goal goal)
        {
            return true;
        }

        public bool Delete(Guid id)
        {
            return true;
        }

        public bool Update(Goal goal)
        {
            return true;
        }

    }
}
