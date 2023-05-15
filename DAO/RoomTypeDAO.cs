using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RoomTypeDAO
    {
        private static RoomTypeDAO instance;
        public static RoomTypeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoomTypeDAO();
                return instance;
            }
            private set
            {
                RoomTypeDAO.instance = value;
            }
        }
        public RoomTypeDAO() { }

        public DataTable GetRoomType()
        {
            string query = "USP_GetRoomType";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertRoomType(string name, int limit, int acreage, string desc)
        {
            string query = "exec USP_AddRoomType @name , @limit , @acreage , @desc";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, limit, acreage, desc });
            return result > 0;
        }

        public bool UpdateRoomType(int id, string name, int limit, int acreage, string desc)
        {
            string query = "exec USP_UpdateRoomType @id ,    @name , @limit , @acreage , @desc";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id,name, limit, acreage, desc });
            return result > 0;
        }

        public bool DeleteRoomType(int id)
        {
            string query = "exec USP_DeleteRoomType @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
    }
}
