using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Staff
    {
        private int _idNV;
        private string _nameNV;
        private DateTime _dateOfBirth;
        private bool _sexNV;
        private string _addressNV;
        private string _emailNV;
        private string _phoneNV;

        public int IdNV { get { return _idNV; } set { _idNV = value; } }
        public string NameNV { get { return _nameNV; } set { _nameNV = value; } }
        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }
        public bool SexNV { get { return _sexNV; } set { _sexNV = value; } }
        public string AddressNV { get { return _addressNV; } set { _addressNV = value; } }
        public string EmailNV { get { return _emailNV; } set { _emailNV = value; } }
        public string PhoneNV { get { return _phoneNV; } set { _phoneNV = value; } }

        public Staff (int idNV, string nameNV, DateTime dateOfBirth, bool sexNV, string addressNV, string emailNV, string phoneNV)
        {
            this.IdNV = idNV;
            this.NameNV = nameNV;
            this.DateOfBirth = dateOfBirth;
            this.SexNV = sexNV;
            this.AddressNV = addressNV;
            this.EmailNV = emailNV;
            this.PhoneNV = phoneNV;
        }

        public Staff(DataRow row)
        {
            this.IdNV = (int)row["idNV"];
            this.NameNV = row["nameNV"].ToString();
            this.DateOfBirth = (DateTime)row["dateOfBirth"];
            this.SexNV = (bool)row["sexNV"];
            this.AddressNV = row["AddressNV"].ToString();
            this.EmailNV = row["emailNV"].ToString();
            this.PhoneNV = row["phoneNV"].ToString();
        }
    }
}
