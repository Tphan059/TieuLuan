using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UseServiceDAO
    {
        private static UseServiceDAO instance;
        public static UseServiceDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UseServiceDAO();
                return instance;
            }

            private set 
            {
                UseServiceDAO.instance = value;
            }
        }
        public UseServiceDAO() { }

        public void DeleteUseServiceByIdServ(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.UseService Where idServ = " + id);
        }

        public List<UseService> GetUseServicesInfo(int idForm)
        {
            List<UseService> useServicesList = new List<UseService>();
            string query = "exec  USP_GetAllUseServiceByIdForm @idForm";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idForm });
            foreach (DataRow row in data.Rows)
            {
                UseService useService = new UseService(row);
                useServicesList.Add(useService);
            }
            return useServicesList;
        }

        public void InsertUseService (int idForm, int idServ, int quantity)
        {
            string query = "exec USP_InserUseService @idForm , @idServ , @quantity";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] {idForm, idServ, quantity});
        }
    }
}
