using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ServiceTypeDAO
    {
        private static ServiceTypeDAO instance;
        public static ServiceTypeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServiceTypeDAO();
                return instance;
            }
            private set
            {
                ServiceTypeDAO.instance = value;
            }
        }
        public ServiceTypeDAO() { }

        public List<ServiceType> GetServiceTypes() 
        {
            List<ServiceType> services = new List<ServiceType>();
            string query = "select * from dbo.ServiceType where statusST = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows) 
            {
                ServiceType serviceType = new ServiceType(row);
                services.Add(serviceType);
            }
            return services;
        }

        public DataTable GetServiceTypesDT()
        {

            string query = "select idST as 'ID' , nameST as 'Loại dịch vụ' from dbo.ServiceType where statusST = 1";
            return DataProvider.Instance.ExecuteQuery(query);
             
        }
    }
}
