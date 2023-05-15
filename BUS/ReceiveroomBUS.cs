using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class ReceiveroomBUS
    {
        private static ReceiveroomBUS instance;
        public static ReceiveroomBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ReceiveroomBUS();
                return instance;
            }
            private set
            {
                ReceiveroomBUS.instance = value;
            }
        }
        private ReceiveroomBUS() { }

        public List<Receiveroom> GetReceiveroomByIdRoom(int idRoom)
        {
            return ReceiveroomDAO.Instance.GetReceiverroomsByIdRoom(idRoom);
        }

        public void GetReceiveroomByIdBookRoom(int idBook, int idRoom, out DateTime dateCheckIn)
        {
            DataRow row = ReceiveroomDAO.Instance.GetReceiveroomsByIdBookRoom(idBook, idRoom).Rows[0];
            dateCheckIn = (DateTime)row["dateCheck"];
        }

        public void GetPreFormCus( string phone, out string cus, out DateTime dateCheckIn, out DateTime dateCheckOut, out string room, out int idbook, out int idroom)
        {
            DataRow row = ReceiveroomDAO.Instance.GetReceiveroomByCus(phone).Rows[0];
            cus = row["nameCus"].ToString();
            dateCheckIn = (DateTime)row["dateCheck"];
            dateCheckOut = (DateTime)row["dateOut"];
            room = row["nameRoom"].ToString();
            idbook = (int)row["idBook"];
            idroom = (int)row["idRoom"];
        }

        private new event FormClosedEventHandler FormClosed;
    }
}
