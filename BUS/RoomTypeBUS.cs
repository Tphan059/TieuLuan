using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class RoomTypeBUS
    {
        private static RoomTypeBUS instance;
        public static RoomTypeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoomTypeBUS();
                return instance;
            }

            private set
            {
                RoomTypeBUS.Instance = value;
            }
        }
        public RoomTypeBUS() { }

        public void GetRTToCB (ComboBox cb)
        {
            
            cb.DataSource = RoomTypeDAO.Instance.GetRoomType();
            cb.DisplayMember = "Tên loại phòng";
            cb.ValueMember = "ID";
        }

        public void GetRoomType(DataGridView dt)
        {
            dt.DataSource = RoomTypeDAO.Instance.GetRoomType();
        }

        public void InsertRoomType(string name, int limit, int acreage, string desc)
        {
            if(RoomTypeDAO.Instance.InsertRoomType(name, limit, acreage, desc))
            {
                MessageBox.Show("Thêm loại phòng thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        public void UpdateRoomType(int id, string name, int limit, int acreage, string desc)
        {
            if (RoomTypeDAO.Instance.UpdateRoomType(id, name, limit, acreage, desc))
            {
                MessageBox.Show("Cập nhật loại phòng thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        public void DeleteRoomType(int id, DataGridView dt)
        {
            if (RoomTypeDAO.Instance.DeleteRoomType(id))
            {
                MessageBox.Show("Xóa thành công");
                GetRoomType(dt);
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
