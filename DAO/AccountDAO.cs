using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set
            {
                AccountDAO.instance = value;
            }
        }
        private AccountDAO() { }

        public static string ConvertToBase64AndMd5(string input)
        {
            // Chuyển đổi chuỗi đầu vào thành mảng byte
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            // Chuyển đổi mảng byte sang chuỗi base64
            string base64String = Convert.ToBase64String(inputBytes);

            // Tính mã hash md5 của chuỗi base64
            using (MD5 md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(base64String));

                // Chuyển đổi mã hash sang chuỗi hex
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                string md5String = sb.ToString();

                return md5String;
            }
        }


        public bool Login(string userName, string password) 
        {
            string query = "exec USP_LogIn @username , @password ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, ConvertToBase64AndMd5(password)});
            return result.Rows.Count > 0;
        }

        public bool ChangePassword(string userName, string password)
        {
            string query = "exec USP_GetNewPassword @userName , @password ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, ConvertToBase64AndMd5(password) });
            return result > 0;
        }

        public List<Account> GetAccountsByIdNV(int idNV)
        {
            List<Account> accountList = new List<Account>();
            string query = "exec USP_GetAccountById @inNV";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[]{ idNV});
            foreach (DataRow dr in dt.Rows)
            {
                Account account = new Account(dr);
                accountList.Add(account);
            }

            return accountList;
        }

        public DataTable GetAccountsIdNV(int idNV)
        {

            string query = "exec USP_GetAccountById @inNV";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idNV });



        }


        public DataTable GetAccountByUserName(string userName) 
        {
            string query = "exec USP_GetAccountByUserName @userName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {userName});
            return data;
        }

        
    }
}
