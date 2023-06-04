using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm.DTO
{
    [Table("Sound")]
    public class Sound
    {
        public Sound()
        {
            Schedules = new HashSet<Schedule>();
        }

        [Key]
        [Required]
        public int Id_Sound { get; set; }
        [Required]
        public string SoundName { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
