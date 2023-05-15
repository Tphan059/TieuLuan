using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PermisionDAO
    {
        private static PermisionDAO instance;

        public PermisionDAO() { }

        public static PermisionDAO Instance 
        {
            get
            {
                if (instance == null)
                    instance = new PermisionDAO();
                return instance;
            }
            private set => PermisionDAO.instance = value; 
        }

        public DataTable GetPermision()
        {
            string query = "select * from dbo.Permision";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
