using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelAlarm db = new ModelAlarm();
            dataGridView1.DataSource = db.Accounts.Select(p => new {p.Username, p.Password, p.Role }).ToList();
        }
    }
}
