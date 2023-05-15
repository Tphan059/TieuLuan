using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class unitPrice
    {
        private int _idRT;
        private int _idTL;
        private float _price;
        public int IdRT { get => _idRT; set => _idRT = value; }
        public int IdTL { get => _idTL; set => _idTL = value; }
        public float Price { get => _price; set => _price = value; }
        public unitPrice (int idRT, int idTL, float price)
        {
            this.IdRT = idRT;
            this.IdTL = idTL;
            this.Price = price;
        }

        public unitPrice(DataRow row)
        {
            this.IdRT = (int)row["idRT"];
            this.IdTL = (int)row["idTL"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
    }
}
