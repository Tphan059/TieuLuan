namespace TieuLuan.Admin.childForm
{
    partial class ServiceForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlServiceInfo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtPriceServ = new System.Windows.Forms.TextBox();
            this.cbbServiceType = new System.Windows.Forms.ComboBox();
            this.txtNameServ = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnServiceSearch = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtNameServS = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnServReload = new System.Windows.Forms.Button();
            this.btnServCancel = new System.Windows.Forms.Button();
            this.btnServSave = new System.Windows.Forms.Button();
            this.btnServEdit = new System.Windows.Forms.Button();
            this.btnServAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlServiceInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(535, 578);
            this.dataGridView1.TabIndex = 0;
            // 
            // pnlServiceInfo
            // 
            this.pnlServiceInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlServiceInfo.Controls.Add(this.label4);
            this.pnlServiceInfo.Controls.Add(this.label3);
            this.pnlServiceInfo.Controls.Add(this.label2);
            this.pnlServiceInfo.Controls.Add(this.label1);
            this.pnlServiceInfo.Controls.Add(this.txtUnitPrice);
            this.pnlServiceInfo.Controls.Add(this.txtPriceServ);
            this.pnlServiceInfo.Controls.Add(this.cbbServiceType);
            this.pnlServiceInfo.Controls.Add(this.txtNameServ);
            this.pnlServiceInfo.Location = new System.Drawing.Point(554, 13);
            this.pnlServiceInfo.Name = "pnlServiceInfo";
            this.pnlServiceInfo.Size = new System.Drawing.Size(339, 121);
            this.pnlServiceInfo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn vị:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại dịch vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên dịch vụ:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitPrice.ForeColor = System.Drawing.Color.White;
            this.txtUnitPrice.Location = new System.Drawing.Point(130, 88);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(191, 22);
            this.txtUnitPrice.TabIndex = 3;
            this.txtUnitPrice.Text = "Cái";
            // 
            // txtPriceServ
            // 
            this.txtPriceServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtPriceServ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriceServ.ForeColor = System.Drawing.Color.White;
            this.txtPriceServ.Location = new System.Drawing.Point(130, 60);
            this.txtPriceServ.Name = "txtPriceServ";
            this.txtPriceServ.Size = new System.Drawing.Size(191, 22);
            this.txtPriceServ.TabIndex = 2;
            // 
            // cbbServiceType
            // 
            this.cbbServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cbbServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbServiceType.ForeColor = System.Drawing.Color.White;
            this.cbbServiceType.FormattingEnabled = true;
            this.cbbServiceType.Location = new System.Drawing.Point(130, 33);
            this.cbbServiceType.Name = "cbbServiceType";
            this.cbbServiceType.Size = new System.Drawing.Size(191, 24);
            this.cbbServiceType.TabIndex = 1;
            // 
            // txtNameServ
            // 
            this.txtNameServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtNameServ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameServ.ForeColor = System.Drawing.Color.White;
            this.txtNameServ.Location = new System.Drawing.Point(130, 4);
            this.txtNameServ.Name = "txtNameServ";
            this.txtNameServ.Size = new System.Drawing.Size(191, 22);
            this.txtNameServ.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnServiceSearch);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.txtNameServS);
            this.panel2.Location = new System.Drawing.Point(554, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 147);
            this.panel2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Loại dịch vụ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên dịch vụ:";
            // 
            // btnServiceSearch
            // 
            this.btnServiceSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnServiceSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceSearch.Location = new System.Drawing.Point(130, 79);
            this.btnServiceSearch.Name = "btnServiceSearch";
            this.btnServiceSearch.Size = new System.Drawing.Size(189, 39);
            this.btnServiceSearch.TabIndex = 0;
            this.btnServiceSearch.Text = "Tìm kiếm";
            this.btnServiceSearch.UseVisualStyleBackColor = true;
            this.btnServiceSearch.Click += new System.EventHandler(this.btnServiceSearch_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(130, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(191, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // txtNameServS
            // 
            this.txtNameServS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtNameServS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameServS.ForeColor = System.Drawing.Color.White;
            this.txtNameServS.Location = new System.Drawing.Point(130, 3);
            this.txtNameServS.Name = "txtNameServS";
            this.txtNameServS.Size = new System.Drawing.Size(191, 22);
            this.txtNameServS.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnServReload);
            this.panel3.Controls.Add(this.btnServCancel);
            this.panel3.Controls.Add(this.btnServSave);
            this.panel3.Controls.Add(this.btnServEdit);
            this.panel3.Controls.Add(this.btnServAdd);
            this.panel3.Location = new System.Drawing.Point(554, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 119);
            this.panel3.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(132, 51);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnServReload
            // 
            this.btnServReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnServReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServReload.Location = new System.Drawing.Point(246, 86);
            this.btnServReload.Name = "btnServReload";
            this.btnServReload.Size = new System.Drawing.Size(75, 28);
            this.btnServReload.TabIndex = 10;
            this.btnServReload.Text = "Reload";
            this.btnServReload.UseVisualStyleBackColor = true;
            this.btnServReload.Click += new System.EventHandler(this.btnServReload_Click);
            // 
            // btnServCancel
            // 
            this.btnServCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnServCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServCancel.Location = new System.Drawing.Point(246, 49);
            this.btnServCancel.Name = "btnServCancel";
            this.btnServCancel.Size = new System.Drawing.Size(75, 31);
            this.btnServCancel.TabIndex = 9;
            this.btnServCancel.Text = "Hủy";
            this.btnServCancel.UseVisualStyleBackColor = true;
            this.btnServCancel.Click += new System.EventHandler(this.btnServCancel_Click);
            // 
            // btnServSave
            // 
            this.btnServSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnServSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServSave.Location = new System.Drawing.Point(246, 16);
            this.btnServSave.Name = "btnServSave";
            this.btnServSave.Size = new System.Drawing.Size(75, 27);
            this.btnServSave.TabIndex = 8;
            this.btnServSave.Text = "Lưu";
            this.btnServSave.UseVisualStyleBackColor = true;
            this.btnServSave.Click += new System.EventHandler(this.btnServSave_Click);
            // 
            // btnServEdit
            // 
            this.btnServEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnServEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServEdit.Location = new System.Drawing.Point(132, 86);
            this.btnServEdit.Name = "btnServEdit";
            this.btnServEdit.Size = new System.Drawing.Size(75, 28);
            this.btnServEdit.TabIndex = 6;
            this.btnServEdit.Text = "Sửa";
            this.btnServEdit.UseVisualStyleBackColor = true;
            this.btnServEdit.Click += new System.EventHandler(this.btnServEdit_Click);
            // 
            // btnServAdd
            // 
            this.btnServAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnServAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServAdd.ForeColor = System.Drawing.Color.White;
            this.btnServAdd.Location = new System.Drawing.Point(132, 16);
            this.btnServAdd.Name = "btnServAdd";
            this.btnServAdd.Size = new System.Drawing.Size(75, 27);
            this.btnServAdd.TabIndex = 5;
            this.btnServAdd.Text = "Thêm";
            this.btnServAdd.UseVisualStyleBackColor = true;
            this.btnServAdd.Click += new System.EventHandler(this.btnServAdd_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(911, 603);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlServiceInfo);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlServiceInfo.ResumeLayout(false);
            this.pnlServiceInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlServiceInfo;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtPriceServ;
        private System.Windows.Forms.ComboBox cbbServiceType;
        private System.Windows.Forms.TextBox txtNameServ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnServiceSearch;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtNameServS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnServReload;
        private System.Windows.Forms.Button btnServCancel;
        private System.Windows.Forms.Button btnServSave;
        private System.Windows.Forms.Button btnServEdit;
        private System.Windows.Forms.Button btnServAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}