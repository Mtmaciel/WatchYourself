using System;


namespace Ftec.ProjWeb.WatchYourself.Domain.Models
{
    public class SmartWatchData
    {

        public int HEART_RATE { get; set; }
        public int STEPS { get; set; }
        public DateTime DATE { get; set; }
        public Guid UserId { get; set; }
    }
}
