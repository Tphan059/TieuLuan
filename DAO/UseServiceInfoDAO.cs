using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UseServiceInfoDAO
    {
        private static UseServiceInfoDAO instance;
        public static UseServiceInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UseServiceInfoDAO();
                return instance;
            }
            private set
            {
                UseServiceInfoDAO.instance = value;
            }
        }
        public UseServiceInfoDAO() { }

        public List<UseServiceInfo> GetUseServiceInfoByBook(int idBook)
        {
            List<UseServiceInfo> infos = new List<UseServiceInfo>();
            string query = "exec USP_GetAllUseServiceInfo @idBook";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {idBook});
            foreach (DataRow row in data.Rows) 
            {
                UseServiceInfo item = new UseServiceInfo(row);
                infos.Add(item);
            }
            return infos;
        }

        public List<UseServiceInfo> GetUseServiceInfoByBook1(int idBook)
        {
            List<UseServiceInfo> infos = new List<UseServiceInfo>();
            string query = "exec USP_GetAllUseServiceInfo1 @idBook";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idBook });
            foreach (DataRow row in data.Rows)
            {
                UseServiceInfo item = new UseServiceInfo(row);
                infos.Add(item);
            }
            return infos;
        }
    }
}
