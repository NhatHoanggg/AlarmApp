using Alarm.BLL;
using Alarm.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm.GUI
{
    public partial class frmUserAdd : Form
    {
        public delegate void MyDel();
        public MyDel d { get; set; }
        private int Id;
        private string UserName;
        public frmUserAdd(string UserName, int Id)
        {
            this.UserName = UserName;
            this.Id = Id;
            InitializeComponent();
            ReloadCBB();
            GUI();
        }
        public void ReloadCBB()
        {
            cbbSound.Items.Clear();
            cbbSound.Items.AddRange(BLL_Alarm.Instance.GetAllSound().ToArray());
            cbbSound.SelectedIndex = 0;
        }
        public void GUI()
        {
            lbUsername.Text = " - USER: " + UserName;
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm:ss";
            if (Id != 0)
            {
                datePicker.Value = BLL_Alarm.Instance.GetScheduleById(Id).DateStart;
                timePicker.Text = BLL_Alarm.Instance.GetScheduleById(Id).TimeStart.ToString();
                foreach(CBBSound i in cbbSound.Items)
                {
                    if(i.Value == BLL_Alarm.Instance.GetScheduleById(Id).ID_Sound)
                    {
                        cbbSound.SelectedItem = i;
                    }
                }
            }
            else
            {
                Random rd = new Random();
                int r;
                do
                {
                    r = 0;
                    r = rd.Next(0, 100);
                } while (BLL_Alarm.Instance.GetScheduleById(r) != null);
                this.Id = r;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameSchedule.Text))
            {
                MessageBox.Show("Please Complete All Information");
                txtNameSchedule.Focus();
            }
            else
            {
                DateTime dt = DateTime.Parse(datePicker.Value.ToShortDateString());

                Schedule s = new Schedule
                {
                    Id = this.Id,
                    Username = this.UserName,
                    NameSchedule = txtNameSchedule.Text,
                    DateStart = dt,
                    TimeStart = new TimeSpan(timePicker.Value.Hour, timePicker.Value.Minute, timePicker.Value.Second),
                    ID_Sound = ((CBBSound)cbbSound.SelectedItem).Value
                };
                BLL_Alarm.Instance.AddUpdateSchedule(s);
                d();
                this.Dispose();       
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
