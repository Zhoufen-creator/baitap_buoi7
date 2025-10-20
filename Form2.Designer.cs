namespace WF_DiemCong
{
    partial class Form2
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry3 = new System.DirectoryServices.DirectoryEntry();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblCongTy = new System.Windows.Forms.Label();
            this.cmbCongTy = new System.Windows.Forms.ComboBox();
            this.btXem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 129);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(806, 309);
            this.reportViewer1.TabIndex = 0;
            // 
            // lblCongTy
            // 
            this.lblCongTy.AutoSize = true;
            this.lblCongTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCongTy.Location = new System.Drawing.Point(219, 61);
            this.lblCongTy.Name = "lblCongTy";
            this.lblCongTy.Size = new System.Drawing.Size(71, 20);
            this.lblCongTy.TabIndex = 1;
            this.lblCongTy.Text = "Công Ty";
            // 
            // cmbCongTy
            // 
            this.cmbCongTy.FormattingEnabled = true;
            this.cmbCongTy.Location = new System.Drawing.Point(308, 61);
            this.cmbCongTy.Name = "cmbCongTy";
            this.cmbCongTy.Size = new System.Drawing.Size(229, 24);
            this.cmbCongTy.TabIndex = 2;
            // 
            // btXem
            // 
            this.btXem.AutoSize = true;
            this.btXem.Location = new System.Drawing.Point(543, 61);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(75, 26);
            this.btXem.TabIndex = 3;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.cmbCongTy);
            this.Controls.Add(this.lblCongTy);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Báo cáo xét nghiệm";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private System.DirectoryServices.DirectoryEntry directoryEntry3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblCongTy;
        private System.Windows.Forms.ComboBox cmbCongTy;
        private System.Windows.Forms.Button btXem;
    }
}