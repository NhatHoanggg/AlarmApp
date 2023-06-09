using Alarm.BLL;
using Alarm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Alarm.DAL
{
    public class DAL_Alarm
    {
        private ModelAlarm db = new ModelAlarm();
        private static DAL_Alarm _Instance;
        public static DAL_Alarm Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_Alarm();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_Alarm()
        {

        }
        public int CheckValidate(string UserName,string Password)
        {
            Account a = db.Accounts.Find(UserName);
            if (a != null && a.Password == Password)
            {
                if (a.Role == "admin")
                    return 1;
                return 2;
            }
            return 0;

        }

        public void AddUser(Account ac)
        {
            Account x = db.Accounts.Find(ac.Username);
            if (x == null)
            {
                db.Accounts.Add(ac);
                db.SaveChanges();
            }
        }


        public dynamic GetScheduleByUserName(string UserName)
        {
            return (from p in db.Schedules
                    where p.Username == UserName
                    select new
                    {
                        p.Id,
                        p.Username,
                        p.NameSchedule,
                        p.DateStart,
                        p.TimeStart,
                        p.Sound.SoundName
                    }).ToList();
        }

        public dynamic GetScheduleBySoundName(string soundname)
        {
            return (from p in db.Schedules
                    where p.Sound.SoundName == soundname
                    select new
                    {
                        p.Id,
                        p.Username,
                        p.NameSchedule,
                        p.DateStart,
                        p.TimeStart,
                        p.Sound.SoundName
                    }).ToList();
        }

        public Schedule GetScheduleById(int id)
        {
            return db.Schedules.Find(id);
        }
        public Account GetAccount(string UserName)
        {
            return db.Accounts.Find(UserName);
        }
        public Sound GetSoundByID_Sound(int Id_Sound)
        {
            return db.Sounds.Find(Id_Sound);
        }
        public List<CBBSound> GetAllSound()
        {
            List<CBBSound> data = new List<CBBSound>();
            foreach(Sound i in db.Sounds)
            {
                data.Add(new CBBSound
                {
                    Value = i.Id_Sound,
                    Text = i.SoundName
                });
            }
            
            return data;
        }

        public dynamic GetSoundTable(string order)
        {
            if (order == "Ascending")
                return (from p in db.Sounds
                        orderby p.SoundName ascending
                        select new
                        {
                            p.Id_Sound,
                            p.SoundName
                        }).ToList();
            if (order == "Descending")
                return (from p in db.Sounds
                        orderby p.SoundName descending
                        select new
                        {
                            p.Id_Sound,
                            p.SoundName
                        }).ToList();

            return (from p in db.Sounds
                    select new
                    {
                        p.Id_Sound,
                        p.SoundName
                    }).ToList();
        }

        public dynamic GetAllUser(string order)
        {
            if (order == "Ascending")
                return (from p in db.Accounts
                        where p.Role != "admin"
                        orderby p.Username ascending
                        select new
                        {
                            p.Username,
                            p.Password
                        }).ToList();
            if (order == "Descending")
                return (from p in db.Accounts
                        where p.Role != "admin"
                        orderby p.Username descending
                        select new
                        {
                            p.Username,
                            p.Password
                        }).ToList();
             return (from p in db.Accounts
                        where p.Role != "admin"
                        select new
                        {
                            p.Username,
                            p.Password
                        }).ToList();
        }
        public void AddUpdateSchedule(Schedule s)
        {
            Schedule x = db.Schedules.Find(s.Id);
            if(x == null)
            {
                db.Schedules.Add(s);
                db.SaveChanges();
            }
            else
            {
                x.Id = s.Id;
                x.Username = s.Username;
                x.NameSchedule = s.NameSchedule;
                x.DateStart = s.DateStart;
                x.TimeStart = s.TimeStart;
                x.ID_Sound = s.ID_Sound;
                db.SaveChanges();
            }
        }
        public void DelSchedule(int Id)
        {
            Schedule x = db.Schedules.Find(Id);
            db.Schedules.Remove(x);
            db.SaveChanges();
        }

        public void DelUser(string Username)
        {
            foreach (var i in GetScheduleByUserName(Username))
            {
                DelSchedule(i.Id);
            }
            Account x = db.Accounts.Find(Username);
            db.Accounts.Remove(x);
            db.SaveChanges();
        }

        public void DelSound(string soundname)
        {
            foreach (var i in GetScheduleBySoundName(soundname))
            {
                DelSchedule(i.Id);
            }
            Sound x = db.Sounds.Find(soundname);
            db.Sounds.Remove(x);
            db.SaveChanges();
        }


        public Boolean checkExistSound(string sound)
        {
            using (var db = new ModelAlarm())
            {
                bool exists = db.Sounds.Any(p => p.SoundName == sound );
                return exists;
            }
        }
        public Sound GetSoundById(int id)
        {
            return db.Sounds.Find(id);
        }

        public void AddSound(Sound sound)
        {
            Sound x = db.Sounds.Find(sound.Id_Sound);
            if (x == null)
            {
                db.Sounds.Add(sound);
                db.SaveChanges();
            }
        }

        public void RemoveSound(int id)
        {

        }

    }
}
