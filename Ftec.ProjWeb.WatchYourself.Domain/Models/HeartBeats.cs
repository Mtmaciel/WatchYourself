using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ftec.ProjWeb.WatchYourself.Domain.Models
{
    public class HeartBeat
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int Frequency { get; set; }
        public DateTime Date { get; set; }
    }
}