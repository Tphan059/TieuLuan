using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TieuLuan.Admin.subForm
{
    public partial class StatusRoomForm : Form
    {
        private int roomId;
        private int roomStatus;
        private string roomName;
        private int bookingId;
        private int idNV;

        public StatusRoomForm(int roomId, string roomName, int roomStatus, int bookingId, int idNV)
        {
            InitializeComponent();
            this.roomId = roomId;
            this.roomName = roomName;
            this.bookingId = bookingId;
            this.idNV = idNV;
            LoadData(roomStatus);
        }

        void LoadData(int roomStatus)
        {
            //Khai báo biến
            this.roomStatus = roomStatus;            
            int customerId = 0;
            string hinhThuc = "";
            string nameCus = "";
            DateTime checkIn = DateTime.Now;

            //Gọi dữ liệu
            BookingBUS.Instance.GetBookingByIdBook(bookingId, out customerId, out hinhThuc);
            CustomerBUS.Instance.GetCustomerById(customerId, out nameCus);
            ReceiveroomBUS.Instance.GetReceiveroomByIdBookRoom(bookingId, roomId, out checkIn);
            //ServiceBUS.Instance.GetAllServiceToCB(cbbService);
            ServiceTypeBUS.Instance.GetServiceTypeToCb(cbbST);
            UseServiceInfoBUS.Instance.ShowFormService(lsvSeriveForm, txtTotalPrice, bookingId);
            //Gán tham số
            label1.Text = roomName;
            lblIdBooking.Text = bookingId.ToString();
            lblHinhThuc.Text = hinhThuc;
            lblNameCus.Text = nameCus;
            TimeSpan timeDifference = DateTime.Now - checkIn; // Tính khoảng thời gian giữa ngày giờ hiện tại và ngày giờ nhập vào
            string timeDifferenceString = timeDifference.ToString(@"d\.hh\:mm\:ss");
            lblCheckIn.Text = checkIn.ToString();
            lblTime.Text = timeDifferenceString;                             
            if (roomStatus == 2)
                btnChangeStauts.Text = "Khách ra ngoài";
            else btnChangeStauts.Text = "Khách đã về phòng";
            
        }

        private void btnChangeStauts_Click(object sender, EventArgs e)
        {
            RoomBUS.Instance.ChangeStatus2To3(btnChangeStauts.Text, roomId);
            RoomBUS.Instance.GetIdRSByIdRoom(roomId, out roomStatus);
            LoadData(roomStatus);
        }

        private void cbbST_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            ServiceType selected = cb.SelectedItem as ServiceType;
            id = selected.IdST;
            ServiceBUS.Instance.GetServiceToCB(cbbService,id);
        }

        private void btnUserServ_Click(object sender, EventArgs e)
        {
            int count = (int)nmServiceCount.Value;
            int idServ = (cbbService.SelectedItem as Service).IdServ;
            UseServiceInfoBUS.Instance.InsertUseServiceInfo(bookingId, idServ, count);
            UseServiceInfoBUS.Instance.ShowFormService(lsvSeriveForm, txtTotalPrice, bookingId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            double servFee = Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]);
            if (roomStatus == 2)
            {
                PayForm payForm = new PayForm(roomId, bookingId, servFee, roomName, idNV);
                payForm.FormClosed += new FormClosedEventHandler(payForm_FormClose);
                payForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Khách chưa về phòng");
            }
        }

        private void payForm_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
