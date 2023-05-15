namespace TieuLuan.Admin.childForm
{
    partial class BillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.pnlBillInfo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.txbPhatSinh = new System.Windows.Forms.TextBox();
            this.txbFee = new System.Windows.Forms.TextBox();
            this.txbRoomCharge = new System.Windows.Forms.TextBox();
            this.dtbDate = new System.Windows.Forms.DateTimePicker();
            this.txbNameNV = new System.Windows.Forms.TextBox();
            this.txbIdB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.txbPay = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txbPayment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.pnlBillInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.txbPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvBill
            // 
            this.dtgvBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dtgvBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgvBill.Location = new System.Drawing.Point(13, 13);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersVisible = false;
            this.dtgvBill.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.dtgvBill.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(851, 578);
            this.dtgvBill.TabIndex = 0;
            // 
            // pnlBillInfo
            // 
            this.pnlBillInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBillInfo.Controls.Add(this.label12);
            this.pnlBillInfo.Controls.Add(this.label11);
            this.pnlBillInfo.Controls.Add(this.txbPayment);
            this.pnlBillInfo.Controls.Add(this.textBox1);
            this.pnlBillInfo.Controls.Add(this.label8);
            this.pnlBillInfo.Controls.Add(this.label6);
            this.pnlBillInfo.Controls.Add(this.label5);
            this.pnlBillInfo.Controls.Add(this.label4);
            this.pnlBillInfo.Controls.Add(this.label3);
            this.pnlBillInfo.Controls.Add(this.label2);
            this.pnlBillInfo.Controls.Add(this.label1);
            this.pnlBillInfo.Controls.Add(this.txbTotal);
            this.pnlBillInfo.Controls.Add(this.txbPhatSinh);
            this.pnlBillInfo.Controls.Add(this.txbFee);
            this.pnlBillInfo.Controls.Add(this.txbRoomCharge);
            this.pnlBillInfo.Controls.Add(this.dtbDate);
            this.pnlBillInfo.Controls.Add(this.txbNameNV);
            this.pnlBillInfo.Controls.Add(this.txbIdB);
            this.pnlBillInfo.Location = new System.Drawing.Point(870, 13);
            this.pnlBillInfo.Name = "pnlBillInfo";
            this.pnlBillInfo.Size = new System.Drawing.Size(338, 270);
            this.pnlBillInfo.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tổng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Phát sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phí dịch vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tiền phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Người lập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã đặt phòng:";
            // 
            // txbTotal
            // 
            this.txbTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTotal.ForeColor = System.Drawing.Color.White;
            this.txbTotal.Location = new System.Drawing.Point(124, 173);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(186, 22);
            this.txbTotal.TabIndex = 7;
            // 
            // txbPhatSinh
            // 
            this.txbPhatSinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txbPhatSinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPhatSinh.ForeColor = System.Drawing.Color.White;
            this.txbPhatSinh.Location = new System.Drawing.Point(124, 145);
            this.txbPhatSinh.Name = "txbPhatSinh";
            this.txbPhatSinh.Size = new System.Drawing.Size(186, 22);
            this.txbPhatSinh.TabIndex = 5;
            // 
            // txbFee
            // 
            this.txbFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txbFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFee.ForeColor = System.Drawing.Color.White;
            this.txbFee.Location = new System.Drawing.Point(124, 117);
            this.txbFee.Name = "txbFee";
            this.txbFee.Size = new System.Drawing.Size(186, 22);
            this.txbFee.TabIndex = 4;
            // 
            // txbRoomCharge
            // 
            this.txbRoomCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txbRoomCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRoomCharge.ForeColor = System.Drawing.Color.White;
            this.txbRoomCharge.Location = new System.Drawing.Point(124, 89);
            this.txbRoomCharge.Name = "txbRoomCharge";
            this.txbRoomCharge.Size = new System.Drawing.Size(186, 22);
            this.txbRoomCharge.TabIndex = 3;
            // 
            // dtbDate
            // 
            this.dtbDate.CalendarForeColor = System.Drawing.Color.White;
            this.dtbDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.dtbDate.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbDate.Location = new System.Drawing.Point(124, 61);
            this.dtbDate.Name = "dtbDate";
            this.dtbDate.Size = new System.Drawing.Size(186, 22);
            this.dtbDate.TabIndex = 2;
            // 
            // txbNameNV
            // 
            this.txbNameNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txbNameNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNameNV.ForeColor = System.Drawing.Color.White;
            this.txbNameNV.Location = new System.Drawing.Point(124, 33);
            this.txbNameNV.Name = "txbNameNV";
            this.txbNameNV.Size = new System.Drawing.Size(186, 22);
            this.txbNameNV.TabIndex = 1;
            // 
            // txbIdB
            // 
            this.txbIdB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txbIdB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIdB.ForeColor = System.Drawing.Color.White;
            this.txbIdB.Location = new System.Drawing.Point(124, 7);
            this.txbIdB.Name = "txbIdB";
            this.txbIdB.Size = new System.Drawing.Size(186, 22);
            this.txbIdB.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dtpTo);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.dtpFrom);
            this.panel2.Location = new System.Drawing.Point(870, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 102);
            this.panel2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ngày lập từ:";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(124, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(186, 36);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(124, 1);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(186, 22);
            this.dtpFrom.TabIndex = 8;
            // 
            // txbPay
            // 
            this.txbPay.Controls.Add(this.btnReload);
            this.txbPay.Location = new System.Drawing.Point(870, 530);
            this.txbPay.Name = "txbPay";
            this.txbPay.Size = new System.Drawing.Size(338, 61);
            this.txbPay.TabIndex = 3;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(124, 29);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(186, 22);
            this.dtpTo.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Đến ngày";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(124, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 22);
            this.textBox1.TabIndex = 16;
            // 
            // txbPayment
            // 
            this.txbPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txbPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPayment.ForeColor = System.Drawing.Color.White;
            this.txbPayment.Location = new System.Drawing.Point(124, 229);
            this.txbPayment.Name = "txbPayment";
            this.txbPayment.Size = new System.Drawing.Size(186, 22);
            this.txbPayment.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Khách trả:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Tiền thối:";
            // 
            // btnReload
            // 
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(125, 22);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(186, 36);
            this.btnReload.TabIndex = 19;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1220, 603);
            this.Controls.Add(this.txbPay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBillInfo);
            this.Controls.Add(this.dtgvBill);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillForm";
            this.Text = "Quản lý hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.pnlBillInfo.ResumeLayout(false);
            this.pnlBillInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.txbPay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Panel pnlBillInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.TextBox txbPhatSinh;
        private System.Windows.Forms.TextBox txbFee;
        private System.Windows.Forms.TextBox txbRoomCharge;
        private System.Windows.Forms.DateTimePicker dtbDate;
        private System.Windows.Forms.TextBox txbNameNV;
        private System.Windows.Forms.TextBox txbIdB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Panel txbPay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbPayment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnReload;
    }
}