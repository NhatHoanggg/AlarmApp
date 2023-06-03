using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm.GUI
{
    public partial class frmUserAdd : Form
    {
        public frmUserAdd()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime d = datePicker.Value;
            DateTime t = timePicker.Value;
            TimeSpan ts = t.TimeOfDay;
            MessageBox.Show(d.Date.ToString("M/d/yyyy")) ;
        }
    }
}
