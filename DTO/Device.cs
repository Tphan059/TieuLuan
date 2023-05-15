using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Device
    {
        private int _idTB;
        private string _nameTB;
        private int _priceTB;
        private string _unitTB;
        private bool _statusTB;
        public int IdTB { get => _idTB; set => _idTB = value;}
        public string NameTB { get => _nameTB; set => _nameTB = value; }
        public int PriceTB { get => _priceTB; set => _priceTB = value; }
        public string UnitTB { get => _unitTB; set => _unitTB = value; }
        public bool StatusTB { get => _statusTB; set => _statusTB = value; }

        public Device (int idTB, string nameTB, int priceTB, string unitTB, bool statusTB)
        {
            this.IdTB = idTB;
            this.NameTB = nameTB;
            this.PriceTB = priceTB;
            this.UnitTB = unitTB;
            this.StatusTB = statusTB;
        }

        public Device (DataRow row)
        {
            this.IdTB = (int)row["idTB"];
            this.NameTB = row["nameTB"].ToString();
            this.PriceTB = (int)row["priceTB"];
            this.UnitTB = row["unitTB"].ToString();
            this.StatusTB = (bool)row["statusTB"];
        }
    }
}
