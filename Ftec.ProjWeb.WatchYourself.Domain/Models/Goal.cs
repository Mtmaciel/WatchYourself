using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ftec.ProjWeb.WatchYourself.Domain.Models
{
    [Table("goals")]
    public class Goal
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [ForeignKey("User")]
        [Column("user_id")]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("type")]
        public int Type { get; set; }
        [Column("difficulty")]
        public int Difficulty { get; set; }
        [Column("dashboard_type")]
        public int DashBoardType { get; set; }
        [Column("start_date")]
        public DateTime StartDate { get; set; }
        [Column("end_date")]
        public DateTime? EndDate { get; set; }

    }
}