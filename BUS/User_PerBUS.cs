using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class User_PerBUS
    {   
        private static User_PerBUS instance;
        public static User_PerBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new User_PerBUS();
                return instance;
            }
            private set
            {
                User_PerBUS.instance = value;
            }
        }

        public User_PerBUS() { }

        public int GetIdPer(string userName)
        {
            DataRow row = User_PerDAO.Instance.GetIdPer(userName).Rows[0];
            return Convert.ToInt32(row["idPer"]);
        }


    }
}
