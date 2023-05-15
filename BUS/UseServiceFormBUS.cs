using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UseServiceFormBUS
    {
        private static UseServiceFormBUS instance;
        public static UseServiceFormBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new UseServiceFormBUS();
                return instance;
            }
            private set
            {
                UseServiceFormBUS.instance = value;
            }
        }
        
        public UseServiceFormBUS() { }

        
    }
}
