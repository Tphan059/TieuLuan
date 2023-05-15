using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class User_PerDAO
    {
        private static User_PerDAO instance;
        public static User_PerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new User_PerDAO();
                return instance;
            }
            private set
            {
                User_PerDAO.instance = value;
            }
        }

        public User_PerDAO() { }

        public DataTable GetIdPer(string userName)
        {
            string query = "exec USP_GetIdPerByUserName @userName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {userName});
            return data;
        }
    }
}
