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
    public partial class pnlEquipmentInfo : Form
    {
        public pnlEquipmentInfo()
        {
            InitializeComponent();
            LoadData();
        }
        #region methods
        private void LoadData()
        {
            RoomTypeBUS.Instance.GetRTToCB(cbbEqipRT);
            RoomTypeBUS.Instance.GetRTToCB(cbbEquipRTS);
            LoadEquipment();
            LoadDevice();
        }

        private void LoadEquipment()
        {
            clearBindingEquipment();
            EquipmentBUS.Instance.GetEquipList(dtgvEquip);
            DeviceBUS.Instance.GetDeviceToCB(cbEquipTB);
            addBindingEquipment();
        }

        private void LoadDevice()
        {
            clearBinding();
            DeviceBUS.Instance.GetDevice(dtgvDevice);
            addBinding();
        }

        private void addBinding()
        {
            txbNameTB.DataBindings.Add(new Binding("text", dtgvDevice.DataSource, "Tên thiết bị", true, DataSourceUpdateMode.Never));
            txbPrice.DataBindings.Add(new Binding("text", dtgvDevice.DataSource, "Giá", true, DataSourceUpdateMode.Never));
            txbUnit.DataBindings.Add(new Binding("text", dtgvDevice.DataSource, "Đơn vị", true, DataSourceUpdateMode.Never));
        }

        private void clearBinding()
        {
            txbNameTB.DataBindings.Clear();
            txbPrice.DataBindings.Clear();
            txbUnit.DataBindings.Clear();
        }

        private void addBindingEquipment()
        {
            cbEquipTB.DataBindings.Add(new Binding("text", dtgvEquip.DataSource, "Tên thiết bị", true, DataSourceUpdateMode.Never));
            cbbEqipRT.DataBindings.Add(new Binding("text", dtgvEquip.DataSource, "Loại phòng", true, DataSourceUpdateMode.Never));
            nmEquipCount.DataBindings.Add(new Binding("text", dtgvEquip.DataSource, "Số lượng", true, DataSourceUpdateMode.Never, true));
        }

        private void clearBindingEquipment()
        {
            cbEquipTB.DataBindings.Clear();
            cbbEqipRT.DataBindings.Clear();
            nmEquipCount.DataBindings.Clear();
        }

        private void addActive()
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            txbNameTB.Clear();
            txbPrice.Clear();
            txbUnit.Clear();
            txbNameTB.Focus();
        }

        private void cancelActive()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
        }

        private void addEquipmentActive()
        {
            btnEquipAdd.Enabled = false;
            btnEquipEdit.Enabled = false;
            btnEquipCancel.Enabled = true;
            btnEquipSave.Enabled = true;
            cbEquipTB.Text = string.Empty;
            cbEquipTB.Focus();
            cbbEqipRT.Text = string.Empty;
            nmEquipCount.Text = "1";
        }

        private void cancelEquipmentActive()
        {
            btnEquipAdd.Enabled = true;
            btnEquipEdit.Enabled = true;
            btnEquipCancel.Enabled = false;
            btnEquipSave.Enabled = false;            
        }

        
        #endregion

        private void btnEquipAdd_Click(object sender, EventArgs e)
        {
            addEquipmentActive();
        }

        private void btnEquipSave_Click(object sender, EventArgs e)
        {
            int idTB = (int)cbEquipTB.SelectedValue;
            int idRT = (int)cbbEqipRT.SelectedValue;
            int count = (int)nmEquipCount.Value;
            EquipmentBUS.Instance.InsertEquipmet(idTB, idRT, count);
            cancelEquipmentActive();
            LoadEquipment();
        }

        private void btnEquipCancel_Click(object sender, EventArgs e)
        {
            cancelEquipmentActive();
            LoadEquipment() ;
        }

        private void btnEquipReload_Click(object sender, EventArgs e)
        {
            cancelEquipmentActive();
            LoadEquipment();
        }

        private void btnEquipEdit_Click(object sender, EventArgs e)
        {
            int idTB = (int)cbEquipTB.SelectedValue;
            int idRT = (int)cbbEqipRT.SelectedValue;
            int count = (int)nmEquipCount.Value;
            EquipmentBUS.Instance.UpdateEquipmet(idTB, idRT, count);
            LoadEquipment();
        }

        private void btnEquipSearch_Click(object sender, EventArgs e)
        {
            int idRT = (int)cbbEquipRTS.SelectedValue;
            EquipmentBUS.Instance.SearchEquipList(idRT, dtgvEquip);
            clearBindingEquipment();
            addBindingEquipment();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addActive();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txbNameTB.Text;
            double price = Convert.ToDouble( txbPrice.Text);
            string unit = txbUnit.Text;
            DeviceBUS.Instance.Insert(name, (float)price, unit);
            cancelActive();
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelActive();
            LoadDevice();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDevice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txbNameTBS.Text;
            DeviceBUS.Instance.SearchByName(name, dtgvDevice);
            clearBinding();
            addBinding();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dtgvDevice.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvDevice.SelectedRows[0];
                id = (int)row.Cells[0].Value;
            }
            string name = txbNameTB.Text;
            double price = Convert.ToDouble(txbPrice.Text);
            string unit = txbUnit.Text;
            DeviceBUS.Instance.Update(id, name, (float)price, unit);
            LoadDevice();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dtgvDevice.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvDevice.SelectedRows[0];
                id = (int)row.Cells[0].Value;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc sẽ xóa thiết bị không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            {
                DeviceBUS.Instance.Delete(id, dtgvDevice);
                clearBinding();
                addBinding();
            }
            
        }
    }
}
