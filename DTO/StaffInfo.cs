using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StaffInfo
    {
        private int _id;
        private string _nameNV;
        private bool _sexNV;
        private DateTime _dob;
        private string _address;
        private string _email;
        private string _phone;
        private string _userName;
        private string _permision;

        public StaffInfo(int id, string name, bool sex, DateTime dob, string address, string email, string phonem, string user, string per) 
        {
            this.Id = id;
            this.NameNV = name;
            this.SexNV = sex;
            this.Dob = dob;
            this.Address = address;
            this.Email = email;
            this.Phone = phonem;                
            this.UserName = user;
            this.Permision = per;
        }

        public StaffInfo (DataRow row)
        {
            this.Id = (int)row["ID"];
            this.NameNV = row["Tên nhân viên"].ToString();
            this.SexNV = (bool)row["Giới tính"];
            this.Dob = (DateTime)row["Ngày sinh"];
            this.Address = row["Địa chỉ"].ToString();
        }

        public int Id { get => _id; set => _id = value; }
        public string NameNV { get => _nameNV; set => _nameNV = value; }
        public bool SexNV { get => _sexNV; set => _sexNV = value; }
        public DateTime Dob { get => _dob; set => _dob = value; }
        public string Address { get => _address; set => _address = value; }
        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Permision { get => _permision; set => _permision = value; }
    }
}
