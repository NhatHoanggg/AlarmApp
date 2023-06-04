using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm.DTO
{
    [Table("Schedule")]
    public class Schedule
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }
        [ForeignKey("Username")]
        public virtual Account Account { get; set; }
        [Required]
        public string NameSchedule { get; set; }
        public DateTime DateStart { get; set; }
        public TimeSpan TimeStart { get; set; }
        [Required]
        public int ID_Sound { get; set; }
        [ForeignKey("ID_Sound")]
        public virtual Sound Sound { get; set; }
    }
}
