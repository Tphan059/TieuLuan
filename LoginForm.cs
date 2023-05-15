using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TieuLuan.Admin;
using BUS;
using TieuLuan.Staff;

namespace TieuLuan
{
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
            InitializeComponent();
            loadLoginForm();
        }

        void loadLoginForm()
        {
            TxtPassword.Clear();
            TxtPassword.Clear();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            string userName = TxtUserName.Text;
            string password = TxtPassword.Text;
            if (TxtUserName.Text == "Enter User Name" || TxtUserName.Text == "")
            {
                label4.Visible = true;
                return;
            }
            
            if (TxtPassword.Text == "")
            {
                label5.Visible = true;
                label5.Text = "Nhập mật khẩu";
                return;
            }
            int idNV = AccountBUS.Instance.GetIdNV(userName);
            int idPer = User_PerBUS.Instance.GetIdPer(userName);
                AdminForm mainAdmin = new AdminForm(idNV);

            AccountBUS.Instance.Login1(userName, password, idPer, this, mainAdmin);
        }


        private void LblRePass_Click(object sender, EventArgs e)
        {
            ChangePassForm1 changePassForm = new ChangePassForm1();
            changePassForm.ShowDialog();
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                
                TxtPassword.ForeColor = Color.White;
                TxtPassword.UseSystemPasswordChar = true;
                label5.Visible = false;
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

        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            BtnLogin.ForeColor = Color.Black;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            BtnLogin.ForeColor = Color.FromArgb(192,0,192);
        }

        private void LblRePass_MouseDown(object sender, MouseEventArgs e)
        {
            LblRePass.ForeColor = Color.FromArgb(192,0,192);
        }

        private void LblRePass_MouseLeave(object sender, EventArgs e)
        {
            LblRePass.ForeColor = Color.White;
        }

        private void LblRePass_MouseHover(object sender, EventArgs e)
        {
            LblRePass.ForeColor= Color.FromArgb(192, 155, 243);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Red;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(17, 53, 71);
        }
    }
}
