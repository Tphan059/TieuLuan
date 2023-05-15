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
    public class ServiceBUS
    {
        private static ServiceBUS instance;
        public static ServiceBUS Instance
        { 
            get 
            {
                if (instance == null)
                    instance = new ServiceBUS();
                return instance;
            }
            private set
            {
                ServiceBUS.instance = value;
            }
        }
        public ServiceBUS() { }

        public void GetAllServiceToCB(ComboBox cb)
        {
            cb.DataSource =  ServiceDAO.Instance.GetAllService();
            cb.DisplayMember = "nameServ";
        }

        public void GetServiceToCB(ComboBox cb, int idST)
        {
            cb.DataSource = ServiceDAO.Instance.GetServiceListByIdST(idST);
            cb.DisplayMember = "nameServ";
            cb.ValueMember = "idServ";
        }

        public void GetAllService(DataGridView dt)
        {
            dt.DataSource = ServiceDAO.Instance.GetAllServiceDtgv();
        }

        public void UpdateService(int id, string name, int idST, float price, string unit)
        {
            if(ServiceDAO.Instance.UpdateService(id,name,idST,unit,price))
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        public void InsesrtService( string name, int idST, float price, string unit)
        {
            if (ServiceDAO.Instance.InsertService( name, idST, unit, price))
            {
                MessageBox.Show("Thêm dịch vụ thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        public void SearchService (string name, int idST, DataGridView dt)
        {
            dt.DataSource = ServiceDAO.Instance.SearchService(name, idST);
        }

        public void DeleteService(int id, DataGridView dt)
        {
            if (ServiceDAO.Instance.DeleteService(id))
            {
                MessageBox.Show("Xóa dịch vụ thành công");
                GetAllService(dt);
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
