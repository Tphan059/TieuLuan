using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using BUS;
using DTO;
using TieuLuan.Admin.subForm;

namespace TieuLuan.Admin
{
    public partial class AdminForm : Form
    {
        //Files
        private Button currentButton;
        //private Random random;
        //private int tempIndex;
        private Form activeForm;
        private int idNV;
        private List<Room> roomList;
        private List<Receiveroom> receiverList;
        private List<Booking> bookingList;
        private List<Timeline> timeLineList;
        private List<unitPrice> unitPriceList;
        private Timer timer;
        private Account _account;
        public Account Account {  get { return _account; } set { _account = value; } }

        //Constructor
        public AdminForm(int idNV)
        {
            InitializeComponent();
            this.idNV = idNV;
            LoadDataRoom();
            Per();
        }

        private void Per()
        {
            string username = AccountBUS.Instance.GetUserName(idNV);
            int idPer = User_PerBUS.Instance.GetIdPer(username);
            if (idPer == 2)
            {
                btnHome.Visible = false;
                btnCustomer.Visible = false;
                btnBooking.Visible = false;
                btnBill.Visible = false;
                btnRoom.Visible = false;
                btnDevice.Visible = false;
                btnStaff.Visible = false;
                btnService.Visible = false;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #region Methods
        //private Color SelectThemeColor()
        //{
        //    int index = random.Next(ThemeColor.ColorList.Count);
        //    while (tempIndex == index)
        //    {
        //        index = random.Next(ThemeColor.ColorList.Count);
        //    }
        //    tempIndex = index;
        //    string color = ThemeColor.ColorList[index];
        //    return ColorTranslator.FromHtml(color);
        //}

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    //Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(61,61,61);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnBack.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(31, 31, 31);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian hệ thống
            DateTime now = DateTime.Now;

            // Hiển thị thời gian lên label
            lblTime.Text =  now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public void LoadDataRoom()
        {
            flbRoom.Controls.Clear();
            roomList = RoomBUS.Instance.LoadRoom(); 
            timer = new Timer();
            timer.Interval = 1000; // cập nhật giờ sau mỗi 1 giây
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

            foreach (Room item in roomList)
            {
                Button btn = new Button() { Width = 150, Height =  125};
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.UseCompatibleTextRendering = true;
                btn.Click += Btn_Click; ;
                btn.Tag = item;
                btn.Name = "btnRoom_" + item.IdRoom.ToString();
                string nameNV = "";
                StaffBUS.Instance.GetNameStaff(idNV, out nameNV);
                lblUserName.Text = nameNV;
                switch (item.IdRStatus)
                {
                    case 1:
                        btn.ForeColor = Color.White;
                        btn.Text =   item.NameRoom  + Environment.NewLine + "Sẵn sàng đón khách" + Environment.NewLine + DateTime.Now.ToString("HH:mm:ss");
                        btn.BackColor = Color.FromArgb(0, 195, 0);
                        lblCount1.Text = RoomBUS.Instance.GetCountRoomByIdStatus(item.IdRStatus).ToString();
                        break;
                    case 2:
                        receiverList = ReceiveroomBUS.Instance.GetReceiveroomByIdRoom(item.IdRoom);
                        foreach (Receiveroom info in receiverList) 
                        {
                            bookingList = BookingBUS.Instance.GetBookingById(info.IdBook);
                            foreach (Booking book in bookingList)
                            {
                                timeLineList = TimeLineBUS.Instance.GetTimelineByName(book.HinhThuc);
                                foreach (Timeline timeline in  timeLineList)
                                {
                                    unitPriceList = UnitPriceBUS.Instance.GetPriceByRtTl(item.IdRT, timeline.IdTL);
                                    foreach (unitPrice unit in unitPriceList)
                                    {
                                        //int total = unit.Price - info.TraTruoc;
                                        btn.ForeColor = Color.White;
                                        btn.Width = 250;
                                        btn.Tag = item;
                                        btn.Text = item.NameRoom + Environment.NewLine + "Ngày nhận phòng: " + info.DateCheck.ToShortTimeString() + " " + info.DateCheck.ToShortDateString() + Environment.NewLine + "Hình thức: " + book.HinhThuc + Environment.NewLine + Environment.NewLine + "Tiền phòng: " + unit.Price + Environment.NewLine + "Trả trước: " + info.TraTruoc;
                                        btn.AccessibleName = info.IdBook.ToString();
                                        btn.BackColor = Color.Red;
                                        lblCount2.Text = RoomBUS.Instance.GetCountRoomByIdStatus(item.IdRStatus).ToString();
                                    }
                                }
                                
                            }

                        }
                        break;

                    case 5:
                        btn.ForeColor = Color.White;
                        btn.Text = item.NameRoom + Environment.NewLine + "Phòng đang dọn";
                        btn.BackColor = Color.FromArgb(133, 130, 133);
                        lblCount5.Text = RoomBUS.Instance.GetCountRoomByIdStatus(item.IdRStatus).ToString();
                        break;
                    case 3:
                        receiverList = ReceiveroomBUS.Instance.GetReceiveroomByIdRoom(item.IdRoom);
                        foreach (Receiveroom info in receiverList)
                        {
                            bookingList = BookingBUS.Instance.GetBookingById(info.IdBook);
                            foreach (Booking book in bookingList)
                            {
                                timeLineList = TimeLineBUS.Instance.GetTimelineByName(book.HinhThuc);
                                foreach (Timeline timeline in timeLineList)
                                {
                                    unitPriceList = UnitPriceBUS.Instance.GetPriceByRtTl(item.IdRT, timeline.IdTL);
                                    foreach (unitPrice unit in unitPriceList)
                                    {
                                        //int total = unit.Price - info.TraTruoc;
                                        btn.ForeColor = Color.White;
                                        btn.Width = 250;
                                        btn.Tag = item;
                                        btn.AccessibleName = info.IdBook.ToString();
                                        btn.Text = item.NameRoom + Environment.NewLine + "Ngày nhận phòng: " + info.DateCheck.ToShortTimeString() + " " + info.DateCheck.ToShortDateString() + Environment.NewLine + "Hình thức: " + book.HinhThuc + Environment.NewLine + Environment.NewLine + "Tiền phòng: " + unit.Price + Environment.NewLine + "Trả trước: " + info.TraTruoc;
                                        btn.BackColor = Color.FromArgb(199, 0, 200);
                                        lblCount3.Text = RoomBUS.Instance.GetCountRoomByIdStatus(item.IdRStatus).ToString();
                                    }
                                }

                            }

                        }
                        break;
                       

                    case 4:
                        btn.ForeColor = Color.White;
                        btn.Text = item.NameRoom + Environment.NewLine + "Phòng bẩn";
                        btn.BackColor = Color.FromArgb(255, 165, 0);
                        lblCount4.Text = RoomBUS.Instance.GetCountRoomByIdStatus(item.IdRStatus).ToString();
                        break;
                    case 6:
                        btn.ForeColor = Color.White;
                        btn.Text = item.NameRoom + Environment.NewLine + "Phòng đang sửa chữa";
                        btn.BackColor = Color.FromArgb(0, 128, 130);
                        lblCount6.Text = RoomBUS.Instance.GetCountRoomByIdStatus(item.IdRStatus).ToString();
                        break;


                }

                flbRoom.Controls.Add(btn);
            }
        }

        private void Reset()
        {
            LoadDataRoom();
            DisableButton();
            lblTitle.Text = "HOME";
            pnlTitleBar.BackColor = Color.FromArgb(31,31,31);
            pnlLogo.BackColor = Color.FromArgb(31,31,31);
            currentButton = null;
            btnBack.Visible = false;
        }

        
        #endregion
        private void Btn_Click(object sender, EventArgs e)
        {
            
                int roomStatus = ((sender as Button).Tag as Room).IdRStatus;
                string roomName = ((sender as Button).Tag as Room).NameRoom;
                int roomId = ((sender as Button).Tag as Room).IdRoom;
                if (roomStatus == 1)
                {
                    BookingRoomForm bookingRoomForm = new BookingRoomForm(roomName, roomId);
                    bookingRoomForm.FormClosed += new FormClosedEventHandler(BookingRoomForm_FormClose);
                    bookingRoomForm.ShowDialog(this);
                }
                else
                {
                    if (roomStatus == 2 || roomStatus == 3)
                    {
                    string btnName = (sender as Button).Name;
                    int bookingId = int.Parse(this.Controls.Find(btnName, true).FirstOrDefault().AccessibleName);
                    StatusRoomForm statusRoomForm = new StatusRoomForm(roomId, roomName, roomStatus, bookingId, idNV);
                    statusRoomForm.FormClosed += new FormClosedEventHandler(StatusRoomForm_FormClose);
                    statusRoomForm.ShowDialog(this);
                    }
                    else
                    {
                    ChangeStatusRoom changeStatusRoom = new ChangeStatusRoom(roomStatus, roomName, roomId);
                    changeStatusRoom.FormClosed += new FormClosedEventHandler(changeStatusRoomForm_FormClose);
                    changeStatusRoom.ShowDialog(this);
                    }    
                }
                
            
                
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForm.HomeForm(), sender);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForm.CustomerForm(), sender);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForm.BookingForm(), sender);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForm.BillForm(), sender);
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForm.RoomForm(), sender);
        }

        private void btnDevice_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForm.pnlEquipmentInfo(), sender);
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForm.ServiceForm(), sender);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForm.StaffControlForm(idNV), sender);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            
            loginForm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void btnAdminFormClose_MouseHover(object sender, EventArgs e)
        {
            btnAdminFormClose.BackColor = Color.Red;
        }

        private void btnAdminFormClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnAdminFormClose_MouseLeave(object sender, EventArgs e)
        {
            btnAdminFormClose.BackColor = Color.FromArgb(0, 150, 136);
        }

        private void BookingRoomForm_FormClose(object sender, FormClosedEventArgs e)
        {
            LoadDataRoom();
        }

        private void StatusRoomForm_FormClose(object sender, FormClosedEventArgs e)
        {
            LoadDataRoom();
        }

        private void ReceRoomForm_FormClose(object sender, FormClosedEventArgs e)
        {
            LoadDataRoom();
        }

        private void changeStatusRoomForm_FormClose(object sender, FormClosedEventArgs e)
        {
            LoadDataRoom();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            PreBookingForm preBookingForm = new PreBookingForm();
            preBookingForm.ShowDialog();
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            ReceRoomForm receRoomForm = new ReceRoomForm();
            receRoomForm.FormClosed += new FormClosedEventHandler(ReceRoomForm_FormClose);
            receRoomForm.ShowDialog();  
        }
    }
}
