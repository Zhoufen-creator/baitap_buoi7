namespace WF_DiemCong
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbTTNV = new System.Windows.Forms.GroupBox();
            this.gbTTXN = new System.Windows.Forms.GroupBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblSLXN = new System.Windows.Forms.Label();
            this.lblKetQuan = new System.Windows.Forms.Label();
            this.radAmTinh = new System.Windows.Forms.RadioButton();
            this.radDuongTinh = new System.Windows.Forms.RadioButton();
            this.lblCongTy = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtSLXN = new System.Windows.Forms.TextBox();
            this.cmbCongTy = new System.Windows.Forms.ComboBox();
            this.btTim = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.lblTTXN = new System.Windows.Forms.Label();
            this.danhSáchNVDươngTínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.gbTTNV.SuspendLayout();
            this.gbTTXN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchNVDươngTínhToolStripMenuItem,
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem,
            this.toolStripSeparator1,
            this.xuấtBáoCáoToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // gbTTNV
            // 
            this.gbTTNV.Controls.Add(this.btTim);
            this.gbTTNV.Controls.Add(this.txtCCCD);
            this.gbTTNV.Controls.Add(this.lblCCCD);
            this.gbTTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbTTNV.Location = new System.Drawing.Point(13, 100);
            this.gbTTNV.Name = "gbTTNV";
            this.gbTTNV.Size = new System.Drawing.Size(357, 70);
            this.gbTTNV.TabIndex = 1;
            this.gbTTNV.TabStop = false;
            this.gbTTNV.Text = "Thông tin nhân viên";
            // 
            // gbTTXN
            // 
            this.gbTTXN.Controls.Add(this.btCapNhat);
            this.gbTTXN.Controls.Add(this.cmbCongTy);
            this.gbTTXN.Controls.Add(this.txtSLXN);
            this.gbTTXN.Controls.Add(this.txtHoTen);
            this.gbTTXN.Controls.Add(this.lblCongTy);
            this.gbTTXN.Controls.Add(this.radDuongTinh);
            this.gbTTXN.Controls.Add(this.radAmTinh);
            this.gbTTXN.Controls.Add(this.lblKetQuan);
            this.gbTTXN.Controls.Add(this.lblSLXN);
            this.gbTTXN.Controls.Add(this.lblHoTen);
            this.gbTTXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbTTXN.Location = new System.Drawing.Point(13, 176);
            this.gbTTXN.Name = "gbTTXN";
            this.gbTTXN.Size = new System.Drawing.Size(357, 287);
            this.gbTTXN.TabIndex = 2;
            this.gbTTXN.TabStop = false;
            this.gbTTXN.Text = "Thông tin xét nghiệm";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(6, 35);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(114, 20);
            this.lblCCCD.TabIndex = 0;
            this.lblCCCD.Text = "CCCD/CMND";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(7, 39);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(64, 20);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblSLXN
            // 
            this.lblSLXN.AutoSize = true;
            this.lblSLXN.Location = new System.Drawing.Point(7, 78);
            this.lblSLXN.Name = "lblSLXN";
            this.lblSLXN.Size = new System.Drawing.Size(53, 20);
            this.lblSLXN.TabIndex = 2;
            this.lblSLXN.Text = "SLXN";
            // 
            // lblKetQuan
            // 
            this.lblKetQuan.AutoSize = true;
            this.lblKetQuan.Location = new System.Drawing.Point(7, 115);
            this.lblKetQuan.Name = "lblKetQuan";
            this.lblKetQuan.Size = new System.Drawing.Size(33, 20);
            this.lblKetQuan.TabIndex = 3;
            this.lblKetQuan.Text = "KQ";
            // 
            // radAmTinh
            // 
            this.radAmTinh.AutoSize = true;
            this.radAmTinh.Checked = true;
            this.radAmTinh.Location = new System.Drawing.Point(68, 115);
            this.radAmTinh.Name = "radAmTinh";
            this.radAmTinh.Size = new System.Drawing.Size(92, 24);
            this.radAmTinh.TabIndex = 4;
            this.radAmTinh.TabStop = true;
            this.radAmTinh.Text = "Âm Tính";
            this.radAmTinh.UseVisualStyleBackColor = true;
            // 
            // radDuongTinh
            // 
            this.radDuongTinh.AutoSize = true;
            this.radDuongTinh.Location = new System.Drawing.Point(68, 163);
            this.radDuongTinh.Name = "radDuongTinh";
            this.radDuongTinh.Size = new System.Drawing.Size(116, 24);
            this.radDuongTinh.TabIndex = 5;
            this.radDuongTinh.TabStop = true;
            this.radDuongTinh.Text = "Dương Tính";
            this.radDuongTinh.UseVisualStyleBackColor = true;
            // 
            // lblCongTy
            // 
            this.lblCongTy.AutoSize = true;
            this.lblCongTy.Location = new System.Drawing.Point(7, 212);
            this.lblCongTy.Name = "lblCongTy";
            this.lblCongTy.Size = new System.Drawing.Size(71, 20);
            this.lblCongTy.TabIndex = 6;
            this.lblCongTy.Text = "Công Ty";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(85, 39);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(266, 27);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(126, 32);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(144, 27);
            this.txtCCCD.TabIndex = 1;
            // 
            // txtSLXN
            // 
            this.txtSLXN.Location = new System.Drawing.Point(85, 71);
            this.txtSLXN.Name = "txtSLXN";
            this.txtSLXN.ReadOnly = true;
            this.txtSLXN.Size = new System.Drawing.Size(70, 27);
            this.txtSLXN.TabIndex = 2;
            // 
            // cmbCongTy
            // 
            this.cmbCongTy.FormattingEnabled = true;
            this.cmbCongTy.Location = new System.Drawing.Point(85, 212);
            this.cmbCongTy.Name = "cmbCongTy";
            this.cmbCongTy.Size = new System.Drawing.Size(266, 28);
            this.cmbCongTy.TabIndex = 8;
            // 
            // btTim
            // 
            this.btTim.AutoSize = true;
            this.btTim.Location = new System.Drawing.Point(276, 32);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 30);
            this.btTim.TabIndex = 2;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.AutoSize = true;
            this.btCapNhat.Location = new System.Drawing.Point(85, 251);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(89, 30);
            this.btCapNhat.TabIndex = 3;
            this.btCapNhat.Text = "Cập Nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvNhanVien.Location = new System.Drawing.Point(377, 113);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(572, 344);
            this.dgvNhanVien.TabIndex = 4;
            // 
            // lblTTXN
            // 
            this.lblTTXN.AutoSize = true;
            this.lblTTXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTTXN.ForeColor = System.Drawing.Color.Blue;
            this.lblTTXN.Location = new System.Drawing.Point(356, 47);
            this.lblTTXN.Name = "lblTTXN";
            this.lblTTXN.Size = new System.Drawing.Size(313, 36);
            this.lblTTXN.TabIndex = 5;
            this.lblTTXN.Text = "Thông tin xét nghiệm";
            // 
            // danhSáchNVDươngTínhToolStripMenuItem
            // 
            this.danhSáchNVDươngTínhToolStripMenuItem.Name = "danhSáchNVDươngTínhToolStripMenuItem";
            this.danhSáchNVDươngTínhToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.danhSáchNVDươngTínhToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.danhSáchNVDươngTínhToolStripMenuItem.Text = "Danh Sách NV Dương Tính";
            this.danhSáchNVDươngTínhToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNVDươngTínhToolStripMenuItem_Click);
            // 
            // danhSáchCtyĐãTestTheoYCToolStripMenuItem
            // 
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem.Name = "danhSáchCtyĐãTestTheoYCToolStripMenuItem";
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem.Text = "Danh Sách Cty đã Test theo Y/C";
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem.Click += new System.EventHandler(this.danhSáchCtyĐãTestTheoYCToolStripMenuItem_Click);
            // 
            // xuấtBáoCáoToolStripMenuItem
            // 
            this.xuấtBáoCáoToolStripMenuItem.Name = "xuấtBáoCáoToolStripMenuItem";
            this.xuấtBáoCáoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.xuấtBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.xuấtBáoCáoToolStripMenuItem.Text = "Xuất Báo cáo";
            this.xuấtBáoCáoToolStripMenuItem.Click += new System.EventHandler(this.xuấtBáoCáoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(320, 6);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "CMND/CCCD";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 117;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "Họ và Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 99;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Số Lần XN";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Kết Quả";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 480);
            this.Controls.Add(this.lblTTXN);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.gbTTXN);
            this.Controls.Add(this.gbTTNV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý xét nghiệm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbTTNV.ResumeLayout(false);
            this.gbTTNV.PerformLayout();
            this.gbTTXN.ResumeLayout(false);
            this.gbTTXN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbTTNV;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.GroupBox gbTTXN;
        private System.Windows.Forms.Label lblCongTy;
        private System.Windows.Forms.RadioButton radDuongTinh;
        private System.Windows.Forms.RadioButton radAmTinh;
        private System.Windows.Forms.Label lblKetQuan;
        private System.Windows.Forms.Label lblSLXN;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.ComboBox cmbCongTy;
        private System.Windows.Forms.TextBox txtSLXN;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label lblTTXN;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNVDươngTínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchCtyĐãTestTheoYCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem xuấtBáoCáoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

