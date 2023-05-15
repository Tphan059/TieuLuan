using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class UseServiceBUS
    {
        private static UseServiceBUS instance;
        public static UseServiceBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new UseServiceBUS();
                return instance;
            }
            private set
            {
                UseServiceBUS.instance = value; 
            }
        }
        public UseServiceBUS() { }

        public void InsertUseSerice(int idForm, int idServ, int count)
        {
            UseServiceDAO.Instance.InsertUseService(idForm, idServ, count);

        }
    }
}
