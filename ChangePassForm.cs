using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace TieuLuan
{
    public partial class ChangePassForm1 : Form
    {
        public ChangePassForm1()
        {
            InitializeComponent();
            
        }


        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtUserName.ForeColor = Color.White;
                label4.Visible = false;
            }
            catch { }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtUserName.ForeColor = Color.White;
                label5.Visible = false;
                TxtPassword.UseSystemPasswordChar = true;
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.ForeColor = Color.White;
                label6.Visible = false;
                textBox1.UseSystemPasswordChar = true;
            }
            catch { }
        }

        private void TxtUserName_Click(object sender, EventArgs e)
        {
            TxtUserName.SelectAll();
        }

        private void TxtPassword_Click(object sender, EventArgs e)
        {
            TxtPassword.SelectAll();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string userName = TxtUserName.Text;
            string password = TxtPassword.Text;
            if (TxtUserName.Text == "Enter User Name" ||  TxtUserName.Text == "")
            {
                label4.Visible = true;
                return;
            }
            if (TxtPassword.Text == "Password" || TxtPassword.Text == "")
            {
                label5.Visible = true;
                return;
            }
            if (textBox1.Text == "Password" || textBox1.Text == "")
            {
                label6.Visible = true;
                return;
            }
            if (TxtPassword.Text == textBox1.Text)
            {
                
                AccountBUS.Instance.ChangePassword1(userName, password, this);
            }
            else
            {
                MessageBox.Show("Mật khẩu không giống nhau");
            }
        }

        private void BtnLogin_MouseDown(object sender, MouseEventArgs e)
        {
            BtnLogin.ForeColor = Color.Black;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            BtnLogin.ForeColor = Color.FromArgb(192, 0, 192);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
