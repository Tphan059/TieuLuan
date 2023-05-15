using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class RoomBUS
    {
        private static RoomBUS instance;
        public static RoomBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoomBUS();
                return instance;
            }
            private set
            {
                RoomBUS.instance = value;
            }
        }
        private RoomBUS() { }

        public List<Room> LoadRoom()
        {
            return RoomDAO.Instance.LoadRoomList();
        }

        public int GetCountRoomByIdStatus(int idStatus)
        {
            return RoomDAO.Instance.GetCountRoomByStatus(idStatus);
        }

        public bool ChangeIdStatusRoom (int idStatus, int roomId) 
        {
            return RoomDAO.Instance.ChangeIdStausRoom(idStatus, roomId);
        }

        public void ChangeStatus2To3(string status, int id)
        {
            if (status == "Khách ra ngoài")
            {
                RoomBUS.Instance.ChangeIdStatusRoom(3, id);
                status = "Khách đã về phòng";
            }
            else
            {
                RoomBUS.Instance.ChangeIdStatusRoom(2, id);
                status = "Khách ra ngoài";
            }
        }

        public void GetIdRSByIdRoom (int idRoom, out int idRS)
        {
            DataRow row = RoomDAO.Instance.GetRoomsByIdRoom(idRoom).Rows[0];
            idRS = (int)row["idRStatus"];
        }

        public void GetAllRoom(DataGridView dt)
        {
            dt.DataSource = RoomDAO.Instance.GetAllRoom();
        }


        public void GetAllRoomToCB(ComboBox cb)
        {
            cb.DataSource = RoomDAO.Instance.GetAllRoom();
            cb.Text = "";
            cb.DisplayMember = "Tên phòng";
            cb.ValueMember = "ID";
        }


        public void InsertRoom (string name, int idF, int idRT, int idRS)
        {
            if(RoomDAO.Instance.InsertRoom(name, idF, idRT, idRS))
            {
                MessageBox.Show("Thêm phòng mới thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        public void UpdateRoom(int id, string name, int idF, int idRT, int idRS)
        {
            if (RoomDAO.Instance.UpdateRoom(id , name, idF, idRT, idRS))
            {
                MessageBox.Show("Cập nhật phòng thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        public void SearchByName(string name, DataGridView dt)
        {
            dt.DataSource = RoomDAO.Instance.SearchByName(name);
        }

        public void FilterRoom (int idF, int idRT, int idRS, DataGridView dt)
        {
            dt.DataSource = RoomDAO.Instance.FilterRoom(idF, idRT, idRS);
        }

        public DataTable GetRoomByRT(int id, DateTime date)
        {
            return RoomDAO.Instance.GetRoomByRT(id, date);

            
        }

        public void changeStatus(int id, int status, Form form)
        {
            if(RoomDAO.Instance.ChangeStatus(id, status))
            {
                form.Close();
            }

        }
    }
}
