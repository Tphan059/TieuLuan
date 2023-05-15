using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class EquipmentBUS
    {
        private static EquipmentBUS instance;
        public static EquipmentBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EquipmentBUS();
                }
                return instance;
            }

            private set
            {
                EquipmentBUS.instance = value;
            }
        }

        public EquipmentBUS() { }

        public void GetEquipList(DataGridView dt)
        {
            dt.DataSource = EquipmentDAO.Instance.GetEquipList();
        }

        public void InsertEquipmet (int idTB, int idRT, int count)
        {
            if (EquipmentDAO.Instance.InsertEquipment(idTB, idRT, count))
            {
                MessageBox.Show("Thêm thiết bị vào loại phòng thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        public void UpdateEquipmet(int idTB, int idRT, int count)
        {
            if (EquipmentDAO.Instance.UpdateEquipment(idTB, idRT, count))
            {
                MessageBox.Show("Sửa thiết bị của loại phòng thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        public void SearchEquipList(int idRT, DataGridView dt)
        {
            dt.DataSource = EquipmentDAO.Instance.SearchEquipmentByIdRT(idRT);
        }
    }
}
