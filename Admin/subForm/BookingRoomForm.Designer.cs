namespace TieuLuan.Admin.subForm
{
    partial class BookingRoomForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDatTruoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCusInfo = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbHinhThuc = new System.Windows.Forms.ComboBox();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.txtNameCus = new System.Windows.Forms.TextBox();
            this.nudPer = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPer)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 44);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐẶT PHÒNG";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TieuLuan.Properties.Resources._24px_VisualEditor___Icon___Close___white_svg;
            this.btnClose.Location = new System.Drawing.Point(407, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 36);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.nudPer);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtDatTruoc);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnAddCusInfo);
            this.panel3.Controls.Add(this.btnBooking);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbbHinhThuc);
            this.panel3.Controls.Add(this.txtCusPhone);
            this.panel3.Controls.Add(this.txtNameCus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 485);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(452, 42);
            this.panel4.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Trả trước:";
            // 
            // txtDatTruoc
            // 
            this.txtDatTruoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtDatTruoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatTruoc.ForeColor = System.Drawing.Color.White;
            this.txtDatTruoc.Location = new System.Drawing.Point(198, 202);
            this.txtDatTruoc.Name = "txtDatTruoc";
            this.txtDatTruoc.Size = new System.Drawing.Size(177, 22);
            this.txtDatTruoc.TabIndex = 3;
            this.txtDatTruoc.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hình thức:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số người";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số điện thoại:";
            // 
            // btnAddCusInfo
            // 
            this.btnAddCusInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCusInfo.Location = new System.Drawing.Point(386, 145);
            this.btnAddCusInfo.Name = "btnAddCusInfo";
            this.btnAddCusInfo.Size = new System.Drawing.Size(55, 23);
            this.btnAddCusInfo.TabIndex = 6;
            this.btnAddCusInfo.Text = "Tìm";
            this.btnAddCusInfo.UseVisualStyleBackColor = true;
            this.btnAddCusInfo.Click += new System.EventHandler(this.btnAddCusInfo_Click);
            this.btnAddCusInfo.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.btnAddCusInfo.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // btnBooking
            // 
            this.btnBooking.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(137, 330);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(177, 39);
            this.btnBooking.TabIndex = 5;
            this.btnBooking.Text = "Đặt Phòng";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            this.btnBooking.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.btnBooking.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khách hàng:";
            // 
            // cbbHinhThuc
            // 
            this.cbbHinhThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cbbHinhThuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbHinhThuc.ForeColor = System.Drawing.Color.White;
            this.cbbHinhThuc.FormattingEnabled = true;
            this.cbbHinhThuc.Location = new System.Drawing.Point(198, 229);
            this.cbbHinhThuc.Name = "cbbHinhThuc";
            this.cbbHinhThuc.Size = new System.Drawing.Size(177, 24);
            this.cbbHinhThuc.TabIndex = 4;
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtCusPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCusPhone.ForeColor = System.Drawing.Color.White;
            this.txtCusPhone.Location = new System.Drawing.Point(198, 146);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(177, 22);
            this.txtCusPhone.TabIndex = 1;
            this.txtCusPhone.Text = "Guest";
            // 
            // txtNameCus
            // 
            this.txtNameCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtNameCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameCus.ForeColor = System.Drawing.Color.White;
            this.txtNameCus.Location = new System.Drawing.Point(198, 118);
            this.txtNameCus.Name = "txtNameCus";
            this.txtNameCus.Size = new System.Drawing.Size(177, 22);
            this.txtNameCus.TabIndex = 0;
            this.txtNameCus.Text = "Guest";
            // 
            // nudPer
            // 
            this.nudPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.nudPer.ForeColor = System.Drawing.Color.White;
            this.nudPer.Location = new System.Drawing.Point(198, 174);
            this.nudPer.Name = "nudPer";
            this.nudPer.Size = new System.Drawing.Size(177, 22);
            this.nudPer.TabIndex = 17;
            this.nudPer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BookingRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(454, 565);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookingRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingRoomForm";
            this.Load += new System.EventHandler(this.BookingRoomForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddCusInfo;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbHinhThuc;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.TextBox txtNameCus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDatTruoc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nudPer;
    }
}