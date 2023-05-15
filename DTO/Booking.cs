using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Booking
    {
        private int _idBook;
        private int _idCus;
        private int _numPer;
        private DateTime _bookDate;
        private string _hinhThuc;
        private int _idBS;

        public int IdBook { get => _idBook; set => _idBook = value; }
        public int IdCus { get => _idCus; set => _idCus = value; }
        public int NumPer { get => _numPer; set => _numPer = value; }
        public DateTime BookDate { get => _bookDate; set => _bookDate = value; }
        public string HinhThuc { get => _hinhThuc; set => _hinhThuc = value; }
        public int IdBS { get => _idBS; set => _idBS = value; }

        public Booking (int idBook, int idCus, int numPer, DateTime bookDate, int idBS, string hinhThuc)
        {
            this.IdBook = idBook;
            this.IdCus = idCus;
            this.NumPer = numPer;
            this.BookDate = bookDate;
            this.IdBS = idBS;
            this.HinhThuc = hinhThuc;
        }

        public Booking (DataRow row)
        {
            this.IdBook = (int)row["idBook"];
            this.IdCus = (int)row["idCus"];
            this.NumPer = (int)row["numPer"];
            this.BookDate = (DateTime)row["bookDate"];
            this.IdBS = (int)row["idBS"];
            this.HinhThuc = row["hinhThuc"].ToString();
        }
    }
}
