using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RoomInfoDAO
    {
        private static RoomInfoDAO instance;
        public static RoomInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoomInfoDAO();
                return instance;
            }
            private set
            {
                RoomInfoDAO.instance = value;
            }
        }
        private RoomInfoDAO() { }

        public static int RoomWidth = 90;
        public static int RoomHeight = 90;

        public List<RoomInfo> LoadRoomList()
        {
            List<RoomInfo> roomList = new List<RoomInfo>();
            string query = "exec USP_GetAllRoomInfo";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                RoomInfo room = new RoomInfo(dr);
                roomList.Add(room);
            }

            return roomList;
        }
    }
}
