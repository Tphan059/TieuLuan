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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            LoadData();
        }

        #region methods

        private void LoadData()
        {
            NationalityBUS.Instance.GetNationality(cbbNation);
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            clearBinding();
            CustomerBUS.Instance.GetCustomer(dataGridView1);
            addBinding();
        }

        private void addBinding()
        {
            txtNameCus.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Tên khách hàng", true, DataSourceUpdateMode.Never));
            ckbSexCus.DataBindings.Add(new Binding("checked", dataGridView1.DataSource, "Giới tính", true, DataSourceUpdateMode.Never));
            txtPhoneCus.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
            txtEmailCus.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Email", true, DataSourceUpdateMode.Never));
            txtAddressCus.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            txtIdCard.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Căn cước", true, DataSourceUpdateMode.Never));
            cbbNation.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Quốc tịch", true, DataSourceUpdateMode.Never));

        }

        private void clearBinding()
        {
            txtNameCus.DataBindings.Clear();
            txtPhoneCus.DataBindings.Clear();
            txtEmailCus.DataBindings.Clear();
            txtAddressCus.DataBindings.Clear();
            txtIdCard.DataBindings.Clear();
            ckbSexCus.DataBindings.Clear();
            cbbNation.DataBindings.Clear();
        }

        private void addActive()
        {
            btnCusAdd.Enabled = false;
            btnCusEdit.Enabled = false;
            btnCusSearch.Enabled = false;
            btnCusSave.Enabled = true;
            btnCusCancel.Enabled = true;
            txtNameCus.Clear();
            txtAddressCus.Clear();
            txtEmailCus.Clear();
            txtPhoneCus.Clear() ;
            txtIdCard.Clear();
            ckbSexCus.Checked = false;
            cbbNation.SelectedIndex = 0;
            txtNameCus.Focus();
        }

        private void cancelActive()
        {
            btnCusAdd.Enabled = true;
            btnCusEdit.Enabled = true;
            btnCusSearch.Enabled = true;
            btnCusSave.Enabled = false;
            btnCusCancel.Enabled = false;
        }
        #endregion

        private void btnCusAdd_Click(object sender, EventArgs e)
        {
            addActive();
        }

        private void btnCusSave_Click(object sender, EventArgs e)
        {
            string name = txtNameCus.Text;
            bool sex = ckbSexCus.Checked;
            string address = txtAddressCus.Text;
            string email = txtEmailCus.Text;
            string phone = txtPhoneCus.Text;
            string cccd = txtIdCard.Text;
            int id = (int)cbbNation.SelectedValue;
            CustomerBUS.Instance.Insert(name, phone,email,address,sex,cccd,id);
            cancelActive();
            LoadCustomer();
        }

        private void btnCusCancel_Click(object sender, EventArgs e)
        {
            cancelActive();
            LoadCustomer() ;
        }

        private void btnCusReload_Click(object sender, EventArgs e)
        {
            cancelActive();
            LoadData();
        }

        private void btnCusEdit_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                id = (int)row.Cells[0].Value;
            }
            string name = txtNameCus.Text;
            bool sex = ckbSexCus.Checked;
            string address = txtAddressCus.Text;
            string email = txtEmailCus.Text;
            string phone = txtPhoneCus.Text;
            string cccd = txtIdCard.Text;
            int idNa = (int)cbbNation.SelectedValue;
            CustomerBUS.Instance.Update(id, name, email, address, sex, cccd, idNa, phone);
            LoadCustomer();
        }

        private void btnCusSearch_Click(object sender, EventArgs e)
        {
            string name= txtNameCusS.Text;
            string phone = txtPhoneCusS.Text;
            CustomerBUS.Instance.SearchCustomer(name, phone,dataGridView1);
            clearBinding();
            addBinding();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                id = (int)row.Cells[0].Value;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc sẽ xóa khách hàng này không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DeviceBUS.Instance.Delete(id, dataGridView1);
                clearBinding();
                addBinding();
            }
        }
    }
}
