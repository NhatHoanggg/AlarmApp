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
            //dgv_Sound.DataSource = BLL_Alarm.Instance.GetScheduleBySoundName("baothuc_1");
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete user?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //MessageBox.Show("YES");
                if (dgv_User.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in dgv_User.SelectedRows)
                    {
                        BLL_Alarm.Instance.DelUser(i.Cells[0].Value.ToString());
                    }
                }
                ReLoadUser();
                MessageBox.Show("Delete User Success!", 
                    "SUCCESS!!!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }

            else
            {

            }
            
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
                //MessageBox.Show(this.ID.ToString() + sound);
                ReloadSound();
            }
            ReloadSound();
        }

        private void btnDeleteSound_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure to delete sound?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //MessageBox.Show("YES");

                    string Dir = System.IO.Directory.GetCurrentDirectory();
                    Dir = Dir.Remove(Dir.LastIndexOf("\\"));
                    Dir = Dir.Remove(Dir.LastIndexOf("\\"));
                    Dir = Dir + "\\" + "Resources" + "\\" + "sound";

                    if (dgv_Sound.SelectedRows.Count > 0)
                    {
                        foreach (DataGridViewRow i in dgv_Sound.SelectedRows)
                        {
                            string filePath = Dir + "\\" + i.Cells[1].Value.ToString() + ".mp3";

                            BLL_Alarm.Instance.DelSound((int)i.Cells[0].Value);
                            ReloadSound();

                            if (File.Exists(filePath))
                            {
                                File.Delete(filePath); // Xóa tệp tin
                            }
                            else
                            {
                            //MessageBox.Show("Không tìm thấy tệp tin!");
                            MessageBox.Show("NOT FOUND!!!", 
                                "NOT FOUND!!!", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            }
                        }
                    }

                    ReloadSound();
                    MessageBox.Show("Delete User Success!",
                        "SUCCESS!!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
        }

        private void btnSort2_Click(object sender, EventArgs e)
        {
            if (cbbSortSound.SelectedIndex == 0)
            {
                dgv_Sound.DataSource = BLL_Alarm.Instance.GetSoundTable("Ascending");
                dgv_Sound.Columns[0].HeaderText = "Value";
                dgv_Sound.Columns[1].HeaderText = "SoundName";

            }
            else
            {
                dgv_Sound.DataSource = BLL_Alarm.Instance.GetSoundTable("Descending");
                dgv_Sound.Columns[0].HeaderText = "Value";
                dgv_Sound.Columns[1].HeaderText = "SoundName";
            }

        }
    }
}
