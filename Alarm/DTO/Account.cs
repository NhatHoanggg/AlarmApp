using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm.DTO
{
    [Table ("Account")]
    public class Account
    {
        public Account() 
        {
            this.Schedules = new HashSet<Schedule>();
        }

        [Key]
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(255)]
        public string Password { get; set; }
        [Required]
        public string Role {get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
