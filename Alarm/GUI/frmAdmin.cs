using Alarm.BLL;
using Alarm.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm.GUI
{
    public partial class frmAdmin : Form
    {
        private int ID = 0;
        public frmAdmin()
        {
            InitializeComponent();
            cbbSortSound.SelectedIndex = 0;
            cbbSortUser.SelectedIndex = 0;
            ReloadSound();
            ReLoadUser();
        }
        public void ReLoadUser()
        {
            dgv_User.DataSource = BLL_Alarm.Instance.GetAllUser("");
        }
        public void ReloadSound()
        {
            dgv_Sound.DataSource = BLL_Alarm.Instance.GetAllSound();
        }

        private void btnSort1_Click(object sender, EventArgs e)
        {

            if (cbbSortUser.SelectedIndex == 0)
            {
                dgv_User.DataSource = BLL_Alarm.Instance.GetAllUser("Ascending");
            }
            else
            {
                dgv_User.DataSource = BLL_Alarm.Instance.GetAllUser("Descending");
            }

        }

        private void btnAddSound_Click(object sender, EventArgs e)
        {
            string url = "https://tainhacchuong.biz/am-thanh-thong-bao";
            string chromePath = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(chromePath);
            startInfo.Arguments = url;
            Process.Start(startInfo);

            // -- > 

            string Dir = System.IO.Directory.GetCurrentDirectory();
            Dir = Dir.Remove(Dir.LastIndexOf("\\"));
            Dir = Dir.Remove(Dir.LastIndexOf("\\"));
            Dir = Dir + "\\" + "Resources" + "\\" + "sound";

            DirectoryInfo d = new DirectoryInfo(Dir);

            FileInfo[] Files = d.GetFiles("*.mp3");

            List<string> li = new List<string>();

            foreach (FileInfo file in Files)
            {
                string sound = file.Name;
                sound = sound.Remove(sound.LastIndexOf("."));
                if (!BLL_Alarm.Instance.checkExistSound(sound))
                {
                    li.Add(sound);
                }
                //MessageBox.Show(BLL_Alarm.Instance.checkExistSound(sound).ToString());
                //MessageBox.Show(sound + " -- " + BLL_Alarm.Instance.CheckExistSound(id).ToString());
            }
            

            foreach (string sound in li)
            {
                Random rd = new Random();
                int r;
                do
                {
                    r = 0;
                    r = rd.Next(0, 100);
                } while (BLL_Alarm.Instance.GetSoundById(r) != null);
                this.ID = r;




                Sound s = new Sound
                {
                    Id_Sound = this.ID,
                    SoundName = sound
                };
                BLL_Alarm.Instance.AddSound(s);
                ReloadSound();
            }
        }
    }
}
