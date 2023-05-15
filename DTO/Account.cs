using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string _userName;
        private int _idNV;
        private string _password;
        private bool _statusAcc;
        public string UserName { get { return _userName; } set { _userName = value; } }
        public int IdNV { get { return _idNV; } set { _idNV = value; } }
        public string Password { get { return _password; } set {_password = value; } }
        public bool StatusAcc { get { return _statusAcc; } set { _statusAcc = value; } }
        public Account (string userName, int idNV, string password, bool status)
        {
            this.IdNV = idNV;
            this.UserName = userName;
            this.Password = password;
            this.StatusAcc = status;
        }

        public Account (DataRow row)
        {
            this.IdNV = (int)row["idNV"];
            this.UserName = row["userName"].ToString();
            this.Password = row["password"].ToString();
            this.StatusAcc = (bool)row["statusAcc"];
        }
    }
}
