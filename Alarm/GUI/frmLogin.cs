using Alarm.BLL;
using Alarm.GUI;
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

namespace Alarm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //Hash password to MD5 
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

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string password = GetMD5(txtPw.Text);
            
            // check username + password ->
            // if exist -> role = admin/user -> 
            if (string.IsNullOrEmpty(txtPw.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Complete information!" , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPw.Text = "";
                txtUsername.Text = "";
                txtUsername.Focus();
            }

            else
            {

                int kq = BLL_Alarm.Instance.CheckValidate(txtUsername.Text, password);
                if (kq == 1)
                {
                    try
                    {
                        using (frmAdmin f = new frmAdmin())
                        {
                            MessageBox.Show("SUCCESS!", "SUCCESS!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            f.ShowDialog();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (kq == 2)
                {
                    try
                    {
                        using (frmUser_main f = new frmUser_main(txtUsername.Text))
                        {
                            MessageBox.Show("SUCCESS!", "SUCCESS!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            f.ShowDialog();
                            this.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Account does not exist!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtUsername.Text = "";
                    txtPw.Text = "";
                }
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.ShowDialog();
            this.Close();
        }

        private void rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn.Checked)
            {
                txtPw.PasswordChar = (char)0;
            }
            else
            {
                txtPw.PasswordChar = '•';
            }
        }
    }
}
