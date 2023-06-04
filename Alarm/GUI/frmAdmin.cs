using Alarm.BLL;
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
            dgv_User.DataSource = BLL_Alarm.Instance.GetAllUser();
        }
        public void ReloadSound()
        {
            dgv_Sound.DataSource = BLL_Alarm.Instance.GetAllSound();
        }

        private void btnSort1_Click(object sender, EventArgs e)
        {

            if (cbbSortUser.SelectedIndex == 0)
            {
                //dgv_Sound.DataSource = BLL_Alarm.Instance;
            }
            else
            {
            }

        }


        public void checkSoundCBB()
        {
            string Dir = System.IO.Directory.GetCurrentDirectory();
            Dir = Dir.Remove(Dir.LastIndexOf("\\"));
            Dir = Dir.Remove(Dir.LastIndexOf("\\"));
            Dir = Dir + "\\" + "Resources" + "\\" + "sound";

            DirectoryInfo d = new DirectoryInfo(Dir);

            FileInfo[] Files = d.GetFiles("*.mp3");
            int id = 0;

            foreach (FileInfo file in Files)
            {
                string sound = file.Name;
                sound = sound.Remove(sound.LastIndexOf("."));
                //li.Add(sound);
                MessageBox.Show(sound + " -- " + BLL_Alarm.Instance.CheckExistSound(id).ToString());
            }
        }

        private void btnAddSound_Click(object sender, EventArgs e)
        {
            string url = "https://tainhacchuong.biz/am-thanh-thong-bao";
            string chromePath = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(chromePath);
            startInfo.Arguments = url;
            Process.Start(startInfo);
            checkSoundCBB();
        }
    }
}
