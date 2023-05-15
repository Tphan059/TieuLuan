using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;
        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBUS();
                return instance;
            }
            private set
            {
                AccountBUS.instance = value;    
            }
        }
        private AccountBUS() { }

        public bool Login (string userName, string password)
        {
            
            return AccountDAO.Instance.Login(userName, password);
        }

        public bool ChangePassword(string userName, string password)
        {

            return AccountDAO.Instance.ChangePassword(userName, password);
        }

        public List<Account> GetAccountByIdNV(int idNV)
        {
            return AccountDAO.Instance.GetAccountsByIdNV(idNV);
        }

        public void Login1(string userName, string password, int idPer, Form form, Form form1)
        {
            if (AccountDAO.Instance.Login(userName, password))
            {                  
                    form.Hide();
                    form1.ShowDialog();
                //AdminForm mainAdmin = new AdminForm();
                
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        public void ChangePassword1(string userName, string password, Form form)
        {
            if (AccountDAO.Instance.ChangePassword(userName, password))
            {
                MessageBox.Show("Thay đổi mật khẩu thành công");
                form.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ");
            }
        }

        public int GetIdNV(string userName)
        {
            DataRow row = AccountDAO.Instance.GetAccountByUserName(userName).Rows[0];
           
            return Convert.ToInt32(row["idNV"]);
        }

        public string GetUserName(int id)
        {
            DataRow row = AccountDAO.Instance.GetAccountsIdNV(id).Rows[0];
            return row["userName"].ToString();
        }
    }
}
