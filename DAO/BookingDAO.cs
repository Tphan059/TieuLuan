using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BookingDAO
    {
        private static BookingDAO instance;
        public static BookingDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BookingDAO();
                return instance;
            }
            private set
            {
                BookingDAO.instance = value;
            }
        }
        private BookingDAO() { }

        public bool CreateNewBookingGuest(string nameCus, string phoneCus, int idRoom, int limiPer, float datTruoc , string hinhThuc)
        {
            string query = " exec USP_CreateBookingGuest @nameCus , @phoneCus , @idRoom , @limitPer , @datTruoc , @hinhThuc ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {nameCus, phoneCus, idRoom, limiPer,  datTruoc , hinhThuc });
            return result > 0;
        }

        public List<Booking> GetBookingById(int idBooking)
        {
            List<Booking> bookings = new List<Booking>();
            string query = "exec USP_GetBookingByID @idBooking";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {idBooking});
            foreach(DataRow row in data.Rows)
            {
                Booking item = new Booking(row);
                bookings.Add(item);
            }
            return bookings;
        }

        public DataTable GetBookingById1(int idBooking)
        {
            string query = "exec USP_GetBookingByID @idBooking";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idBooking });

            return data;
        }

        public DataTable GetBooking()
        {
            string query = "exec USP_GetBooking";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchBooking(DateTime checkIn, DateTime checkOut)
        {
            string query = "exec USP_SearchBooking   @checkIn , @checkOut";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {checkIn, checkOut});
        }

        public bool PreBooking(string name, string phone, string cccd, int id, int per, string hinhThuc, DateTime checkIn, DateTime checkOut)
        {
            string query = "exec USP_NewPreBooking @nameCus  , @phoneCus , @cccd , @idRoom  ,  @limitPer , @hinhThuc , @checkIn , @checkOut  ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, phone, cccd, id, per, hinhThuc, checkIn, checkOut});
            return result > 0;
        }

        public bool GetPre(int idbook, int idroom)
        {
            string query = "exec SetPreBook @idbook , @idroom";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {idbook, idroom});
            return result > 0;
        }
    }
}
