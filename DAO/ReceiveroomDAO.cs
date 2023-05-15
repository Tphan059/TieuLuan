using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ReceiveroomDAO
    {
        private static ReceiveroomDAO instance;
        public static ReceiveroomDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ReceiveroomDAO();
                return instance;
            }
            private set
            {
                ReceiveroomDAO.instance = value;
            }
        }
        private ReceiveroomDAO() { }

        public List<Receiveroom> GetReceiverroomsByIdRoom(int idRoom) 
        {
            List<Receiveroom> receiverrooms = new List<Receiveroom>();
            string query = "exec USP_GetAReceiverRoomById @idRoom";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] {idRoom});
            foreach (DataRow row in table.Rows) 
            {
                Receiveroom receiverroom = new Receiveroom(row);
                receiverrooms.Add(receiverroom);
            }
            return receiverrooms;
        }

        public DataTable GetReceiveroomsByIdBookRoom(int idBook, int idRoom)
        {
            string query = "exec USP_GetAReceiverRoomByIdBook @idBook , @idRoom";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { idBook, idRoom });
            return table;
        }
       
        public DataTable GetReceiveroomByCus (string phone)
        {
            string query = ("exec GetPreBook @phone");
            return DataProvider.Instance.ExecuteQuery(query,new object[] {phone});
        }
    }
}
