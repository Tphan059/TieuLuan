using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class PermisionBUS
    {
        private static PermisionBUS instance;
        public static PermisionBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PermisionBUS();
                return instance;
            }

            private set
            {
                PermisionBUS.instance = value;
            }
        }

        public PermisionBUS() { }

        public void GetPermision(ComboBox cb)
        {
            cb.DataSource = PermisionDAO.Instance.GetPermision();
            cb.DisplayMember = "namePer";
            cb.ValueMember = "idPer";
        }
    }
}
