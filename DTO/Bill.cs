using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        private int _idBill;
        private int _idNV;
        private int _idBook;
        private DateTime _dateFounded;
        private float _total;
        private float _roomCharge;
        private float _serviceFee;
        private float _arise;
        private float _tax;
        private float _pay;
        private float _payment;

        public int IdBill { get => _idBill; set => _idBill = value; }
        public int IdNV { get => _idNV; set => _idNV = value; }
        public int IdBook { get => _idBill; set => _idBook = value; }
        public DateTime DateFounded { get => _dateFounded; set => _dateFounded = value; }
        public float Total { get => _total; set => _total = value; }
        public float RoomCharge { get => _roomCharge; set => _roomCharge = value; }
        public float ServiceFee { get => _serviceFee; set => _serviceFee = value; }
        public float Arise { get => _arise; set => _arise = value; }
        public float Tax { get => _tax; set => _tax = value; }
        public float Pay { get => _pay; set => _pay = value; }
        public float Payment { get => _payment; set => _payment = value; }

        public Bill (int idBill, int idNV, int idBook, DateTime dateFounded, float total, float roomCharge, float serviceFee, float arise, float tax, float pay, float payment)
        {
            this.IdBill = idBill;
            this.IdNV = idNV;
            this.IdBook = idBook;
            this.DateFounded = dateFounded;
            this.Total = total;
            this.RoomCharge = roomCharge;
            this.ServiceFee = serviceFee;
            this.Arise = arise;
            this.Tax = tax;
            this.Pay = pay;
            this.Payment = payment; 
        }

        public Bill (DataRow row) 
        {
            this.IdBill = (int)row["idBill"];
            this.IdNV = (int)row["idNV"];
            this.IdBook = (int)row["idBook"];
            this.DateFounded = (DateTime)row["dateFounded"];
            this.Total = (float)Convert.ToDouble(row["total"].ToString());
            this.RoomCharge = (float)Convert.ToDouble(row["roomCharge"].ToString());
            this.ServiceFee = (float)Convert.ToDouble(row["serviceFee"].ToString());
            this.Arise = (float)Convert.ToDouble(row["arise"].ToString());
            this.Tax = (float)Convert.ToDouble(row["tax"].ToString());
            this.Pay = (float)Convert.ToDouble(row["pay"].ToString());
            this.Payment = (float)Convert.ToDouble(row["payment"].ToString());
        }
    }
}
