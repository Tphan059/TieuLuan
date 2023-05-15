using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BUS;
using DTO;

namespace TieuLuan.Admin.childForm
{
    public partial class StaffControlForm : Form
    {
        private int nvID;

        public StaffControlForm(int idNV)
        {
            
            InitializeComponent();
            LoadData();
            this.nvID = idNV;
        }
        #region methods

         private void LoadData()
        {
            ClearBinding();
            LoadStaff();
            PermisionBUS.Instance.GetPermision(cbbPer);            
            AddStaffBinding();

        }

        

        private void LoadStaff()
        {
            
            StaffBUS.Instance.SelectALl(dtgvStaff);
        }

        private void ClearBinding()
        {
            txtNameNV.DataBindings.Clear();
            txtPhoneNV.DataBindings.Clear();
            dtpDoB.DataBindings.Clear();
            txtAddressNV.DataBindings.Clear();
            txtEmailNV.DataBindings.Clear();
            cbxSexNV.DataBindings.Clear();
            txtAccount.DataBindings.Clear();
            cbbPer.DataBindings.Clear();

        }
        private void AddStaffBinding()
        {

            txtNameNV.DataBindings.Add(new Binding("text", dtgvStaff.DataSource, "Tên nhân viên", true, DataSourceUpdateMode.Never));
            txtPhoneNV.DataBindings.Add(new Binding("text", dtgvStaff.DataSource, " Số điện thoại", true, DataSourceUpdateMode.Never));
            dtpDoB.DataBindings.Add(new Binding("value", dtgvStaff.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never));
            txtAddressNV.DataBindings.Add(new Binding("text", dtgvStaff.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            txtEmailNV.DataBindings.Add(new Binding("text", dtgvStaff.DataSource, "Email", true, DataSourceUpdateMode.Never));
            cbxSexNV.DataBindings.Add(new Binding("checked", dtgvStaff.DataSource, "Giới tính", true, DataSourceUpdateMode.Never));
            txtAccount.DataBindings.Add(new Binding("text", dtgvStaff.DataSource, "Tài khoản", true, DataSourceUpdateMode.Never));
            cbbPer.DataBindings.Add(new Binding("text", dtgvStaff.DataSource, "Quyền hạn", true, DataSourceUpdateMode.Never));
        }

        private void ClearValue()
        {
            txtNameNV.Clear();
            txtPhoneNV.Clear();
            dtpDoB.Value = DateTime.Now;
            txtAddressNV.Clear();
            txtEmailNV.Clear();
            cbxSexNV.Checked = false;
            txtAccount.Clear();
        }
        #endregion
        private void StaffForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnStaffEdit_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dtgvStaff.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvStaff.SelectedRows[0];
                id = (int)row.Cells[0].Value;
            }

            string name = txtNameNV.Text;
            bool sex = cbxSexNV.Checked;
            string address = txtAddressNV.Text;
            string email = txtEmailNV.Text;
            string phone = txtPhoneNV.Text;
            DateTime dob = dtpDoB.Value;
            string user = txtAccount.Text;
            int idPer = (int)cbbPer.SelectedValue;

            
            StaffBUS.Instance.UpdateStaff(id, name, sex, dob, address, email, phone, user, idPer);
            
            LoadData();
        }

        private void btnStaffCancel_Click(object sender, EventArgs e)
        {
            ClearValue();
            txtAccount.Enabled = false;
            btnStaffCancel.Enabled = false;
            btnStaffSave.Enabled = false;
            btnStaffEdit.Enabled = true;
            btnStaffReload.Enabled = true;
            btnChangePass.Enabled = false;
            btnStaffAdd.Enabled = true;
        }

        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            ClearValue();
            txtNameNV.Focus();

            txtAccount.Enabled = true;
            btnStaffCancel.Enabled = true;
            btnStaffSave.Enabled = true;
            btnStaffEdit.Enabled = false;
            btnStaffReload.Enabled = false;
            btnChangePass.Enabled = false;
            btnStaffAdd.Enabled = false;
        }

        private void btnStaffSave_Click(object sender, EventArgs e)
        {
            txtAccount.Enabled = false;
            btnStaffCancel.Enabled = false;
            btnStaffSave.Enabled = false;
            btnStaffEdit.Enabled = true;
            btnStaffReload.Enabled = true;
            btnStaffReload.Enabled = true;
            btnStaffAdd.Enabled = true;
            string name = txtNameNV.Text;
            bool sex = cbxSexNV.Checked;
            string address = txtAddressNV.Text;
            string email = txtEmailNV.Text;
            string phone = txtPhoneNV.Text;
            DateTime dob = dtpDoB.Value;
            string user = txtAccount.Text;
            int idPer = (int)cbbPer.SelectedValue;

            StaffBUS.Instance.InsertNewStaff(name, sex, dob, address, email, phone, user, idPer);

            LoadData();
        }

        private void btnStaffReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePassForm1 changePassForm = new ChangePassForm1(); 
            changePassForm.ShowDialog();
        }

        private void btnStaffSearch_Click(object sender, EventArgs e)
        {
            string name = "";
            string phone = txtPhoneNVSearch.Text;
            StaffBUS.Instance.GetStaffByName(name, phone, dtgvStaff);
            txtPhoneNVSearch.Clear();
            //txtNameNVSearch.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dtgvStaff.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvStaff.SelectedRows[0];
                id = (int)row.Cells[0].Value;
            }
            if (id == nvID)
            {
                MessageBox.Show("Bạn không thể xóa tài khoản của chính mình");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    StaffBUS.Instance.DeleteStaff(id);
                    LoadData();
                }
                else
                {
                    // Thực hiện khi người dùng chọn No
                }
            }
        }
    }
}
