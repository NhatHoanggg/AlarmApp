using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alarm.BLL;
using Alarm.DTO;
using WMPLib;

namespace Alarm.GUI
{
    public partial class frmUser_main : Form
    {
        private string UserName;
        public frmUser_main(string UserName)
        {
            this.UserName = UserName;
            InitializeComponent();
            lbClock.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            GUI();
            run();          
        }
        public void play(string url, string timestart)
        {
            
            string[] arr = timestart.Split(':');

            var timer = new System.Timers.Timer(1000);

            timer.Elapsed += (sender, e) =>
            {
                DateTime now = DateTime.Now;

                if (now.Hour.ToString() == arr[0] && now.Minute.ToString() == arr[1] && now.Second.ToString() == arr[2])
                {
                    //MessageBox.Show(url);
                    WindowsMediaPlayer player = new WindowsMediaPlayer();
                    player.URL = url;
                    player.controls.play();
                }
            };

            timer.Start();
        }
        public void run()
        {
            DateTime now = DateTime.Now;

            List<string> list = new List<string>();
            for (int i = 0; i < dgv1.Rows.Count ; i++)
            {
                DataGridViewRow row = dgv1.Rows[i];
                string cellValue = row.Cells["SoundName"].Value.ToString();

                string Dir = System.IO.Directory.GetCurrentDirectory();
                Dir = Dir.Remove(Dir.LastIndexOf("\\"));
                Dir = Dir.Remove(Dir.LastIndexOf("\\"));
                Dir = Dir + "\\" + "Resources" + "\\" + "sound";
                string url = Dir + "\\" + cellValue + ".mp3";

                string datestart = row.Cells["DateStart"].Value.ToString();
                string timestart = row.Cells["TimeStart"].Value.ToString();
                if (datestart == now.Date.ToString())
                {
                    play(url,timestart);
                }
                else
                {

                }
                //MessageBox.Show(url);
            }
            
        }
        public void GUI()
        {
            lbUser.Text = " - USER: " + UserName;
            dgv1.DataSource = BLL_Alarm.Instance.GetScheduleByUserName(UserName);
        }
        public void ReLoadDGV()
        {
            dgv1.DataSource = BLL_Alarm.Instance.GetScheduleByUserName(UserName);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using(frmUserAdd f = new frmUserAdd(this.UserName, 0))
                {
                    f.d = new frmUserAdd.MyDel(ReLoadDGV);
                    f.ShowDialog();
                    this.OnLoad(e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            run();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmUserAdd f = new frmUserAdd(this.UserName, (int)dgv1.SelectedRows[0].Cells["Id"].Value))
                {
                    f.d = new frmUserAdd.MyDel(ReLoadDGV);
                    f.ShowDialog();
                    this.OnLoad(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            run();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete these schedules?", 
                "Confirm", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgv1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in dgv1.SelectedRows)
                    {
                        BLL_Alarm.Instance.DelSchedule((int)i.Cells["Id"].Value);
                    }
                }
                ReLoadDGV();
                this.OnLoad(e);
                run();
            }
            run();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
