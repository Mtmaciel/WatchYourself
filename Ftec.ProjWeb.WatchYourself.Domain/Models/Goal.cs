using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ftec.ProjWeb.WatchYourself.Domain.Models
{
    public class Goal
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }
        public int Difficulty { get; set; }
        public int DashBoardType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}