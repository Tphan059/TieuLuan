using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Service
    {
        private int _idServ;
        private string _nameServ;
        private int _idST;
        private string _unit;
        private float _priceServ;
        private bool _statusServ;

        public int IdServ { get => _idServ; set => _idServ = value; }
        public string NameServ { get => _nameServ; set => _nameServ = value; }
        public int IdST { get => _idST; set => _idST = value; }
        public string Unit { get => _unit; set => _unit = value; }
        public float PriceServ { get => _priceServ; set => _priceServ = value; }
        public bool StatusServ { get => _statusServ; set => _statusServ = value; }

        public Service (int idServ, string nameServ, int idST, string unit, float priceServ, bool statusServ)
        {
            this.IdServ = idServ;
            this.NameServ = nameServ;
            this.IdST = idST;
            this.Unit = unit;
            this.PriceServ = priceServ;
            this.StatusServ = statusServ;
        }
        public Service (DataRow row)
        {
            this.IdServ = (int)row["idServ"];
            this.NameServ = row["nameServ"].ToString();
            this.IdST = (int)row["idST"];
            this.Unit = row["unit"].ToString();
            this.PriceServ = (float)Convert.ToDouble(row["priceServ"].ToString());
            this.StatusServ = (bool)row["statusServ"];
        }
    }
}
