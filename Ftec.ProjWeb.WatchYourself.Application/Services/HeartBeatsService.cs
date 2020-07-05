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
    public class HeartBeatsService: IHeartBeatsService
    {
        private readonly IHeartBeatsRepository _repository;

        public HeartBeatsService()
        {
            _repository = new HeartBeatsRepository(new WatchYourselfDbContext());
        }

        public bool InsertData(SmartWatchData data)
        {
            var beat = new HeartBeat()
            {
                Id = new Guid(),
                Date = data.DATE,
                Frequency = data.HEART_RATE,
                UserId = data.UserId
            };

            var result = _repository.Insert(beat);

            return result != 0;
        }
    }
}
