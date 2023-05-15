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
    public class StaffBUS
    {
        private static StaffBUS instance;
        public static StaffBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaffBUS();
                return instance;
            }
            private set
            {
                StaffBUS.instance = value;
            }
        }
        private StaffBUS() { }
        public void SelectALl(DataGridView data)
        {
            data.DataSource = StaffDAO.Instance.SelectAll();            
        }

        public void GetNameStaff (int idNV, out string name)
        {
            DataRow item = StaffDAO.Instance.SelectStaffByIdNV(idNV).Rows[0];
            name = item["nameNV"].ToString();
        }

        public void InsertNewStaff (string name, bool sex, DateTime dob, string address, string email, string phone, string user, int id)
        {
            if(StaffDAO.Instance.InsertNewStaff(name, sex, dob, address, email, phone, user, id)) 
            {
                MessageBox.Show("Thêm nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        public void UpdateStaff(int idNV, string name, bool sex, DateTime dob, string address, string email, string phone, string user, int id)
        {
            if (StaffDAO.Instance.UpdateStaff(idNV, name, sex, dob, address, email, phone, user, id))
            {
                MessageBox.Show("Thay đổi thông tin nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Lỗi", "EROR");
            }
        }

        public void GetStaffByName(string name, string phone, DataGridView data)
        {
            data.DataSource = StaffDAO.Instance.GetStaffByName(name, phone);
        }

        public void DeleteStaff(int  id) 
        {
            if (StaffDAO.Instance.DeleteStaff(id))
            {
                MessageBox.Show("Đã xóa nhân viên");

            }
            else
            {
                MessageBox.Show("Lỗi", "EROR");
            }
        }

    }
}
