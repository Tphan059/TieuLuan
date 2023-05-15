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
    public class CustomerBUS
    {
        private static CustomerBUS instance;
        public static CustomerBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerBUS();
                return instance;
            }
            private set
            {
                CustomerBUS.instance = value;
            }
        }

        public CustomerBUS() { }

        public void GetCustomerById(int id, out string name) 
        {
            DataRow data = CustomerDAO.Instance.GetCustomerById(id).Rows[0];            
            name = data["nameCus"].ToString();
        }

        public void GetCustomer(DataGridView dt)
        {
            dt.DataSource = CustomerDAO.Instance.GetCustomer();
        }

        public void Insert(string name, string phone, string email, string address, bool sex, string cccd, int idNa)
        {
            if(CustomerDAO.Instance.InsertCustomer(name, email, address, sex, cccd, phone, idNa))
            {
                MessageBox.Show("Thêm thông tin khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        public void Update(int id, string name, string email, string address, bool sex, string cccd, int idNa, string phone)
        {
            if(CustomerDAO.Instance.UpdateCustomer(id, name, email, address, sex, cccd, idNa, phone))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        public void Delete(int id, DataGridView dt)
        {
            if (CustomerDAO.Instance.DeleteCustomer(id))
            {
                MessageBox.Show("Xóa khách hàng thành công");
                GetCustomer(dt);
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        public void SearchCustomer(string name, string phone, DataGridView dt)
        {
            dt.DataSource = CustomerDAO.Instance.SearchCustomer(name, phone);
        }

        public void GetCusByPhone1(string phone, out string name, out string cccd) 
        {
            if(CustomerDAO.Instance.GetCustomerByPhone(phone).Rows.Count > 0)
            {
                DataRow data = CustomerDAO.Instance.GetCustomerByPhone(phone).Rows[0];
                name = data["nameCus"].ToString();
                cccd = data["idCard"].ToString();
            }
            else
            {
            name = "";
            cccd = "";

            }
        }
    }
}
