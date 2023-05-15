using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EquipmentDAO
    {

        private static EquipmentDAO instance;
        public static EquipmentDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new EquipmentDAO();
                return instance;
            }

            private set
            {
                EquipmentDAO.instance = value;
            }
        }

        public EquipmentDAO() { }

        public DataTable GetEquipList()
        {
            string query = "exec USP_GetEquipment";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertEquipment(int idTB, int idRT  , int count)
        {
            string query = "exec USP_InsertEquipment @idTB , @idRT , @count";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idTB, idRT, count });
            return result > 0;
        }

        public bool UpdateEquipment(int idTB, int idRT, int count)
        {
            string query = "exec USP_UpdateEquipment @idTB , @idRT , @count";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idTB, idRT, count });
            return result > 0;
        }

        public DataTable SearchEquipmentByIdRT(int idRT)
        {
            string query = "exec USP_SearchEquipmentByIdRT @idRT";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idRT});

        }
    }
}
