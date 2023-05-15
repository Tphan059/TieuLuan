using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ServiceDAO
    {   
        private static ServiceDAO instance;
        public static ServiceDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServiceDAO();
                return instance;
            }
            private set
            {
                ServiceDAO.instance = value;
            }
            
        }

        public ServiceDAO() { }

        public List<Service> GetAllService()
        { 
            List<Service> list = new List<Service>();
            string query = "Select * from dbo.Service where statusServ = 1";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in dataTable.Rows) 
            {
                Service service = new Service(row);
                list.Add(service);
            }
            return list;
        }

        public List<Service> GetServiceListByIdST(int idST) 
        {
            List<Service> list = new List<Service>();
            string query = "Select * from dbo.Service where statusServ = 1 and idST = " + idST;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Service service = new Service(row);
                list.Add(service);
            }
            return list;
        }

        public DataTable GetAllServiceDtgv()
        {
            string query = "exec USP_GetAllService ";
            return DataProvider.Instance.ExecuteQuery(query);
            
        }

        public bool UpdateService(int id, string name, int idST, string unit, float price)
        {
            string query = "exec USP_UpdateService @id , @name , @idST , @price , @unit ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, idST, price, unit });
            return result > 0;
        }

        public bool InsertService(string name, int idST, string unit, float price)
        {
            string query = "exec USP_InsertService  @name , @idST , @price , @unit ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {  name, idST, price, unit });
            return result > 0;
        }

        public DataTable SearchService(string name, int idST)
        {
            string query = "exec USP_SearchService @nameServ , @idRT    ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {name, idST});
        }

        public bool DeleteService(int id)
        {
            string query = "exec USP_DeleteService  @id ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id});
            return result > 0;
        }
    }
}
