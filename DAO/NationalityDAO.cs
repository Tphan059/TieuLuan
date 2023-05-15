using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NationalityDAO
    {
        private static NationalityDAO instance;
        public static NationalityDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NationalityDAO();
                return instance;
            }

            private set
            {
                NationalityDAO.instance = value;    
            }
        }
        public NationalityDAO() { }

        public DataTable GetNationality()
        {
            return DataProvider.Instance.ExecuteQuery("select * from dbo.Nationality");
        }
    }
}
