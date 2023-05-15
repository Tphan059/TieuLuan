using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UnitPriceDAO
    {
        private static UnitPriceDAO instance;
        public static UnitPriceDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UnitPriceDAO();
                return instance;
            }
            private set
            {
                UnitPriceDAO.instance = value;
            }
        }
        private UnitPriceDAO() { }

        public List<unitPrice> GetUnitPriceByIdRTIdTl(int idRT, int idTL)
        {
            List<unitPrice> unitPrices = new List<unitPrice>();
            string query = "exec USP_GetUnitPrice @idRT , @idTL";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {idRT, idTL});
            foreach(DataRow row in data.Rows)
            {
                unitPrice unit = new unitPrice(row);
                unitPrices.Add(unit);
            }
            return unitPrices;
        }

        public DataTable GetUnitPrice()
        {
            string query = "exec USP_GetUnitPriceInfo";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetUnitPriceInfoByIdRT(int id)
        {
            string query = "exec USP_GetUnitPriceInfoByIdRT @id";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {id});
        }

        public bool InsertPrice(int idrt, int idtl, float price)
        {
            string query = "exec USP_InertPrice @idrt , @idtl , @price";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idrt, idtl, price });
            return result > 0;
        }

        public bool UpdatePrice(int idrt, int idtl, float price)
        {
            string query = "exec USP_UpdatePrice @idrt , @idtl , @price";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idrt, idtl, price });
            return result > 0;
        }
    }
}
