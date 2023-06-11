using Alarm.BLL;
using Alarm.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Alarm.GUI.frmUserAdd;

namespace Alarm.GUI
{
    public partial class frmSignUp : Form
    {
        //public delegate void MyDel();
        //public MyDel d { get; set; }
        public frmSignUp()
        {
            InitializeComponent();
        }


        private void txtUsername_reg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtPw_res_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtValidate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //Hash password ->> MD5 
        public string GetMD5(string password)
        {
            string str_md5 = "";
            byte[] arr = System.Text.Encoding.UTF8.GetBytes(password);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            arr = my_md5.ComputeHash(arr);

            foreach (byte b in arr)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }
        public void addUser()
        {
            //MessageBox.Show(txtUsername_reg.Text + " // " +GetMD5( txtPw_res.Text));
            Account s = new Account
            {
                Username = txtUsername_reg.Text,
                Password = GetMD5(txtPw_res.Text),
                Role = "user"
            };
            //MessageBox.Show("new: " + " -- " + txtUsername_reg.Text + "//" + txtPw_res.Text);
            BLL_Alarm.Instance.AddUser(s);
            //d();
            MessageBox.Show("Sign Up Success!");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // check empty infomation
            if (string.IsNullOrEmpty(txtUsername_reg.Text) || string.IsNullOrEmpty(txtPw_res.Text) || string.IsNullOrEmpty(txtValidate.Text))
            {
                MessageBox.Show("Please Complete All Information!");
            }
            else
            {

                // check password
                if (txtPw_res.Text != txtValidate.Text)
                {
                    MessageBox.Show("Invalid password!");
                    txtPw_res.Text = "";
                    txtValidate.Text = "";
                    txtPw_res.Focus();
                }

                else
                {
                    // check exist -> role
                    // kq = 0 -> new user 
                    // kq = 1 -> role: admin
                    // kq = 2 -> role: user
                    int kq = BLL_Alarm.Instance.CheckValidate(txtUsername_reg.Text.Trim(), GetMD5(txtPw_res.Text));

                    // MessageBox.Show(kq.ToString());
                    if (kq != 0)
                    {
                        MessageBox.Show("User already exists!");
                        txtUsername_reg.Focus();
                        txtUsername_reg.Text = "";
                        txtPw_res.Text = "";
                        txtValidate.Text = "";
                    }
                    else
                    {
                        addUser();
                        this.Hide();
                        frmLogin login = new frmLogin();
                        login.ShowDialog();
                        this.Close();
                    }
                }

            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }

        
    }
}
