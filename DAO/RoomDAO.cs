using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;
        public static RoomDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoomDAO();
                return instance;
            }
            private set
            {
                RoomDAO.instance = value;
            }
        }
        private RoomDAO() { }

        public List<Room> LoadRoomList() 
        {
            List<Room> roomList = new List<Room>();
            string query = "select * from dbo.Room order by nameRoom ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows) 
            {
                Room room = new Room(dr);
                roomList.Add(room);
            }

            return roomList;
        }

        public DataTable GetRoomByRT(int id, DateTime check)
        {
            string query = "exec USP_GetRoomByRoomType @idRT , @dateCheck";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {id, check});
        }
        
        public int GetCountRoomByStatus(int idStatus)
        {

            string query = "exec USP_GetCountIdStatus @idStatus";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] {idStatus});

        }

        public bool ChangeIdStausRoom (int idStausRoom, int idRoom) 
        {
            string query = string.Format("update dbo.Room set idRStatus = {0} where idRoom = {1} " , idStausRoom, idRoom);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable GetRoomsByIdRoom(int idRoom)
        {
            string query = "select * from dbo.Room where idRoom = "+idRoom;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetAllRoom()
        {
            string query = "exec USP_GetAllRoomInfo";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertRoom(string name, int idF, int idRT, int idRS)
        {
            string query = "exec USP_InserRoom @name , @idFloor , @idRT , @idRS";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {name, idF, idRT, idRS});
            return result > 0;
        }

        public bool UpdateRoom(int id, string name, int idF, int idRT, int idRS)
        {
            string query = "exec USP_UpdateRoom @id , @name , @idFloor , @idRT , @idRS";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, idF, idRT, idRS });
            return result > 0;
        }

        public DataTable SearchByName(string name)
        {
            string query = "exec USP_SearchRoomByName @name";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }

        public DataTable FilterRoom(int idF, int idRT, int idRS)
        {
            string query = "exec USP_FilterRoom @idF , @idRT , @idRS";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {idF, idRT, idRS});
        }

        public bool ChangeStatus(int id, int status)
        {
            string query = string.Format("update dbo.Room set idRStatus = {0} where idRoom = {1}", status, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query); return result > 0;
        }
    }


}
