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
    public partial class PayForm : Form
    {
        private int idRoom;
        private int idBook;
        private double serviceFee;
        private string nameRoom;
        private int idNV;
        public PayForm(int roomId, int bookingId, double serviceFee, string roomName, int idNV)
        {
            InitializeComponent();
            this.idNV = idNV;
            LoadData(bookingId, roomId, serviceFee, roomName);
        }

        void LoadData(int idBook, int idRoom, double serviceFee, string nameRoom)
        {
            this.idBook = idBook;
            this.idRoom = idRoom;
            this.serviceFee = serviceFee;
            this.nameRoom = nameRoom;
            
            double roomCharge = BillBUS.Instance.GetRoomCharge(idBook, idRoom);
            lblNameRoom.Text = nameRoom;
            txtRoomCharge.Text = roomCharge.ToString();
            txtServiceFee.Text = serviceFee.ToString();
            txtTotal.Text = (roomCharge + serviceFee).ToString();
            txtPay.Focus();
        }

        private void txtPay_TextChanged(object sender, EventArgs e)
        {
            double pay = 0;
            double.TryParse(txtPay.Text, out pay);


            double total = 0;
            double.TryParse(txtTotal.Text, out total);

            

            
            double payment = pay - total;

            if (payment > 0) 
            {
                txtPayment.Text = payment.ToString();
            }
            else { txtPayment.Text = "0"; }
            
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(txtTotal.Text);
            double roomCharge = Convert.ToDouble(txtRoomCharge.Text);
            double arise = Convert.ToDouble(txtPhuPhi.Text);
            if (txtPay.Text == "")
            {
                MessageBox.Show("Chưa nhập tiền khách đưa");
            }
            else
            {
                double pay = Convert.ToDouble(txtPay.Text);
                double payment = Convert.ToDouble(txtPayment.Text);
                if (pay < total)
                {
                    MessageBox.Show("Không thể thanh toán");
                }
                else
                {
                    BillBUS.Instance.InserBill(idBook, idRoom, idNV, (float)total, (float)roomCharge, (float)serviceFee, (float)arise, (float)pay, (float)payment);
                    this.Close();
                }
            }
            
        }

        private void txtPhuPhi_TextChanged(object sender, EventArgs e)
        {
            double arise = 0;
            double.TryParse(txtPhuPhi.Text, out arise);

            double roomCharge = 0;
            double.TryParse(txtRoomCharge.Text, out roomCharge);

            double serviceFee = 0;
            double.TryParse(txtServiceFee.Text, out serviceFee);

            double total = roomCharge + serviceFee + arise;

            if (total > 0)
            {
                txtTotal.Text = total.ToString();
            }
            else { txtTotal.Text = (roomCharge + serviceFee).ToString(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
