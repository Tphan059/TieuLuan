using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class RoomStatusBUS
    {
        private static RoomStatusBUS instance;
        public static RoomStatusBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoomStatusBUS();
                return instance;
            }

            private set
            {
                RoomStatusBUS.instance = value;
            }
        }

        public RoomStatusBUS() { }

        public void GetRTCB(ComboBox cb)
        {
            cb.DataSource = RoomStatusDAO.Instance.GetRoomStatus();
            cb.DisplayMember = "nameRStatus";
            cb.ValueMember = "idRStatus";
        }
    }
}
