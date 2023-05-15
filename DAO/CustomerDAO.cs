using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance 
        { 
            get 
            {
                if (instance == null)
                    instance = new CustomerDAO();
                return instance;
            }
            private set
            {
                CustomerDAO.instance = value;
            }
        }
        public CustomerDAO() { }

        public DataTable GetCustomerById(int id) 
        {
            string query = "exec USP_GetCustomerById @idCus";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] {id});
            return dataTable;
        }

        public DataTable GetCustomer() 
        {
            string query = "exec USP_GetCustomer";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertCustomer(string name, string email, string address, bool sex, string cccd, string phone, int idNa)
        {
            string query = "USP_InsertCustomer @nameCus  , @emailCus , @addressCus , @sexCus , @idCard , @phoneCus , @idNa ";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] {name,email,address,sex,cccd,phone,idNa});
            return result > 0;
        }

        public bool UpdateCustomer(int id, string name, string email, string address, bool sex, string cccd, int idNa, string phone)
        {
            string query = "USP_UpdateCustomer @id , @name , @email , @address , @sex , @cccd , @idNa , @phone ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {id, name,email,address,sex,cccd,idNa, phone });
            return result > 0;
        }

        public DataTable SearchCustomer(string name, string phone)
        {
            string query = "exec USP_SearchCustomer @name , @phone";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {name,phone});
        }

        public DataTable GetCustomerByPhone(string phone)
        {
            string query = "select * from dbo.Customer where phoneCus = N'" + phone + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool DeleteCustomer(int id)
        {
            string query = "USP_DeletwCustomer @id  ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
    }
}
