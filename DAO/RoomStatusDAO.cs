using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RoomStatusDAO
    {
        private static RoomStatusDAO instance;
        public static RoomStatusDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoomStatusDAO();
                return instance;
            }

            private set
            {
                RoomStatusDAO.instance = value;
            }
        }
        public RoomStatusDAO() { }

        public DataTable GetRoomStatus()
        {
            string query = "select * from dbo.RoomStatus";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
