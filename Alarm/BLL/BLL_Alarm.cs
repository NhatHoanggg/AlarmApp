using Alarm.DAL;
using Alarm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm.BLL
{
    public class BLL_Alarm
    {
        private static BLL_Alarm _Instance;
        public static BLL_Alarm Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Alarm();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_Alarm()
        {

        }
        // 
        public int CheckValidate(string UserName, string Password)
        {
            return DAL_Alarm.Instance.CheckValidate(UserName, Password);
        }
        public Account GetAccount(string UserName)
        {
            return DAL_Alarm.Instance.GetAccount(UserName);
        }

        public dynamic GetScheduleByUserName(string UserName)
        {
            return DAL_Alarm.Instance.GetScheduleByUserName(UserName);
        }

        public Schedule GetScheduleById(int id)
        {
            return DAL_Alarm.Instance.GetScheduleById(id);
        }

        public Sound GetSoundByID_Sound(int Id_Sound)
        {
            return BLL_Alarm.Instance.GetSoundByID_Sound(Id_Sound);
        }

        // -> view 
        public List<CBBSound> GetAllSound()
        {
            return DAL_Alarm.Instance.GetAllSound();
        }
        public dynamic GetSoundTable(string order)
        {
            return DAL_Alarm.Instance.GetSoundTable(order);
        }
        public dynamic GetAllUser(string order)
        {
            return DAL_Alarm.Instance.GetAllUser(order);
        }

        public void AddUpdateSchedule(Schedule s)
        {
            DAL_Alarm.Instance.AddUpdateSchedule(s);
        }

        public void DelSchedule(int Id)
        {
            DAL_Alarm.Instance.DelSchedule(Id);
        }

        public void AddUser(Account ac)
        {
            DAL_Alarm.Instance.AddUser(ac);
        }

        public void DelUser(string Username)
        {
            DAL_Alarm.Instance.DelUser(Username);
        }

        public Boolean checkExistSound(string sound)
        {
            return DAL_Alarm.Instance.checkExistSound(sound);
        }

        public Sound GetSoundById(int id)
        {
            return DAL_Alarm.Instance.GetSoundById(id);
        }

        public void AddSound(Sound sound)
        {
           DAL_Alarm.Instance.AddSound(sound);
        }

        public void DelSound(string soundname)
        {
            DAL_Alarm.Instance.DelSound(soundname);
        }

    }
}
