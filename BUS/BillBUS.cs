using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BillBUS
    {
        private static BillBUS instance;
        public static BillBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillBUS();
                return instance;
            }
            private set
            {
                BillBUS.instance = value;
            }
        }

        public BillBUS() { }

        public double GetRoomCharge(int idBook, int idRoom)
        {
            DataRow row = BillDAO.Instance.GetRoomCharge(idBook, idRoom).Rows[0];
            return Convert.ToDouble(row["totalPrice"].ToString());
        }

        public void InserBill(int idBook, int idRoom, int idNV, float total, float roomCharge, float servFee, float arise, float pay, float payment)
        {
            BillDAO.Instance.InsertBill(idBook, idRoom, idNV, total, roomCharge, servFee, arise, pay, payment);
        }

        public void GetAllBill(DataGridView dt)
        {
            dt.DataSource = BillDAO.Instance.GetAllBill();
        }

        public void SearchBill(DateTime from, DateTime to, DataGridView dt)
        {
            dt.DataSource = BillDAO.Instance.SearchBill(from, to);
        }
    }
}
