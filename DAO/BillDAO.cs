using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if(instance == null)
                    instance = new BillDAO();
                return instance;
            }
            private set
            {
                BillDAO.instance = value;
            }
        }
        public BillDAO() { }

        public DataTable GetRoomCharge (int idBook, int idRoom)
        {
            string query = "exec USP_GetRoomCharge @idBooking , @idRoom";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {idBook, idRoom});
            return data;
        }

        public void InsertBill (int idBook, int idRoom, int idNV, float total, float roomCharge, float totalServ, float arise, float pay, float payment )
        {
            string query = "exec USP_InsertBill @idBooking , @idRoom , @idNV , @total , @roomCharge , @totalServ , @arise , @pay , @payment";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] {idBook, idRoom, idNV, total, roomCharge, totalServ,arise,pay, payment});
            
        }
        
        public DataTable GetAllBill()
        {
            string query = "exec USP_GetAllBill";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchBill(DateTime from, DateTime to)
        {
            string query = "exec USP_SearchBill @from , @to";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {from, to});
        }
    }
}
