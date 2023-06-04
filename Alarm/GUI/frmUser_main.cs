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

namespace Alarm.GUI
{
    public partial class frmUser_main : Form
    {
        private string UserName;
        public frmUser_main(string UserName)
        {
            this.UserName = UserName;
            InitializeComponent();
            GUI();
            play();
        }
        public void play()
        {
            DateTime now = DateTime.Now;
            int hour = now.Hour; // Truy cập giờ
            int minute = now.Minute; // Truy cập phút
            int second = now.Second; // Truy cập giây

            List<string> list = new List<string>();
            for (int i = 0; i < dgv1.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dgv1.Rows[i];
                string cellValue = row.Cells["SoundName"].Value.ToString();

                string Dir = System.IO.Directory.GetCurrentDirectory();
                Dir = Dir.Remove(Dir.LastIndexOf("\\"));
                Dir = Dir.Remove(Dir.LastIndexOf("\\"));
                Dir = Dir + "\\" + "Resources" + "\\" + "sound";
                string url = Dir + "\\" + cellValue + ".mp3";


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
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(dgv1.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow i in dgv1.SelectedRows)
                {
                    BLL_Alarm.Instance.DelSchedule((int)i.Cells["Id"].Value);
                }
            }
            ReLoadDGV();
            this.OnLoad(e);
        }
    }
}
