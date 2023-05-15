using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class DeviceBUS
    {
        private static DeviceBUS instance;
        public static DeviceBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DeviceBUS();
                return instance;
            }

            private set
            {
                DeviceBUS.instance = value;
            }
        }
        public DeviceBUS() { }

        public void GetDeviceToCB (ComboBox cb)
        {
            cb.DataSource = DeviceDAO.Instance.GetDevice();
            cb.DisplayMember = "Tên thiết bị";
            cb.ValueMember = "ID";
        }

        public void GetDevice(DataGridView dt)
        {
            dt.DataSource = DeviceDAO.Instance.GetDevice();
        }

        public void Insert(string name, float price, string unit)
        {
            if(DeviceDAO.Instance.InsertDevice(name, price, unit))
            {
                MessageBox.Show("Thêm thiết bị thành công");

            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        public void Update(int id, string name, float price, string unit)
        {
            if (DeviceDAO.Instance.UpdateDevice(id, name, price, unit))
            {
                MessageBox.Show("Cập nhật thông tin thiết bị thành công");

            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        public void SearchByName(string name, DataGridView dt) 
        {
            dt.DataSource = DeviceDAO.Instance.SearchByName(name);
        }

        public void Delete(int id, DataGridView dt)
        {
            if (DeviceDAO.Instance.DeleteDevice(id))
            {
                MessageBox.Show("Xóa thiết bị thành công");
                GetDevice(dt);
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
