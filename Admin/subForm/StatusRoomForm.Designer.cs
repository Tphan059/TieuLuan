namespace TieuLuan.Admin.subForm
{
    partial class StatusRoomForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChangeStauts = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblNameCus = new System.Windows.Forms.Label();
            this.lblIdBooking = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvSeriveForm = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlService = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnUserServ = new System.Windows.Forms.Button();
            this.nmServiceCount = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbService = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbST = new System.Windows.Forms.ComboBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlService.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmServiceCount)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.11765F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1127, 43);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button1.Image = global::TieuLuan.Properties.Resources._24px_VisualEditor___Icon___Close___white_svg;
            this.button1.Location = new System.Drawing.Point(1063, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 37);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 37);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.lblHinhThuc);
            this.panel2.Controls.Add(this.lblCheckIn);
            this.panel2.Controls.Add(this.lblNameCus);
            this.panel2.Controls.Add(this.lblIdBooking);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 517);
            this.panel2.TabIndex = 1;
            // 
            // btnPay
            // 
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Location = new System.Drawing.Point(10, 78);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(259, 51);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Controls.Add(this.btnChangeStauts);
            this.panel3.Location = new System.Drawing.Point(0, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 134);
            this.panel3.TabIndex = 12;
            // 
            // btnChangeStauts
            // 
            this.btnChangeStauts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnChangeStauts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeStauts.Location = new System.Drawing.Point(10, 13);
            this.btnChangeStauts.Name = "btnChangeStauts";
            this.btnChangeStauts.Size = new System.Drawing.Size(259, 46);
            this.btnChangeStauts.TabIndex = 0;
            this.btnChangeStauts.Text = "button2";
            this.btnChangeStauts.UseVisualStyleBackColor = true;
            this.btnChangeStauts.Click += new System.EventHandler(this.btnChangeStauts_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(110, 126);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 18);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "label8";
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhThuc.Location = new System.Drawing.Point(110, 95);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(52, 18);
            this.lblHinhThuc.TabIndex = 9;
            this.lblHinhThuc.Text = "label8";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(110, 67);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(52, 18);
            this.lblCheckIn.TabIndex = 8;
            this.lblCheckIn.Text = "label8";
            // 
            // lblNameCus
            // 
            this.lblNameCus.AutoSize = true;
            this.lblNameCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCus.Location = new System.Drawing.Point(110, 39);
            this.lblNameCus.Name = "lblNameCus";
            this.lblNameCus.Size = new System.Drawing.Size(52, 18);
            this.lblNameCus.TabIndex = 7;
            this.lblNameCus.Text = "label8";
            // 
            // lblIdBooking
            // 
            this.lblIdBooking.AutoSize = true;
            this.lblIdBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdBooking.Location = new System.Drawing.Point(110, 11);
            this.lblIdBooking.Name = "lblIdBooking";
            this.lblIdBooking.Size = new System.Drawing.Size(52, 18);
            this.lblIdBooking.TabIndex = 6;
            this.lblIdBooking.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Thời lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hình thức:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày nhận:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đặt phòng:";
            // 
            // lsvSeriveForm
            // 
            this.lsvSeriveForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.lsvSeriveForm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvSeriveForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvSeriveForm.ForeColor = System.Drawing.Color.White;
            this.lsvSeriveForm.GridLines = true;
            this.lsvSeriveForm.HideSelection = false;
            this.lsvSeriveForm.Location = new System.Drawing.Point(0, 0);
            this.lsvSeriveForm.Name = "lsvSeriveForm";
            this.lsvSeriveForm.Size = new System.Drawing.Size(481, 515);
            this.lsvSeriveForm.TabIndex = 3;
            this.lsvSeriveForm.UseCompatibleStateImageBehavior = false;
            this.lsvSeriveForm.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên dịch vụ";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 76;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lsvSeriveForm);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(644, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(483, 517);
            this.panel4.TabIndex = 4;
            // 
            // pnlService
            // 
            this.pnlService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlService.Controls.Add(this.txtTotalPrice);
            this.pnlService.Controls.Add(this.panel8);
            this.pnlService.Controls.Add(this.panel7);
            this.pnlService.Controls.Add(this.panel6);
            this.pnlService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlService.Location = new System.Drawing.Point(277, 43);
            this.pnlService.Name = "pnlService";
            this.pnlService.Size = new System.Drawing.Size(367, 517);
            this.pnlService.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnUserServ);
            this.panel8.Controls.Add(this.nmServiceCount);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Location = new System.Drawing.Point(3, 81);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(357, 63);
            this.panel8.TabIndex = 8;
            // 
            // btnUserServ
            // 
            this.btnUserServ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnUserServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserServ.Location = new System.Drawing.Point(207, 0);
            this.btnUserServ.Name = "btnUserServ";
            this.btnUserServ.Size = new System.Drawing.Size(139, 60);
            this.btnUserServ.TabIndex = 9;
            this.btnUserServ.Text = "Đặt";
            this.btnUserServ.UseVisualStyleBackColor = true;
            this.btnUserServ.Click += new System.EventHandler(this.btnUserServ_Click);
            // 
            // nmServiceCount
            // 
            this.nmServiceCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.nmServiceCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmServiceCount.ForeColor = System.Drawing.Color.White;
            this.nmServiceCount.Location = new System.Drawing.Point(109, 23);
            this.nmServiceCount.Name = "nmServiceCount";
            this.nmServiceCount.Size = new System.Drawing.Size(63, 18);
            this.nmServiceCount.TabIndex = 8;
            this.nmServiceCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 16);
            this.label15.TabIndex = 7;
            this.label15.Text = "Số lượng: ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.cbbService);
            this.panel7.Location = new System.Drawing.Point(3, 43);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(357, 32);
            this.panel7.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Dịch vụ:";
            // 
            // cbbService
            // 
            this.cbbService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cbbService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbService.ForeColor = System.Drawing.Color.White;
            this.cbbService.FormattingEnabled = true;
            this.cbbService.Location = new System.Drawing.Point(111, 5);
            this.cbbService.Name = "cbbService";
            this.cbbService.Size = new System.Drawing.Size(237, 24);
            this.cbbService.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.cbbST);
            this.panel6.Location = new System.Drawing.Point(3, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(354, 32);
            this.panel6.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "Loại dịch vụ:";
            // 
            // cbbST
            // 
            this.cbbST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cbbST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbST.ForeColor = System.Drawing.Color.White;
            this.cbbST.FormattingEnabled = true;
            this.cbbST.Location = new System.Drawing.Point(111, 3);
            this.cbbST.Name = "cbbST";
            this.cbbST.Size = new System.Drawing.Size(237, 24);
            this.cbbST.TabIndex = 5;
            this.cbbST.SelectedIndexChanged += new System.EventHandler(this.cbbST_SelectedIndexChanged);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPrice.ForeColor = System.Drawing.Color.White;
            this.txtTotalPrice.Location = new System.Drawing.Point(210, 150);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.ShortcutsEnabled = false;
            this.txtTotalPrice.Size = new System.Drawing.Size(149, 22);
            this.txtTotalPrice.TabIndex = 13;
            // 
            // StatusRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1127, 560);
            this.Controls.Add(this.pnlService);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatusRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatusRoomForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlService.ResumeLayout(false);
            this.pnlService.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmServiceCount)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdBooking;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnChangeStauts;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblNameCus;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ListView lsvSeriveForm;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlService;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbbST;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnUserServ;
        private System.Windows.Forms.NumericUpDown nmServiceCount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbService;
        private System.Windows.Forms.TextBox txtTotalPrice;
    }
}