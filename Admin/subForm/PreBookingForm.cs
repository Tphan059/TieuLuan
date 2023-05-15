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

namespace TieuLuan.Admin.subForm
{
    public partial class PreBookingForm : Form
    {
        private int idRT = 0;
        private int SL = 0;

        public PreBookingForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            RoomTypeBUS.Instance.GetRTToCB(cbRT);
            TimeLineBUS.Instance.GetTimeLineToCB(cbbHinhThuc);
        }

        private void addBinding()
        {
            txbRoom.DataBindings.Add(new Binding("Text", dtgv.DataSource, "Tên phòng", true, DataSourceUpdateMode.Never));
        }

        private void removeBinding()
        {
            txbRoom.DataBindings.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.idRT = (int)cbRT.SelectedValue;
            this.SL = (int)nudCount.Value;
            DateTime checkIn = dtpCheckIn.Value;
            if (RoomBUS.Instance.GetRoomByRT(idRT, checkIn).Rows.Count >= SL)
            {
                dtgv.DataSource =  RoomBUS.Instance.GetRoomByRT(idRT, checkIn);
                removeBinding();
                addBinding();
            }
            else
            {
                MessageBox.Show("Không có đủ phòng trống");
            }
            
        }

        private void btnSCus_Click(object sender, EventArgs e)
        {
            string cus = "";
            string cccd = "";
            CustomerBUS.Instance.GetCusByPhone1(txbPhone.Text, out cus, out cccd);
            txbCus.Text = cus;
            txbCCCD.Text = cccd;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            string name = txbCus.Text;
            string phone = txbPhone.Text;
            string cccd = txbCCCD.Text;
            int id = 0;
            if (dtgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgv.SelectedRows[0];
                id = (int)row.Cells[0].Value;
            }
            int per = (int)cbRT.SelectedValue;
            string hinhThuc = cbbHinhThuc.Text;
            DateTime checkIn = dtpCheckIn.Value;
            DateTime checkOut = dtpCheckOut.Value;
            int count = this.SL - 1;
            if (checkIn > checkOut)
            {
                MessageBox.Show("Ngày nhận phải nhỏ hơn ngày trả dự kiến");
            }
            else
            {
                if(BookingBUS.Instance.PreBooking(name, phone, cccd, id, per, hinhThuc, checkIn, checkOut))
                {
                    MessageBox.Show("Đặt phòng trước thành công");
                    
                    if (count == 0)
                    {
                        dtgv.DataSource = null;
                        nudCount.Value = 0;
                    }
                    else
                    {
                        this.SL = (int)nudCount.Value - 1;
                        if (RoomBUS.Instance.GetRoomByRT(idRT, checkIn).Rows.Count >= SL)
                        {
                            dtgv.DataSource = RoomBUS.Instance.GetRoomByRT(idRT, checkIn);
                            removeBinding();
                            addBinding();
                        }
                        else
                        {
                            MessageBox.Show("Không có đủ phòng trống");
                        }
                    }
                    

                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
