using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BookingBUS
    {
        private static BookingBUS instance;
        public static BookingBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BookingBUS();
                return instance;
            }
            private set
            {
                BookingBUS.instance = value;
            }
        }
        public BookingBUS() { }

        public void IsBooking (string nameCus, string phoneCus, int idRoom, int limiPer, float datTruoc , string hinhThuc, Form form) 
        {
            //return BookingDAO.Instance.CreateNewBookingGuest(nameCus, phoneCus, idRoom, limiPer, datTruoc , hinhThuc);
            if (BookingDAO.Instance.CreateNewBookingGuest(nameCus, phoneCus, idRoom, limiPer, datTruoc, hinhThuc))
            {
                MessageBox.Show("Đặt phòng thành công");
                form.Close();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        public void GetBookingByIdBook(int idBooking, out int idCus, out string hinhThuc)
        {
            DataRow row = BookingDAO.Instance.GetBookingById1(idBooking).Rows[0];
            idCus = (int)row["idCus"];
            hinhThuc = row["hinhThuc"].ToString();

        }

        public List<Booking> GetBookingById(int idBooking)
        {
            return BookingDAO.Instance.GetBookingById(idBooking);
        }

        public void GetBooking(DataGridView dt)
        {
            dt.DataSource = BookingDAO.Instance.GetBooking();   
        }

        public void SearchBooking( DateTime checkIn , DateTime checkOut, DataGridView dt)
        {
            dt.DataSource = BookingDAO.Instance.SearchBooking( checkIn, checkOut);
        }

        public bool PreBooking(string name, string phone, string cccd, int id, int per, string hinhThuc, DateTime checkIn, DateTime checkOut)
        {
            return BookingDAO.Instance.PreBooking(name, phone, cccd, id, per, hinhThuc, checkIn, checkOut);

        }

        public void GetPreBook(int idbook, int idroom, Form form)
        {
            if(BookingDAO.Instance.GetPre(idbook, idroom))
            {
                MessageBox.Show("Nhận phòng thành công ");
                form.Close();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
