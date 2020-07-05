using Ftec.ProjWeb.WatchYourself.Domain.Interfaces.Repository;
using Ftec.ProjWeb.WatchYourself.Domain.Interfaces.Services;
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
    public class StepsService: IStepsService
    {
        private readonly IStepsRepository _repository;

        public StepsService()
        {

            _repository = new StepsRepository(new WatchYourselfDbContext());
        }

        public bool InsertData(SmartWatchData data)
        {
            var step = new Steps()
            {
                Id = new Guid(),
                Date = data.DATE,
                Quantity = data.STEPS,
                UserId = data.UserId
            };

            var result = _repository.Insert(step);

            return result != 0;
        }
    }
}
