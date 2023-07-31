namespace MicroMEMSApp.Forms
{
    partial class frmTBYT
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenTB = new System.Windows.Forms.Label();
            this.lblMaTB = new System.Windows.Forms.Label();
            this.lblNhomTB = new System.Windows.Forms.Label();
            this.lblLoaiTB = new System.Windows.Forms.Label();
            this.lblDvt = new System.Windows.Forms.Label();
            this.lblHangSX = new System.Windows.Forms.Label();
            this.lblNuocSX = new System.Windows.Forms.Label();
            this.lblNamSX = new System.Windows.Forms.Label();
            this.lblGiaTri = new System.Windows.Forms.Label();
            this.lblSoLanBaoTriMotNam = new System.Windows.Forms.Label();
            this.tbxNhomTB = new System.Windows.Forms.TextBox();
            this.tbxLoaiTB = new System.Windows.Forms.TextBox();
            this.tbxMaTB = new System.Windows.Forms.TextBox();
            this.tbxTenTB = new System.Windows.Forms.TextBox();
            this.tbxDvt = new System.Windows.Forms.TextBox();
            this.tbxHangSX = new System.Windows.Forms.TextBox();
            this.tbxNuocSX = new System.Windows.Forms.TextBox();
            this.tbxNamSX = new System.Windows.Forms.TextBox();
            this.tbxGiaTri = new System.Windows.Forms.TextBox();
            this.tbxSoLanBaoTriMotNam = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(16, 154);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(1319, 387);
            this.grd.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 13);
            this.lblTitle.TabIndex = 1;
            // 
            // lblTenTB
            // 
            this.lblTenTB.AutoSize = true;
            this.lblTenTB.Location = new System.Drawing.Point(653, 93);
            this.lblTenTB.Name = "lblTenTB";
            this.lblTenTB.Size = new System.Drawing.Size(65, 13);
            this.lblTenTB.TabIndex = 2;
            this.lblTenTB.Text = "Ten Thiet Bi";
            // 
            // lblMaTB
            // 
            this.lblMaTB.AutoSize = true;
            this.lblMaTB.Location = new System.Drawing.Point(463, 93);
            this.lblMaTB.Name = "lblMaTB";
            this.lblMaTB.Size = new System.Drawing.Size(61, 13);
            this.lblMaTB.TabIndex = 2;
            this.lblMaTB.Text = "Ma Thiet Bi";
            // 
            // lblNhomTB
            // 
            this.lblNhomTB.AutoSize = true;
            this.lblNhomTB.Location = new System.Drawing.Point(13, 95);
            this.lblNhomTB.Name = "lblNhomTB";
            this.lblNhomTB.Size = new System.Drawing.Size(74, 13);
            this.lblNhomTB.TabIndex = 2;
            this.lblNhomTB.Text = "Nhom Thiet Bi";
            // 
            // lblLoaiTB
            // 
            this.lblLoaiTB.AutoSize = true;
            this.lblLoaiTB.Location = new System.Drawing.Point(250, 95);
            this.lblLoaiTB.Name = "lblLoaiTB";
            this.lblLoaiTB.Size = new System.Drawing.Size(66, 13);
            this.lblLoaiTB.TabIndex = 2;
            this.lblLoaiTB.Text = "Loai Thiet Bi";
            // 
            // lblDvt
            // 
            this.lblDvt.AutoSize = true;
            this.lblDvt.Location = new System.Drawing.Point(889, 91);
            this.lblDvt.Name = "lblDvt";
            this.lblDvt.Size = new System.Drawing.Size(58, 13);
            this.lblDvt.TabIndex = 2;
            this.lblDvt.Text = "Don vi tinh";
            // 
            // lblHangSX
            // 
            this.lblHangSX.AutoSize = true;
            this.lblHangSX.Location = new System.Drawing.Point(13, 119);
            this.lblHangSX.Name = "lblHangSX";
            this.lblHangSX.Size = new System.Drawing.Size(80, 13);
            this.lblHangSX.TabIndex = 2;
            this.lblHangSX.Text = "Hang San Xuat";
            // 
            // lblNuocSX
            // 
            this.lblNuocSX.AutoSize = true;
            this.lblNuocSX.Location = new System.Drawing.Point(250, 119);
            this.lblNuocSX.Name = "lblNuocSX";
            this.lblNuocSX.Size = new System.Drawing.Size(80, 13);
            this.lblNuocSX.TabIndex = 2;
            this.lblNuocSX.Text = "Nuoc San Xuat";
            // 
            // lblNamSX
            // 
            this.lblNamSX.AutoSize = true;
            this.lblNamSX.Location = new System.Drawing.Point(463, 119);
            this.lblNamSX.Name = "lblNamSX";
            this.lblNamSX.Size = new System.Drawing.Size(76, 13);
            this.lblNamSX.TabIndex = 2;
            this.lblNamSX.Text = "Nam San Xuat";
            // 
            // lblGiaTri
            // 
            this.lblGiaTri.AutoSize = true;
            this.lblGiaTri.Location = new System.Drawing.Point(653, 119);
            this.lblGiaTri.Name = "lblGiaTri";
            this.lblGiaTri.Size = new System.Drawing.Size(38, 13);
            this.lblGiaTri.TabIndex = 2;
            this.lblGiaTri.Text = "Gia Tri";
            // 
            // lblSoLanBaoTriMotNam
            // 
            this.lblSoLanBaoTriMotNam.AutoSize = true;
            this.lblSoLanBaoTriMotNam.Location = new System.Drawing.Point(889, 119);
            this.lblSoLanBaoTriMotNam.Name = "lblSoLanBaoTriMotNam";
            this.lblSoLanBaoTriMotNam.Size = new System.Drawing.Size(124, 13);
            this.lblSoLanBaoTriMotNam.TabIndex = 2;
            this.lblSoLanBaoTriMotNam.Text = "So Lan Bao Tri Mot Nam";
            // 
            // tbxNhomTB
            // 
            this.tbxNhomTB.Location = new System.Drawing.Point(92, 90);
            this.tbxNhomTB.Name = "tbxNhomTB";
            this.tbxNhomTB.Size = new System.Drawing.Size(138, 20);
            this.tbxNhomTB.TabIndex = 3;
            // 
            // tbxLoaiTB
            // 
            this.tbxLoaiTB.Location = new System.Drawing.Point(335, 88);
            this.tbxLoaiTB.Name = "tbxLoaiTB";
            this.tbxLoaiTB.Size = new System.Drawing.Size(113, 20);
            this.tbxLoaiTB.TabIndex = 3;
            // 
            // tbxMaTB
            // 
            this.tbxMaTB.Location = new System.Drawing.Point(545, 88);
            this.tbxMaTB.Name = "tbxMaTB";
            this.tbxMaTB.Size = new System.Drawing.Size(99, 20);
            this.tbxMaTB.TabIndex = 3;
            // 
            // tbxTenTB
            // 
            this.tbxTenTB.Location = new System.Drawing.Point(724, 88);
            this.tbxTenTB.Name = "tbxTenTB";
            this.tbxTenTB.Size = new System.Drawing.Size(159, 20);
            this.tbxTenTB.TabIndex = 3;
            // 
            // tbxDvt
            // 
            this.tbxDvt.Location = new System.Drawing.Point(1012, 85);
            this.tbxDvt.Name = "tbxDvt";
            this.tbxDvt.Size = new System.Drawing.Size(97, 20);
            this.tbxDvt.TabIndex = 3;
            // 
            // tbxHangSX
            // 
            this.tbxHangSX.Location = new System.Drawing.Point(92, 116);
            this.tbxHangSX.Name = "tbxHangSX";
            this.tbxHangSX.Size = new System.Drawing.Size(138, 20);
            this.tbxHangSX.TabIndex = 3;
            // 
            // tbxNuocSX
            // 
            this.tbxNuocSX.Location = new System.Drawing.Point(335, 112);
            this.tbxNuocSX.Name = "tbxNuocSX";
            this.tbxNuocSX.Size = new System.Drawing.Size(113, 20);
            this.tbxNuocSX.TabIndex = 3;
            // 
            // tbxNamSX
            // 
            this.tbxNamSX.Location = new System.Drawing.Point(545, 116);
            this.tbxNamSX.Name = "tbxNamSX";
            this.tbxNamSX.Size = new System.Drawing.Size(99, 20);
            this.tbxNamSX.TabIndex = 3;
            // 
            // tbxGiaTri
            // 
            this.tbxGiaTri.Location = new System.Drawing.Point(724, 116);
            this.tbxGiaTri.Name = "tbxGiaTri";
            this.tbxGiaTri.Size = new System.Drawing.Size(159, 20);
            this.tbxGiaTri.TabIndex = 3;
            // 
            // tbxSoLanBaoTriMotNam
            // 
            this.tbxSoLanBaoTriMotNam.Location = new System.Drawing.Point(1012, 116);
            this.tbxSoLanBaoTriMotNam.Name = "tbxSoLanBaoTriMotNam";
            this.tbxSoLanBaoTriMotNam.Size = new System.Drawing.Size(97, 20);
            this.tbxSoLanBaoTriMotNam.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(1139, 61);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(84, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Them";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1139, 119);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 25);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xoa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1139, 90);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Sua";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1139, 28);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(16, 63);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(214, 20);
            this.tbxSearch.TabIndex = 7;
            this.tbxSearch.Text = "Nhap Ten Thiet Bi ...";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(253, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tim kiem";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(352, 61);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(96, 23);
            this.btnClearSearch.TabIndex = 8;
            this.btnClearSearch.Text = "Clear Tim Kiem";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            // 
            // frmTBYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 592);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbxDvt);
            this.Controls.Add(this.tbxTenTB);
            this.Controls.Add(this.tbxMaTB);
            this.Controls.Add(this.tbxLoaiTB);
            this.Controls.Add(this.tbxSoLanBaoTriMotNam);
            this.Controls.Add(this.tbxGiaTri);
            this.Controls.Add(this.tbxNamSX);
            this.Controls.Add(this.tbxNuocSX);
            this.Controls.Add(this.tbxHangSX);
            this.Controls.Add(this.tbxNhomTB);
            this.Controls.Add(this.lblSoLanBaoTriMotNam);
            this.Controls.Add(this.lblGiaTri);
            this.Controls.Add(this.lblNamSX);
            this.Controls.Add(this.lblNuocSX);
            this.Controls.Add(this.lblHangSX);
            this.Controls.Add(this.lblDvt);
            this.Controls.Add(this.lblLoaiTB);
            this.Controls.Add(this.lblNhomTB);
            this.Controls.Add(this.lblMaTB);
            this.Controls.Add(this.lblTenTB);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grd);
            this.Name = "frmTBYT";
            this.Text = "frmTBYT";
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenTB;
        private System.Windows.Forms.Label lblMaTB;
        private System.Windows.Forms.Label lblNhomTB;
        private System.Windows.Forms.Label lblLoaiTB;
        private System.Windows.Forms.Label lblDvt;
        private System.Windows.Forms.Label lblHangSX;
        private System.Windows.Forms.Label lblNuocSX;
        private System.Windows.Forms.Label lblNamSX;
        private System.Windows.Forms.Label lblGiaTri;
        private System.Windows.Forms.Label lblSoLanBaoTriMotNam;
        private System.Windows.Forms.TextBox tbxNhomTB;
        private System.Windows.Forms.TextBox tbxLoaiTB;
        private System.Windows.Forms.TextBox tbxMaTB;
        private System.Windows.Forms.TextBox tbxTenTB;
        private System.Windows.Forms.TextBox tbxDvt;
        private System.Windows.Forms.TextBox tbxHangSX;
        private System.Windows.Forms.TextBox tbxNuocSX;
        private System.Windows.Forms.TextBox tbxNamSX;
        private System.Windows.Forms.TextBox tbxGiaTri;
        private System.Windows.Forms.TextBox tbxSoLanBaoTriMotNam;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
    }
}