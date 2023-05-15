using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class FloorBUS
    {
        private static FloorBUS instance;
        public static FloorBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new FloorBUS();
                return instance;
            }

            private set
            {
                FloorBUS.instance = value;
            }
        }
        public FloorBUS() { }

        public void GetFloorToCB(ComboBox cb)
        {
            cb.DataSource = FloorDAO.Instance.GetFloor();
            cb.DisplayMember = "nameFloor";
            cb.ValueMember = "idFloor";
        }
    }
}
