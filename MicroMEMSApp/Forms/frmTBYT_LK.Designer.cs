namespace MicroMEMSApp.Forms
{
    partial class frmTBYT_LK
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
            this.grd = new System.Windows.Forms.DataGridView();
            this.lblMaLK = new System.Windows.Forms.Label();
            this.lblTenLK = new System.Windows.Forms.Label();
            this.lblDvt = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTB = new System.Windows.Forms.Label();
            this.tbxMaLK = new System.Windows.Forms.TextBox();
            this.tbxTenLK = new System.Windows.Forms.TextBox();
            this.tbxDvt = new System.Windows.Forms.TextBox();
            this.tbxSoLuong = new System.Windows.Forms.TextBox();
            this.cbxTB = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(3, 124);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(796, 314);
            this.grd.TabIndex = 0;
            // 
            // lblMaLK
            // 
            this.lblMaLK.AutoSize = true;
            this.lblMaLK.Location = new System.Drawing.Point(23, 70);
            this.lblMaLK.Name = "lblMaLK";
            this.lblMaLK.Size = new System.Drawing.Size(69, 13);
            this.lblMaLK.TabIndex = 1;
            this.lblMaLK.Text = "Mã Linh Kiện";
            // 
            // lblTenLK
            // 
            this.lblTenLK.AutoSize = true;
            this.lblTenLK.Location = new System.Drawing.Point(231, 70);
            this.lblTenLK.Name = "lblTenLK";
            this.lblTenLK.Size = new System.Drawing.Size(73, 13);
            this.lblTenLK.TabIndex = 1;
            this.lblTenLK.Text = "Tên Linh Kiện";
            // 
            // lblDvt
            // 
            this.lblDvt.AutoSize = true;
            this.lblDvt.Location = new System.Drawing.Point(23, 93);
            this.lblDvt.Name = "lblDvt";
            this.lblDvt.Size = new System.Drawing.Size(60, 13);
            this.lblDvt.TabIndex = 1;
            this.lblDvt.Text = "Đơn vị tính";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(231, 93);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(53, 13);
            this.lblSoLuong.TabIndex = 1;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.Location = new System.Drawing.Point(443, 93);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(43, 13);
            this.lblTB.TabIndex = 2;
            this.lblTB.Text = "Thiết Bị";
            // 
            // tbxMaLK
            // 
            this.tbxMaLK.Location = new System.Drawing.Point(98, 67);
            this.tbxMaLK.Name = "tbxMaLK";
            this.tbxMaLK.Size = new System.Drawing.Size(127, 20);
            this.tbxMaLK.TabIndex = 3;
            // 
            // tbxTenLK
            // 
            this.tbxTenLK.Location = new System.Drawing.Point(310, 67);
            this.tbxTenLK.Name = "tbxTenLK";
            this.tbxTenLK.Size = new System.Drawing.Size(127, 20);
            this.tbxTenLK.TabIndex = 3;
            // 
            // tbxDvt
            // 
            this.tbxDvt.Location = new System.Drawing.Point(98, 90);
            this.tbxDvt.Name = "tbxDvt";
            this.tbxDvt.Size = new System.Drawing.Size(127, 20);
            this.tbxDvt.TabIndex = 3;
            // 
            // tbxSoLuong
            // 
            this.tbxSoLuong.Location = new System.Drawing.Point(310, 90);
            this.tbxSoLuong.Name = "tbxSoLuong";
            this.tbxSoLuong.Size = new System.Drawing.Size(127, 20);
            this.tbxSoLuong.TabIndex = 3;
            // 
            // cbxTB
            // 
            this.cbxTB.FormattingEnabled = true;
            this.cbxTB.Location = new System.Drawing.Point(492, 90);
            this.cbxTB.Name = "cbxTB";
            this.cbxTB.Size = new System.Drawing.Size(206, 21);
            this.cbxTB.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(11, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 13);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "lblTitle";
            // 
            // frmTBYT_LK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 443);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbxTB);
            this.Controls.Add(this.tbxSoLuong);
            this.Controls.Add(this.tbxDvt);
            this.Controls.Add(this.tbxTenLK);
            this.Controls.Add(this.tbxMaLK);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblDvt);
            this.Controls.Add(this.lblTenLK);
            this.Controls.Add(this.lblMaLK);
            this.Controls.Add(this.grd);
            this.Name = "frmTBYT_LK";
            this.Text = "frmTBYT_LK";
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Label lblMaLK;
        private System.Windows.Forms.Label lblTenLK;
        private System.Windows.Forms.Label lblDvt;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.TextBox tbxMaLK;
        private System.Windows.Forms.TextBox tbxTenLK;
        private System.Windows.Forms.TextBox tbxDvt;
        private System.Windows.Forms.TextBox tbxSoLuong;
        private System.Windows.Forms.ComboBox cbxTB;
        private System.Windows.Forms.Label lblTitle;
    }
}