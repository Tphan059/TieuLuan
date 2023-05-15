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
    public partial class BookingRoomForm : Form
    {
        private string roomName;
        private int roomId;

        public BookingRoomForm(string roomName, int roomId)
        {
            InitializeComponent();
            
            LoadData(roomName, roomId);
        }

        void LoadData(string roomName, int roomId)
        {
            this.roomName = roomName;
            this.roomId = roomId;
            TimeLineBUS.Instance.GetTimeLineToCB(cbbHinhThuc);
        }

        
        private void BookingRoomForm_Load(object sender, EventArgs e)
        {
            label2.Text = roomName;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        { 
            btnBooking.BackColor = Color.FromArgb(61, 61, 61);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnBooking.BackColor = Color.FromArgb(31,31,31);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            btnAddCusInfo.BackColor = Color.White;
            btnAddCusInfo.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnAddCusInfo.ForeColor = Color.White;
            btnAddCusInfo.BackColor = Color.Black;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCusInfo_Click(object sender, EventArgs e)
        {
            string cus = "";
            string cccd = "";
            CustomerBUS.Instance.GetCusByPhone1(txtCusPhone.Text, out cus, out cccd);
            txtNameCus.Text = cus;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            string name = txtCusPhone.Text;
            string phone = txtCusPhone.Text;
            int per = (int)nudPer.Value;
            double datTruoc = Convert.ToDouble(txtDatTruoc.Text);
            string hinhThuc = cbbHinhThuc.Text;

            BookingBUS.Instance.IsBooking(name, phone, roomId, per, (float)datTruoc, hinhThuc, this);
        }
    }
}
