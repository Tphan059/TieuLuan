using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TieuLuan.Admin.childForm
{
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
            LoadData();
            
        }
        #region methods
        private void LoadData()
        {
            LoadService();
            LoadServiceType();
            
            ServiceTypeBUS.Instance.GetServiceTypeToCb(cbbServiceType);
            ServiceTypeBUS.Instance.GetServiceTypeToCb(comboBox2);
            

        }

        private void AddBindingService()
        {
            txtNameServ.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Tên dịch vụ", true, DataSourceUpdateMode.Never));
            txtPriceServ.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Giá", true, DataSourceUpdateMode.Never));
            txtUnitPrice.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Đơn vị", true, DataSourceUpdateMode.Never));
            cbbServiceType.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Loại dịch vụ", true, DataSourceUpdateMode.Never));
          
        }

        public void ClearBindingService()
        {
            txtNameServ.DataBindings.Clear();
            txtPriceServ.DataBindings.Clear();
            cbbServiceType.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
        }
         
        private void LoadService()
        {
            ClearBindingService();            
            ServiceBUS.Instance.GetAllService(dataGridView1);
            AddBindingService();
        }

        private void LoadServiceType()
        {
            //ServiceTypeBUS.Instance.GetServiceTypeToDataGridView(dataGridView2);
        }

        private void addActive()
        {
            btnServAdd.Enabled = false;
            btnServEdit.Enabled = false;
            btnServReload.Enabled = false;
            btnServSave.Enabled = true;
            btnServCancel.Enabled = true;
            txtNameServ.Clear();
            txtPriceServ.Clear();
            txtUnitPrice.Clear();
            txtNameServ.Focus();
        }

        private void afterAddActive()
        {
            btnServAdd.Enabled = true;
            btnServEdit.Enabled = true;
            btnServReload.Enabled = true;
            btnServSave.Enabled = false;
            btnServCancel.Enabled = false;
        }

        private void searchServ()
        {
            string name = txtNameServS.Text;
            int id = (int)comboBox2.SelectedValue;
            //double? price = Converting.Converting.Instance.ConvertStringToDouble(nudPriceServS.Value.ToString());
            ClearBindingService();
            ServiceBUS.Instance.SearchService(name, id, dataGridView1);
            AddBindingService();
        }
        #endregion

        private void btnServEdit_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                id = (int)row.Cells[0].Value;
            }
            double price = Convert.ToDouble(txtPriceServ.Text);
            ServiceBUS.Instance.UpdateService(id, txtNameServ.Text, (int)cbbServiceType.SelectedValue, (float)price, txtUnitPrice.Text);
            //pnlServiceInfo.Enabled = true;
            //AddBindingService();
            LoadService();
        }

        private void btnServAdd_Click(object sender, EventArgs e)
        {
            addActive();
            
        }

        private void btnServSave_Click(object sender, EventArgs e)
        {
            string name = txtNameServ.Text;
            string unit = txtUnitPrice.Text;
            double price = Convert.ToDouble(txtPriceServ.Text);
            int idST = (int)cbbServiceType.SelectedValue;
            ServiceBUS.Instance.InsesrtService(name, idST, (float)price, unit);
            afterAddActive();
            LoadService();
        }

        private void btnServCancel_Click(object sender, EventArgs e)
        {
            afterAddActive();
            LoadService();
        }

        private void btnServReload_Click(object sender, EventArgs e)
        {
            LoadService();
        }

        private void btnServiceSearch_Click(object sender, EventArgs e)
        {
            btnServCancel.Enabled = true;
            searchServ();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                id = (int)row.Cells[0].Value;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc sẽ xóa dịch vụ này không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DeviceBUS.Instance.Delete(id, dataGridView1);
                ClearBindingService();
                AddBindingService();
            }
        }

        private void btnSTSave_Click(object sender, EventArgs e)
        {

        }
    }
}
