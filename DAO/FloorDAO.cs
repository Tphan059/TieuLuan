using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class FloorDAO
    {
        private static FloorDAO instance;
        public static FloorDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new FloorDAO();
                return instance;
            }

            private set
            {
                FloorDAO.instance = value;
            }
        }
        public FloorDAO() { }

        public DataTable GetFloor()
        {
            string query = "select * from dbo.Floor";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
