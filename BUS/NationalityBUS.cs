using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class NationalityBUS
    {
        private static NationalityBUS instance;
        public static NationalityBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NationalityBUS();
                return instance;
            }

            private set
            {
                NationalityBUS.instance = value;
            }
        }
        public NationalityBUS() { }

        public void GetNationality(ComboBox cb)
        {
            cb.DataSource = NationalityDAO.Instance.GetNationality();
            cb.DisplayMember = "nameNa";
            cb.SelectedIndex = 0;
            cb.ValueMember = "idNa";
        }
    }
}
