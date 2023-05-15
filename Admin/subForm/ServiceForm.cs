using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TieuLuan.Admin.subForm
{
    public partial class ServiceForm : Form
    {
        private int id = 0;
        public ServiceForm(int id)
        {
            InitializeComponent();
            this.id = id;
            UseServiceInfoBUS.Instance.ShowFormService2(listView1, id);
        }


    }
}
