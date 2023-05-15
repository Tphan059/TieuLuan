using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookingStatus
    {
        private int _idBS;
        private string _nameBS;
        public int IdBS { get => _idBS; set => _idBS = value; }
        public string NameBS { get => _nameBS; set => _nameBS = value; }

        public BookingStatus(int idBS, string nameBS)
        {
            this.IdBS = idBS;
            this.NameBS = nameBS;
        }

        public BookingStatus(DataRow row)
        {
            this.IdBS = (int)row["idBS"];
            this.NameBS = row["nameBS"].ToString();
        }
    }
}
