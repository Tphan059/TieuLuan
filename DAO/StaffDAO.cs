using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;
        public static StaffDAO Instance
        { 
            get 
            { 
                if (instance == null)
                    instance = new StaffDAO();
                return instance; 
            }
            private set
            {
                StaffDAO.instance = value;
            }            
        }
        private StaffDAO() { }
        public DataTable SelectAll()
        {
            string query = "exec USP_GetListStaff";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);           
            return data;
        }

        public DataTable SelectStaffByIdNV (int id) 
        {
            string query = "select * from Staff where idNV = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public bool InsertNewStaff(string name, bool sex, DateTime dob, string addressm, string email, string phone, string userName, int idPer)
        {
            string query = "exec USP_IndertNewUser @nameNV , @sexNV , @datOfBirth , @address , @email , @phone , @userName , @idPer ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, sex, dob, addressm, email, phone, userName, idPer });
            return result > 0;
        }

        public bool UpdateStaff(int idNV, string name, bool sex, DateTime dob, string addressm, string email, string phone, string userName, int idPer)
        {
            string query = "exec USP_UpdateInfo @idNV , @nameNV , @dateOfBirth , @addressNV , @emailNV , @phoneNV , @sexNV , @idPer , @userName";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idNV, name, dob, addressm, email, phone, sex, idPer, userName });
            return result > 0;
        }
        public DataTable GetStaffByName(string name, string phone)
        {
            string query = string.Format("exec USP_GetStaffByName N'{0}' , '{1}'", name, phone);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool DeleteStaff(int idNV) 
        {
            string query = "exec USP_DeleteStaff @idNV";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {idNV});
            return result > 0;
        }

    }
}
