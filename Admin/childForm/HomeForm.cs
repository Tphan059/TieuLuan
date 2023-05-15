using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace TieuLuan.Admin.childForm
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            LoadData();
        }
        #region methods
        private void LoadData()
        {
            LoadRoom();
            
            FloorBUS.Instance.GetFloorToCB(cbbNameFloor);
            FloorBUS.Instance.GetFloorToCB(cbbFloorS);
            RoomTypeBUS.Instance.GetRTToCB(cbbNameRoomType);
            RoomTypeBUS.Instance.GetRTToCB(cbbRTypeS);
            RoomStatusBUS.Instance.GetRTCB(cbbRStatus);
            RoomStatusBUS.Instance.GetRTCB(cbbStatus);
            
        }

        private void LoadRoom()
        {
            RoomBUS.Instance.GetAllRoom(dataGridView1);
            clearDataBinding();
            addDataBinding();
        }

        private void LoadDataBinding()
        {
            clearDataBinding();
            addDataBinding();
        }

        private void addDataBinding()
        {
            txtNameRoom.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Tên phòng", true, DataSourceUpdateMode.Never));
            cbbNameFloor.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Tầng", true, DataSourceUpdateMode.Never));
            cbbNameRoomType.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Loại phòng", true, DataSourceUpdateMode.Never));
            cbbStatus.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Tình trạng", true, DataSourceUpdateMode.Never));
        }

        private void clearDataBinding()
        {
            txtNameRoom.DataBindings.Clear();
            cbbNameFloor.DataBindings.Clear();
            cbbNameRoomType.DataBindings.Clear();
            cbbStatus.DataBindings.Clear();
        }

        private void addActive()
        {
            btnRoomAdd.Enabled = false;
            btnRoomEdit.Enabled = false;
            btnRoomSave.Enabled = true;
            btnRoomCancel.Enabled = true;
            txtNameRoom.Clear();
            txtNameRoom.Focus();
        }

        private void cancelActive()
        {
            btnRoomAdd.Enabled = true;
            btnRoomEdit.Enabled = true;
            btnRoomSave.Enabled = false;
            btnRoomCancel.Enabled = false;
        }

        #endregion

        private void btnRoomAdd_Click(object sender, EventArgs e)
        {
            addActive();
        }

        private void btnRoomSave_Click(object sender, EventArgs e)
        {
            if(txtNameRoom.Text == "")
            {
                MessageBox.Show("Nhập tên phòng");
            }
            else
            {
                string name = txtNameRoom.Text;
                int idRT = (int)cbbNameRoomType.SelectedValue;
                int idRS = (int)cbbStatus.SelectedValue;
                int idFloor = (int)cbbNameFloor.SelectedValue;
                bool nameExists = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Tên phòng"].Value != null && row.Cells["Tên phòng"].Value.ToString() == name)
                    {
                        nameExists = true;
                        break;
                    }    
                }

                if (nameExists)
                {
                    MessageBox.Show("Phòng đã tồn tại");
                }
                else
                {
                    RoomBUS.Instance.InsertRoom(name, idFloor, idRT, idRS);
                    cancelActive();
                    LoadRoom();
                }
                
            }
        }

        private void btnRoomCancel_Click(object sender, EventArgs e)
        {
            cancelActive();
            LoadRoom();
        }

        private void btnRoomReload_Click(object sender, EventArgs e)
        {
            cancelActive();
            LoadRoom();
        }

        private void btnRoomEdit_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                id = (int)row.Cells[0].Value;
            }

            string name = txtNameRoom.Text;
            int idRT = (int)cbbNameRoomType.SelectedValue;
            int idRS = (int)cbbStatus.SelectedValue;
            int idF = (int)cbbNameFloor.SelectedValue;

            RoomBUS.Instance.UpdateRoom(id,name,idF,idRT,idRS);
            LoadRoom();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtNameRoomS.Text;
            RoomBUS.Instance.SearchByName(name, dataGridView1);
            LoadDataBinding();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int idF = (int)cbbFloorS.SelectedValue;
            int idRT = (int)cbbRTypeS.SelectedValue;
            int idRS = (int)cbbRStatus.SelectedValue;
            RoomBUS.Instance.FilterRoom(idF,idRT,idRS,dataGridView1);
            LoadDataBinding();
        }
    }
}
