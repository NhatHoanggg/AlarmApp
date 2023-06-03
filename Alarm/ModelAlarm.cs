using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Alarm
{
    public partial class ModelAlarm : DbContext
    {
        public ModelAlarm()
            : base("name=ModelAlarm")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
