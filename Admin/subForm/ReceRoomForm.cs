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
    public partial class ReceRoomForm : Form
    {
        private int idbook = 0;
        private int roomid = 0; 
        public ReceRoomForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = "";
            string room = "";
            DateTime checkIn = DateTime.Now;
            DateTime checkOut = DateTime.Now;
            ReceiveroomBUS.Instance.GetPreFormCus(txbPhone.Text, out name, out checkIn, out checkOut, out room, out idbook, out roomid);
            txbCus.Text = name;
            txbRoom.Text = room;
            dtpCheckIn.Value = checkIn;
            dtpCheckOut.Value = checkOut;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookingBUS.Instance.GetPreBook(idbook, roomid, this);
        }
    }
}
