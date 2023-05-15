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

namespace TieuLuan.Admin.subForm
{
    public partial class ChangeStatusRoom : Form
    {
        private int roomstatus = 0;
        private string name = "";
        private int id = 0;
        public ChangeStatusRoom(int roomstatus, string roomname, int id)
        {
            InitializeComponent();
            this.name = roomname;
            this.roomstatus = roomstatus;
            this.id = id;
            LoadForm();
        }

        private void LoadForm()
        {
            
            label1.Text = name;
            if(roomstatus == 5) 
            {
                radioButton2.Checked = true;
                radioButton2.Text = "Đang dọn phòng";
            }
            else
            {
                if (roomstatus == 6)
                {
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    radioButton3.Text = "Đang sửa chữa";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                RoomBUS.Instance.changeStatus(id, 1,this);
            }
            else
            {
                if (radioButton2.Checked)
                {
                    RoomBUS.Instance.changeStatus(id, 5, this);
                }
                else 
                { 
                    if (radioButton3.Checked)
                    {
                        RoomBUS.Instance.changeStatus(id, 6, this);
                    }
                    else
                    {
                        MessageBox.Show("Chọn trạng thái");
                    }
                }
            }    
        }
    }
}
