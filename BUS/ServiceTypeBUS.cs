using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class ServiceTypeBUS
    {
        private static ServiceTypeBUS instance;
        public static ServiceTypeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServiceTypeBUS();
                return instance;
            }
            private set
            {
                ServiceTypeBUS.instance = value;
            }
        }
        public ServiceTypeBUS() { }

        public void GetServiceTypeToCb (ComboBox cb)
        {
            cb.DataSource = ServiceTypeDAO.Instance.GetServiceTypes();
            cb.DisplayMember = "nameST";
            cb.ValueMember = "idST";
        }

        public void GetServiceTypeToDataGridView (DataGridView dataGridView) 
        {
            dataGridView.DataSource = ServiceTypeDAO.Instance.GetServiceTypesDT();
        }
    }
}
