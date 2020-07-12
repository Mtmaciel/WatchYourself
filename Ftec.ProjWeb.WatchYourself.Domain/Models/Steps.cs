using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ftec.ProjWeb.WatchYourself.Domain.Models
{
    [Table("steps")]
    public class Steps
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [ForeignKey("User")]
        [Column("id_user")]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
    }
}