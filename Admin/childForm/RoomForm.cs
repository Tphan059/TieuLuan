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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
            LoadData();
        }
        #region methods

        private void LoadData()
        {
            RoomTypeBUS.Instance.GetRTToCB(cbbRTPrice);
            TimeLineBUS.Instance.GetTimeLineToCB(cbbTLPrice);
            RoomTypeBUS.Instance.GetRTToCB(cbbRTP);
            TimeLineBUS.Instance.GetTimeLineToCB(cbbRTT);
            LoadRoomType();
            LoadPrice();
        }

        private void LoadRoomType()
        {
            RoomTypeBUS.Instance.GetRoomType(dtgvRT);
            clearBinding();
            addBinding();
        }

        private void addBinding()
        {
            txtNameRT.DataBindings.Add(new Binding("text", dtgvRT.DataSource, "Tên loại phòng", true, DataSourceUpdateMode.Never));
            txtRTLimit.DataBindings.Add(new Binding("text", dtgvRT.DataSource, "Số người ở", true, DataSourceUpdateMode.Never));
            txtRTDT.DataBindings.Add(new Binding("text", dtgvRT.DataSource, "Diện tích", true, DataSourceUpdateMode.Never));
            txtRTDesc.DataBindings.Add(new Binding("text", dtgvRT.DataSource, "Mô tả", true, DataSourceUpdateMode.Never));
        }

        private void clearBinding()
        {
            txtNameRT.DataBindings.Clear();
            txtRTLimit.DataBindings.Clear();
            txtRTDesc.DataBindings.Clear();
            txtRTDT.DataBindings.Clear();
        }

        private void addRTActive()
        {
            txtNameRT.Clear();
            txtNameRT.Focus();
            txtRTLimit.Clear();
            txtRTDT.Clear();
            txtRTDesc.Clear();
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnRTSearch.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void cancelRTActive()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnRTSearch.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void LoadPrice()
        {
            UnitPriceBUS.Instance.GetUnitPrice(dtgvPrice);
            removePriceBinding();
            addPriceBinding();
        }

        private void addPriceBinding()
        {
            txtPrice.DataBindings.Add(new Binding("text", dtgvPrice.DataSource, "Giá", true, DataSourceUpdateMode.Never));
            cbbRTP.DataBindings.Add(new Binding("text", dtgvPrice.DataSource, "Loại phòng",true,DataSourceUpdateMode.Never));
            cbbRTT.DataBindings.Add(new Binding("text", dtgvPrice.DataSource, "Thời gian", true, DataSourceUpdateMode.Never));

        }

        private void removePriceBinding()
        {
            txtPrice.DataBindings.Clear();
            cbbRTP.DataBindings.Clear();
            cbbRTT.DataBindings.Clear();
        }

        private void addPriceActive()
        {
            txtPrice.Clear();
            txtPrice.Focus();
            cbbRTP.SelectedIndex = 0;
            cbbRTT.SelectedIndex = 0;
            btnPS.Enabled = false;
            btnPA.Enabled = false;
            btnPE.Enabled = false;
            btnPC.Enabled = true;
            btnPA.Enabled = true;
            btnPI.Enabled = true;
        }

        private void removePriceActive() 
        {
            btnPS.Enabled = true;
            btnPA.Enabled = true;
            btnPE.Enabled = true;
            btnPC.Enabled = false;
            btnPA.Enabled = false;
            btnPI.Enabled = false;
        }


        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addRTActive();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtNameRT.Text;
            int limit = Convert.ToInt32( txtRTLimit.Text);
            int dt = Convert.ToInt32(txtRTDT.Text);
            string desc = txtRTDesc.Text;
            RoomTypeBUS.Instance.InsertRoomType(name, limit, dt, desc);
            cancelRTActive();
            LoadData();
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            removePriceActive();
            LoadPrice();
        }

        private void btnPR_Click(object sender, EventArgs e)
        {
            removePriceActive();
            LoadPrice() ;
        }

        private void btnPE_Click(object sender, EventArgs e)
        {
            int idrt = (int)cbbRTP.SelectedValue;
            int idtl = (int)cbbRTT.SelectedValue;
            double price = Convert.ToDouble(txtPrice.Text);
            UnitPriceBUS.Instance.Update(idrt, idtl, (float)price);
            LoadPrice();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dtgvRT.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvRT.SelectedRows[0];
                id = (int)row.Cells[0].Value;
            }
            string name = txtNameRT.Text;
            int limit = Convert.ToInt32(txtRTLimit.Text);
            int dt = Convert.ToInt32(txtRTDT.Text);
            string desc = txtRTDesc.Text;
            RoomTypeBUS.Instance.UpdateRoomType(id, name, limit, dt, desc);
            LoadRoomType();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelRTActive();
            LoadRoomType();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            cancelRTActive();
            LoadRoomType();
        }

        private void btnRTPrice_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dtgvRT.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvRT.SelectedRows[0];
                id = (int)row.Cells[0].Value;
            }
            removePriceBinding();
            UnitPriceBUS.Instance.GetUnitPriceById(id, dtgvPrice);          
            addPriceBinding();
        }

        private void btnPA_Click(object sender, EventArgs e)
        {
            addPriceActive();
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            int idrt = (int)cbbRTP.SelectedValue;
            int idtl = (int)cbbRTT.SelectedValue;
            double price = Convert.ToDouble(txtPrice.Text);
            UnitPriceBUS.Instance.Insert(idrt, idtl, (float)price);
            removePriceActive();
            LoadPrice();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dtgvRT.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvRT.SelectedRows[0];
                id = (int)row.Cells[0].Value;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                RoomTypeBUS.Instance.DeleteRoomType(id, dtgvRT);
                clearBinding();
                addBinding();
            }
        }
    }
}
