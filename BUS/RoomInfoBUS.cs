using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class RoomInfoBUS
    {
        private static RoomInfoBUS instance;
        public static RoomInfoBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoomInfoBUS();
                return instance;
            }
            private set
            {
                RoomInfoBUS.instance = value;
            }
        }

        private RoomInfoBUS() { }

        public List<RoomInfo> LoadRoom()
        {
            return RoomInfoDAO.Instance.LoadRoomList();
        }
    }
}
