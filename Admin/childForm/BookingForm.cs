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
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            BookingBUS.Instance.GetBooking(dataGridView1);
            removeBinding();
            addBinding();
            RoomBUS.Instance.GetAllRoomToCB(cbbRoom);
        }

        private void addBinding()
        {
            txbCusBooking.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Khách hàng", true, DataSourceUpdateMode.Never));
            txbRoom.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Phòng", true, DataSourceUpdateMode.Never));
            txbPer.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Số người", true, DataSourceUpdateMode.Never));
            txbHinhThuc.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Hình thức", true, DataSourceUpdateMode.Never));
            txbStatus.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Trạng thái", true, DataSourceUpdateMode.Never));
            dtpBookDate.DataBindings.Add(new Binding("value", dataGridView1.DataSource, "Ngày đặt", true, DataSourceUpdateMode.Never));
            dtpCheckIn.DataBindings.Add(new Binding("value", dataGridView1.DataSource, "Ngày nhận", true, DataSourceUpdateMode.Never));
            dtpCheckOut.DataBindings.Add(new Binding("value", dataGridView1.DataSource, "Ngày trả", true, DataSourceUpdateMode.Never));
        }

        private void removeBinding()
        {
            txbCusBooking.DataBindings.Clear();
            txbRoom.DataBindings.Clear();
            txbPer.DataBindings.Clear();
            txbHinhThuc.DataBindings.Clear();
            txbStatus.DataBindings.Clear();
            dtpBookDate.DataBindings.Clear();
            dtpCheckIn.DataBindings.Clear();
            dtpCheckOut.DataBindings.Clear();
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            DateTime checkIn = dtpCheckInS.Value;
            DateTime checkOut = dtpCheckOutS.Value;
            if(checkIn > checkOut) 
            {
                MessageBox.Show("Sai tham số");
            }
            else
            {
                BookingBUS.Instance.SearchBooking(checkIn, checkOut,dataGridView1);
                removeBinding();
                addBinding();
            }
        }

        private void btnBookServF_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                id = (int)row.Cells[0].Value;
            }

            subForm.ServiceForm serviceForm = new subForm.ServiceForm(id);
            serviceForm.ShowDialog();
        }
    }
}
