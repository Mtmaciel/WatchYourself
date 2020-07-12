using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ftec.ProjWeb.WatchYourself.Domain.Models
{
    [Table("heartbeat")]
    public class HeartBeat
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [ForeignKey("User")]
        [Column("user_id")]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        [Column("frequency")]
        public int Frequency { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }

    }
}