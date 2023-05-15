using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        private int _idCus;
        private string _nameCus;
        private string _emailCus;
        private string _addressCus;
        private bool _sexCus;
        private string _idCard;
        private int _idNa;
        private string _phoneCus;
        private bool _statusCus;

        public int IdCus { get => _idCus; set => _idCus = value; }
        public string NameCus { get => _nameCus; set => _nameCus = value; }
        public string EmailCus { get => _emailCus; set => _emailCus = value; }
        public string AddressCus { get => _addressCus; set => _addressCus = value; }
        public bool SexCus { get => _sexCus; set => _sexCus = value; }
        public string IdCard { get => _idCard; set => _idCard = value; }
        public int IdNa { get => _idNa; set => _idNa = value; }
        public string PhoneCus { get => _phoneCus; set => _phoneCus = value; }
        public bool StatusCus { get => _statusCus; set => _statusCus = value; }

        public Customer (int idCus, string nameCus, string emailCus, string addressCus, bool sexCus, string idCard, int idNa, string phoneCus, bool statusCus)
        {
            this.IdCus = idCus;
            this.NameCus = nameCus;
            this.EmailCus = emailCus;
            this.AddressCus = addressCus;
            this.SexCus = sexCus;
            this.IdCard = idCard;
            this.IdNa = idNa;
            this.PhoneCus = phoneCus;
            this.StatusCus = statusCus;
        }

        public Customer (DataRow row) 
        {            
            this.IdCus = (int)row["idCus"];
            this.NameCus = row["nameCus"].ToString();
            this.EmailCus = row["emailCus"].ToString();
            this.AddressCus = row["addressCus"].ToString();
            this.SexCus = (bool)row["sexCus"];
            this.IdCard = row["idCard"].ToString();
            this.IdNa = (int)row["idNa"];
            this.PhoneCus = row["phoneCus"].ToString();
            this.StatusCus = (bool)row["statusCus"];
        }
    }
}
