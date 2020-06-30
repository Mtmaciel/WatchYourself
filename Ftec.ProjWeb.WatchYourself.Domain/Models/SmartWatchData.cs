using System;


namespace Ftec.ProjWeb.WatchYourself.Domain.Models
{
    public class SmartWatchData
    {
        public int BLOOD_PRESSURE_SISTOLIC { get; set; }
        public int BLOOD_PRESSURE_DIASTOLIC { get; set; }
        public int HEART_RATE { get; set; }
        public int OXYGEN { get; set; }
        public int RESPIRATORY_RATE { get; set; }
        public int SLEEP { get; set; }
        public int STEPS { get; set; }
        public int ULTRAVIOLET_RAYS { get; set; }
        public DateTime DATE { get; set; }
    }
}
