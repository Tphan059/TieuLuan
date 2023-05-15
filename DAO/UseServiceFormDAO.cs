using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UseServiceFormDAO
    {
        private static UseServiceFormDAO instance;
        public static UseServiceFormDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UseServiceFormDAO();
                return instance;
            }
            private set
            {
                UseServiceFormDAO.instance = value;
            }
        }
        private UseServiceFormDAO() { }

        public int GetUnCheckUseServiceForm(int idBook)
        {
            string query = "exec USP_GetUnCheckUserServiceForm @idBook";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {idBook});

            if(data.Rows.Count > 0) 
            {
                UseServiceForm serviceForm = new UseServiceForm(data.Rows[0]);
                return serviceForm.IdForm;
            }
            return -1;
        }

        public void InserUseServiceForm(int idBook, int idServ, int quantity)
        {
            string query = "exec USP_InsertUseServiceForm @idBook , @idServ , @count";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBook , idServ, quantity }); 
        }
    }
}
