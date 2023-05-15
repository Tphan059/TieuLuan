namespace TieuLuan.Admin.childForm
{
    partial class HomeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNameRoomS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbRStatus = new System.Windows.Forms.ComboBox();
            this.cbbRTypeS = new System.Windows.Forms.ComboBox();
            this.cbbFloorS = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlRoomInfo = new System.Windows.Forms.Panel();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.cbbNameRoomType = new System.Windows.Forms.ComboBox();
            this.cbbNameFloor = new System.Windows.Forms.ComboBox();
            this.txtNameRoom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRoomReload = new System.Windows.Forms.Button();
            this.btnRoomAdd = new System.Windows.Forms.Button();
            this.btnRoomEdit = new System.Windows.Forms.Button();
            this.btnRoomCancel = new System.Windows.Forms.Button();
            this.btnRoomSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlRoomInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtNameRoomS);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 92);
            this.panel2.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(100, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(206, 42);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtNameRoomS
            // 
            this.txtNameRoomS.Location = new System.Drawing.Point(100, 8);
            this.txtNameRoomS.Name = "txtNameRoomS";
            this.txtNameRoomS.Size = new System.Drawing.Size(206, 22);
            this.txtNameRoomS.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phòng:";
            // 
            // cbbRStatus
            // 
            this.cbbRStatus.FormattingEnabled = true;
            this.cbbRStatus.Location = new System.Drawing.Point(101, 73);
            this.cbbRStatus.Name = "cbbRStatus";
            this.cbbRStatus.Size = new System.Drawing.Size(206, 24);
            this.cbbRStatus.TabIndex = 10;
            // 
            // cbbRTypeS
            // 
            this.cbbRTypeS.FormattingEnabled = true;
            this.cbbRTypeS.Location = new System.Drawing.Point(101, 43);
            this.cbbRTypeS.Name = "cbbRTypeS";
            this.cbbRTypeS.Size = new System.Drawing.Size(206, 24);
            this.cbbRTypeS.TabIndex = 9;
            // 
            // cbbFloorS
            // 
            this.cbbFloorS.FormattingEnabled = true;
            this.cbbFloorS.Location = new System.Drawing.Point(101, 12);
            this.cbbFloorS.Name = "cbbFloorS";
            this.cbbFloorS.Size = new System.Drawing.Size(206, 24);
            this.cbbFloorS.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tình trạng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tầng: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(846, 578);
            this.dataGridView1.TabIndex = 2;
            // 
            // pnlRoomInfo
            // 
            this.pnlRoomInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRoomInfo.Controls.Add(this.cbbStatus);
            this.pnlRoomInfo.Controls.Add(this.cbbNameRoomType);
            this.pnlRoomInfo.Controls.Add(this.cbbNameFloor);
            this.pnlRoomInfo.Controls.Add(this.txtNameRoom);
            this.pnlRoomInfo.Controls.Add(this.label7);
            this.pnlRoomInfo.Controls.Add(this.label6);
            this.pnlRoomInfo.Controls.Add(this.label5);
            this.pnlRoomInfo.Controls.Add(this.label4);
            this.pnlRoomInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRoomInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlRoomInfo.Name = "pnlRoomInfo";
            this.pnlRoomInfo.Size = new System.Drawing.Size(356, 127);
            this.pnlRoomInfo.TabIndex = 3;
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(99, 94);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(206, 24);
            this.cbbStatus.TabIndex = 7;
            // 
            // cbbNameRoomType
            // 
            this.cbbNameRoomType.FormattingEnabled = true;
            this.cbbNameRoomType.Location = new System.Drawing.Point(100, 64);
            this.cbbNameRoomType.Name = "cbbNameRoomType";
            this.cbbNameRoomType.Size = new System.Drawing.Size(206, 24);
            this.cbbNameRoomType.TabIndex = 6;
            // 
            // cbbNameFloor
            // 
            this.cbbNameFloor.FormattingEnabled = true;
            this.cbbNameFloor.Location = new System.Drawing.Point(100, 30);
            this.cbbNameFloor.Name = "cbbNameFloor";
            this.cbbNameFloor.Size = new System.Drawing.Size(206, 24);
            this.cbbNameFloor.TabIndex = 5;
            // 
            // txtNameRoom
            // 
            this.txtNameRoom.Location = new System.Drawing.Point(100, 4);
            this.txtNameRoom.Name = "txtNameRoom";
            this.txtNameRoom.Size = new System.Drawing.Size(206, 22);
            this.txtNameRoom.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tình trạng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Loại phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tầng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên phòng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRoomReload);
            this.panel1.Controls.Add(this.btnRoomAdd);
            this.panel1.Controls.Add(this.btnRoomEdit);
            this.panel1.Controls.Add(this.btnRoomCancel);
            this.panel1.Controls.Add(this.btnRoomSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 183);
            this.panel1.TabIndex = 4;
            // 
            // btnRoomReload
            // 
            this.btnRoomReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnRoomReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomReload.Location = new System.Drawing.Point(232, 89);
            this.btnRoomReload.Name = "btnRoomReload";
            this.btnRoomReload.Size = new System.Drawing.Size(75, 31);
            this.btnRoomReload.TabIndex = 5;
            this.btnRoomReload.Text = "Reload";
            this.btnRoomReload.UseVisualStyleBackColor = true;
            this.btnRoomReload.Click += new System.EventHandler(this.btnRoomReload_Click);
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnRoomAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomAdd.Location = new System.Drawing.Point(101, 15);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Size = new System.Drawing.Size(75, 31);
            this.btnRoomAdd.TabIndex = 0;
            this.btnRoomAdd.Text = "Thêm";
            this.btnRoomAdd.UseVisualStyleBackColor = true;
            this.btnRoomAdd.Click += new System.EventHandler(this.btnRoomAdd_Click);
            // 
            // btnRoomEdit
            // 
            this.btnRoomEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnRoomEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomEdit.Location = new System.Drawing.Point(101, 89);
            this.btnRoomEdit.Name = "btnRoomEdit";
            this.btnRoomEdit.Size = new System.Drawing.Size(75, 31);
            this.btnRoomEdit.TabIndex = 1;
            this.btnRoomEdit.Text = "Cập nhật";
            this.btnRoomEdit.UseVisualStyleBackColor = true;
            this.btnRoomEdit.Click += new System.EventHandler(this.btnRoomEdit_Click);
            // 
            // btnRoomCancel
            // 
            this.btnRoomCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnRoomCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomCancel.Location = new System.Drawing.Point(232, 52);
            this.btnRoomCancel.Name = "btnRoomCancel";
            this.btnRoomCancel.Size = new System.Drawing.Size(75, 31);
            this.btnRoomCancel.TabIndex = 4;
            this.btnRoomCancel.Text = "Hủy";
            this.btnRoomCancel.UseVisualStyleBackColor = true;
            this.btnRoomCancel.Click += new System.EventHandler(this.btnRoomCancel_Click);
            // 
            // btnRoomSave
            // 
            this.btnRoomSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnRoomSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomSave.Location = new System.Drawing.Point(232, 15);
            this.btnRoomSave.Name = "btnRoomSave";
            this.btnRoomSave.Size = new System.Drawing.Size(75, 31);
            this.btnRoomSave.TabIndex = 3;
            this.btnRoomSave.Text = "Lưu";
            this.btnRoomSave.UseVisualStyleBackColor = true;
            this.btnRoomSave.Click += new System.EventHandler(this.btnRoomSave_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.pnlRoomInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(864, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 603);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnFilter);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cbbRStatus);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cbbRTypeS);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.cbbFloorS);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 219);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 201);
            this.panel4.TabIndex = 5;
            // 
            // btnFilter
            // 
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(101, 103);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(206, 42);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1220, 603);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "Quản lý phòng";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlRoomInfo.ResumeLayout(false);
            this.pnlRoomInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlRoomInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbRStatus;
        private System.Windows.Forms.ComboBox cbbRTypeS;
        private System.Windows.Forms.ComboBox cbbFloorS;
        private System.Windows.Forms.TextBox txtNameRoomS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbNameRoomType;
        private System.Windows.Forms.ComboBox cbbNameFloor;
        private System.Windows.Forms.TextBox txtNameRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRoomReload;
        private System.Windows.Forms.Button btnRoomCancel;
        private System.Windows.Forms.Button btnRoomSave;
        private System.Windows.Forms.Button btnRoomEdit;
        private System.Windows.Forms.Button btnRoomAdd;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFilter;
    }
}