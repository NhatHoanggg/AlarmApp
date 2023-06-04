using Alarm.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    public class CreateDB :
        //DropCreateDatabaseAlways<ModelAlarm>
        CreateDatabaseIfNotExists<ModelAlarm>
    {
        protected override void Seed(ModelAlarm context)
        {
            context.Accounts.AddRange(new Account[]
            {
                new Account
                {
                    Username = "admin1",
                    Password = "202CB962AC59075B964B07152D234B70",
                    Role = "admin"
                    //hash: 123
                },

                new Account
                {
                    Username = "user1",
                    Password = "202CB962AC59075B964B07152D234B70",
                    //hash: 123
                    Role = "user"
                },

                new Account
                {
                    Username = "user2",
                    Password = "202CB962AC59075B964B07152D234B70",
                    //hash: 123
                    Role = "user"
                }
            });


            context.Sounds.AddRange(new Sound[]
            {
                new Sound
                {
                    Id_Sound = 1,
                    SoundName = "baothuc_1"
                },

                new Sound
                {
                    Id_Sound = 2,
                    SoundName = "baothuc_2"
                },

                new Sound
                {
                    Id_Sound = 3,
                    SoundName = "baothuc_3"
                }
            });

            context.Schedules.AddRange(new Schedule[]
            {
                new Schedule
                {
                    Id = 1,
                    Username = "user1",
                    NameSchedule = "test 1 1",
                    DateStart = new DateTime(2023,6,3),
                    TimeStart = new TimeSpan(21,0,0),
                    ID_Sound = 1
                },
                new Schedule
                {
                    Id = 2,
                    Username = "user1",
                    NameSchedule = "test 1 2 ",
                    DateStart = new DateTime(2023,6,3),
                    TimeStart = new TimeSpan(21,15,0),
                    ID_Sound = 2
                },
                new Schedule
                {
                    Id = 3,
                    Username = "user2",
                    NameSchedule = "test 2 2 ",
                    DateStart = new DateTime(2023,6,3),
                    TimeStart = new TimeSpan(21,16,0),
                    ID_Sound = 3
                }

            });
        }
    }
}
