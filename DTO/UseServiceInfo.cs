using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UseServiceInfo
    {
        private string _nameServ;
        private int _count;
        private float _price;
        private float _totalPrice;

        public string NameServ { get { return _nameServ; } set { _nameServ = value; } }
        public int Count { get { return _count; } set { _count = value; } }
        public float Price { get { return _price; } set { _price = value; } }
        public float TotalPrice { get { return _totalPrice; } set { _totalPrice = value; } }

        public UseServiceInfo(string nameServ, int count, float price, float totalPrice) 
        {
            this.NameServ = nameServ;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public UseServiceInfo(DataRow row)
        {
            this.NameServ = row["nameServ"].ToString();
            this.Price = (float)Convert.ToDouble(row["priceServ"].ToString());
            this.Count = (int)row["quantity"];           
            this.TotalPrice = (int)Convert.ToDouble(row["totalPrice"].ToString());
        }
    }
}
