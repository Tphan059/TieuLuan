using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TieuLuan.Admin.childForm
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadBill();
        }

        private void LoadBill()
        {
            BillBUS.Instance.GetAllBill(dtgvBill);
            removeBinding();
            addDataBinding();
        }
        
        private void addDataBinding()
        {
            txbNameNV.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "Mã đặt phòng", true, DataSourceUpdateMode.Never));
            txbIdB.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "Người lập", true, DataSourceUpdateMode.Never));
            txbRoomCharge.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "Tiền phòng", true, DataSourceUpdateMode.Never));
            txbFee.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "Phí dịch vụ", true, DataSourceUpdateMode.Never));
            txbPhatSinh.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "Phát sinh", true, DataSourceUpdateMode.Never));
           
            txbTotal.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "Tổng", true, DataSourceUpdateMode.Never));
            txbPay.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "Khách đưa", true, DataSourceUpdateMode.Never));
            txbPayment.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "Tiền thồi", true, DataSourceUpdateMode.Never));
            dtbDate.DataBindings.Add(new Binding("value", dtgvBill.DataSource, "Ngày lập", true, DataSourceUpdateMode.Never));

        }

        private void removeBinding()
        {
            txbIdB.DataBindings.Clear();
            txbNameNV.DataBindings.Clear();
            txbRoomCharge.DataBindings.Clear();
            txbFee.DataBindings.Clear();
            txbPhatSinh.DataBindings.Clear();
            txbTotal.DataBindings.Clear();
            txbPay.DataBindings.Clear();
            txbPayment.DataBindings.Clear();
            dtbDate.DataBindings.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value;
            DateTime to = dtpTo.Value;
            if (from <= to)
            {
                
                BillBUS.Instance.SearchBill(from, to, dtgvBill);
                removeBinding();
                addDataBinding();
            }
            else
            {
                MessageBox.Show("Ngày tìm kiếm sai");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
