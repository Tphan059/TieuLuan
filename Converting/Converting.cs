using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TieuLuan.Converting
{
    public class Converting
    {
        private static Converting instance;
        public static Converting Instance
        {
            get
            {
                if (instance == null)
                    instance = new Converting();
                return instance;
            }
        }
        private Converting() { }

        public int ConvertStringToInt(string str)
        {
            int result;
            if (int.TryParse(str, out result))
            {
                return result;
            }
            else
            {
                // Nếu không thể chuyển đổi thành kiểu int thì trả về giá trị mặc định là 0
                return 0;
            }
        }

        public float ConvertStringToFloat(string str) 
        {
            string numberString = str.Replace(",", "").Replace("₫", "").Trim();
            float result;
            if (float.TryParse(numberString, out result))
            {
                return result;
            }
            else
            {
                return 0.0f;
            }
        }

        public double? ConvertStringToDouble(string str)
        {
            
            double result;
            if (double.TryParse(str, out result))
            {                
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
