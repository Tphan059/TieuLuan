namespace TieuLuan.Admin.childForm
{
    partial class StaffControlForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStaffReload = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnStaffCancel = new System.Windows.Forms.Button();
            this.btnStaffSave = new System.Windows.Forms.Button();
            this.btnStaffAdd = new System.Windows.Forms.Button();
            this.btnStaffEdit = new System.Windows.Forms.Button();
            this.btnStaffSearch = new System.Windows.Forms.Button();
            this.pnlStaffInfo = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbPer = new System.Windows.Forms.ComboBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.cbxSexNV = new System.Windows.Forms.CheckBox();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailNV = new System.Windows.Forms.TextBox();
            this.txtPhoneNV = new System.Windows.Forms.TextBox();
            this.txtAddressNV = new System.Windows.Forms.TextBox();
            this.txtNameNV = new System.Windows.Forms.TextBox();
            this.pnlStaffSearch = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhoneNVSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlStaffInfo.SuspendLayout();
            this.pnlStaffSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dtgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvStaff.ColumnHeadersHeight = 30;
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvStaff.EnableHeadersVisualStyles = false;
            this.dtgvStaff.Location = new System.Drawing.Point(13, 13);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.ReadOnly = true;
            this.dtgvStaff.RowHeadersVisible = false;
            this.dtgvStaff.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.dtgvStaff.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvStaff.RowTemplate.Height = 24;
            this.dtgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvStaff.Size = new System.Drawing.Size(762, 573);
            this.dtgvStaff.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStaffReload);
            this.panel1.Controls.Add(this.btnChangePass);
            this.panel1.Controls.Add(this.btnStaffCancel);
            this.panel1.Controls.Add(this.btnStaffSave);
            this.panel1.Controls.Add(this.btnStaffAdd);
            this.panel1.Controls.Add(this.btnStaffEdit);
            this.panel1.Location = new System.Drawing.Point(781, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 88);
            this.panel1.TabIndex = 1;
            // 
            // btnStaffReload
            // 
            this.btnStaffReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnStaffReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffReload.Location = new System.Drawing.Point(284, 43);
            this.btnStaffReload.Name = "btnStaffReload";
            this.btnStaffReload.Size = new System.Drawing.Size(132, 33);
            this.btnStaffReload.TabIndex = 16;
            this.btnStaffReload.Text = "Reload";
            this.btnStaffReload.UseVisualStyleBackColor = true;
            this.btnStaffReload.Click += new System.EventHandler(this.btnStaffReload_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Location = new System.Drawing.Point(284, 3);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(132, 34);
            this.btnChangePass.TabIndex = 13;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnStaffCancel
            // 
            this.btnStaffCancel.Enabled = false;
            this.btnStaffCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnStaffCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffCancel.ForeColor = System.Drawing.Color.White;
            this.btnStaffCancel.Location = new System.Drawing.Point(146, 43);
            this.btnStaffCancel.Name = "btnStaffCancel";
            this.btnStaffCancel.Size = new System.Drawing.Size(132, 33);
            this.btnStaffCancel.TabIndex = 15;
            this.btnStaffCancel.Text = "Hủy";
            this.btnStaffCancel.UseVisualStyleBackColor = true;
            this.btnStaffCancel.Click += new System.EventHandler(this.btnStaffCancel_Click);
            // 
            // btnStaffSave
            // 
            this.btnStaffSave.Enabled = false;
            this.btnStaffSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnStaffSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffSave.Location = new System.Drawing.Point(8, 43);
            this.btnStaffSave.Name = "btnStaffSave";
            this.btnStaffSave.Size = new System.Drawing.Size(132, 33);
            this.btnStaffSave.TabIndex = 14;
            this.btnStaffSave.Text = "Lưu";
            this.btnStaffSave.UseVisualStyleBackColor = true;
            this.btnStaffSave.Click += new System.EventHandler(this.btnStaffSave_Click);
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnStaffAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffAdd.Location = new System.Drawing.Point(8, 3);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.Size = new System.Drawing.Size(132, 34);
            this.btnStaffAdd.TabIndex = 11;
            this.btnStaffAdd.Text = "Thêm";
            this.btnStaffAdd.UseVisualStyleBackColor = true;
            this.btnStaffAdd.Click += new System.EventHandler(this.btnStaffAdd_Click);
            // 
            // btnStaffEdit
            // 
            this.btnStaffEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnStaffEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffEdit.Location = new System.Drawing.Point(146, 3);
            this.btnStaffEdit.Name = "btnStaffEdit";
            this.btnStaffEdit.Size = new System.Drawing.Size(132, 34);
            this.btnStaffEdit.TabIndex = 12;
            this.btnStaffEdit.Text = "Sửa";
            this.btnStaffEdit.UseVisualStyleBackColor = true;
            this.btnStaffEdit.Click += new System.EventHandler(this.btnStaffEdit_Click);
            // 
            // btnStaffSearch
            // 
            this.btnStaffSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnStaffSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffSearch.Location = new System.Drawing.Point(340, 7);
            this.btnStaffSearch.Name = "btnStaffSearch";
            this.btnStaffSearch.Size = new System.Drawing.Size(75, 46);
            this.btnStaffSearch.TabIndex = 10;
            this.btnStaffSearch.Text = "Tìm kiếm";
            this.btnStaffSearch.UseVisualStyleBackColor = true;
            this.btnStaffSearch.Click += new System.EventHandler(this.btnStaffSearch_Click);
            // 
            // pnlStaffInfo
            // 
            this.pnlStaffInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStaffInfo.Controls.Add(this.label11);
            this.pnlStaffInfo.Controls.Add(this.label8);
            this.pnlStaffInfo.Controls.Add(this.cbbPer);
            this.pnlStaffInfo.Controls.Add(this.txtAccount);
            this.pnlStaffInfo.Controls.Add(this.cbxSexNV);
            this.pnlStaffInfo.Controls.Add(this.dtpDoB);
            this.pnlStaffInfo.Controls.Add(this.label6);
            this.pnlStaffInfo.Controls.Add(this.label5);
            this.pnlStaffInfo.Controls.Add(this.label4);
            this.pnlStaffInfo.Controls.Add(this.label3);
            this.pnlStaffInfo.Controls.Add(this.label2);
            this.pnlStaffInfo.Controls.Add(this.label1);
            this.pnlStaffInfo.Controls.Add(this.txtEmailNV);
            this.pnlStaffInfo.Controls.Add(this.txtPhoneNV);
            this.pnlStaffInfo.Controls.Add(this.txtAddressNV);
            this.pnlStaffInfo.Controls.Add(this.txtNameNV);
            this.pnlStaffInfo.Location = new System.Drawing.Point(781, 12);
            this.pnlStaffInfo.Name = "pnlStaffInfo";
            this.pnlStaffInfo.Size = new System.Drawing.Size(427, 238);
            this.pnlStaffInfo.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Quyền hạn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tài khoản:";
            // 
            // cbbPer
            // 
            this.cbbPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cbbPer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbPer.ForeColor = System.Drawing.Color.White;
            this.cbbPer.FormattingEnabled = true;
            this.cbbPer.Location = new System.Drawing.Point(134, 200);
            this.cbbPer.Name = "cbbPer";
            this.cbbPer.Size = new System.Drawing.Size(121, 24);
            this.cbbPer.TabIndex = 7;
            // 
            // txtAccount
            // 
            this.txtAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccount.Enabled = false;
            this.txtAccount.ForeColor = System.Drawing.Color.White;
            this.txtAccount.Location = new System.Drawing.Point(134, 172);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(281, 22);
            this.txtAccount.TabIndex = 6;
            // 
            // cbxSexNV
            // 
            this.cbxSexNV.AutoSize = true;
            this.cbxSexNV.Location = new System.Drawing.Point(134, 61);
            this.cbxSexNV.Name = "cbxSexNV";
            this.cbxSexNV.Size = new System.Drawing.Size(46, 20);
            this.cbxSexNV.TabIndex = 2;
            this.cbxSexNV.Text = "Nữ";
            this.cbxSexNV.UseVisualStyleBackColor = true;
            // 
            // dtpDoB
            // 
            this.dtpDoB.CalendarForeColor = System.Drawing.Color.White;
            this.dtpDoB.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.dtpDoB.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpDoB.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dtpDoB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDoB.Location = new System.Drawing.Point(134, 32);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(119, 22);
            this.dtpDoB.TabIndex = 1;
            this.dtpDoB.Value = new System.DateTime(2023, 5, 3, 20, 50, 49, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số điện thoại: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ngày sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên nhân viên:";
            // 
            // txtEmailNV
            // 
            this.txtEmailNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtEmailNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailNV.ForeColor = System.Drawing.Color.White;
            this.txtEmailNV.Location = new System.Drawing.Point(134, 144);
            this.txtEmailNV.Name = "txtEmailNV";
            this.txtEmailNV.Size = new System.Drawing.Size(281, 22);
            this.txtEmailNV.TabIndex = 5;
            // 
            // txtPhoneNV
            // 
            this.txtPhoneNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtPhoneNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNV.ForeColor = System.Drawing.Color.White;
            this.txtPhoneNV.Location = new System.Drawing.Point(134, 116);
            this.txtPhoneNV.Name = "txtPhoneNV";
            this.txtPhoneNV.Size = new System.Drawing.Size(281, 22);
            this.txtPhoneNV.TabIndex = 4;
            // 
            // txtAddressNV
            // 
            this.txtAddressNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtAddressNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddressNV.ForeColor = System.Drawing.Color.White;
            this.txtAddressNV.Location = new System.Drawing.Point(134, 88);
            this.txtAddressNV.Name = "txtAddressNV";
            this.txtAddressNV.Size = new System.Drawing.Size(281, 22);
            this.txtAddressNV.TabIndex = 3;
            // 
            // txtNameNV
            // 
            this.txtNameNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtNameNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameNV.ForeColor = System.Drawing.Color.White;
            this.txtNameNV.Location = new System.Drawing.Point(134, 4);
            this.txtNameNV.Name = "txtNameNV";
            this.txtNameNV.Size = new System.Drawing.Size(281, 22);
            this.txtNameNV.TabIndex = 0;
            // 
            // pnlStaffSearch
            // 
            this.pnlStaffSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStaffSearch.Controls.Add(this.label10);
            this.pnlStaffSearch.Controls.Add(this.txtPhoneNVSearch);
            this.pnlStaffSearch.Controls.Add(this.btnStaffSearch);
            this.pnlStaffSearch.Location = new System.Drawing.Point(781, 256);
            this.pnlStaffSearch.Name = "pnlStaffSearch";
            this.pnlStaffSearch.Size = new System.Drawing.Size(427, 64);
            this.pnlStaffSearch.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Số điện thoại:";
            // 
            // txtPhoneNVSearch
            // 
            this.txtPhoneNVSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtPhoneNVSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNVSearch.ForeColor = System.Drawing.Color.White;
            this.txtPhoneNVSearch.Location = new System.Drawing.Point(131, 20);
            this.txtPhoneNVSearch.Name = "txtPhoneNVSearch";
            this.txtPhoneNVSearch.Size = new System.Drawing.Size(203, 22);
            this.txtPhoneNVSearch.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1024, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 42);
            this.button1.TabIndex = 17;
            this.button1.Text = "Xóa nhân viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaffControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1220, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlStaffSearch);
            this.Controls.Add(this.pnlStaffInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvStaff);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffControlForm";
            this.Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlStaffInfo.ResumeLayout(false);
            this.pnlStaffInfo.PerformLayout();
            this.pnlStaffSearch.ResumeLayout(false);
            this.pnlStaffSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStaffReload;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnStaffCancel;
        private System.Windows.Forms.Button btnStaffSave;
        private System.Windows.Forms.Button btnStaffAdd;
        private System.Windows.Forms.Button btnStaffEdit;
        private System.Windows.Forms.Button btnStaffSearch;
        private System.Windows.Forms.Panel pnlStaffInfo;
        private System.Windows.Forms.TextBox txtEmailNV;
        private System.Windows.Forms.TextBox txtPhoneNV;
        private System.Windows.Forms.TextBox txtAddressNV;
        private System.Windows.Forms.TextBox txtNameNV;
        private System.Windows.Forms.Panel pnlStaffSearch;
        private System.Windows.Forms.TextBox txtPhoneNVSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.CheckBox cbxSexNV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbPer;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Button button1;
    }
}