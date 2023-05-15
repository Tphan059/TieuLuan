using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DeviceDAO
    {
        private static DeviceDAO instance;
        public static DeviceDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DeviceDAO();
                return instance;
            }

            private set
            {
                DeviceDAO.instance = value;
            }
        }
        public DeviceDAO() { }

        public DataTable GetDevice()
        {
            string query = "exec USP_GetDevice";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertDevice(string name, float price, string unit)
        {
            string query = "exec USP_InsertDevice @name , @price , @unit";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, price, unit });
            return result > 0;
        }

        public bool UpdateDevice(int id, string name, float price, string unit)
        {
            string query = "exec USP_UpdateDevice @id , @name , @price , @unit";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, price, unit });
            return result > 0;
        }

        public DataTable SearchByName(string name)
        {
            string query = "exec USP_SearchDeviceByName @name";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }

        public bool DeleteDevice(int id) 
        {
            string query = "exec USP_DeleteDevice @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;

        }
    }
}
