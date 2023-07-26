using System.Drawing;

namespace MicroMEMSApp
{
    partial class TBYTForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnAddTBYT = new System.Windows.Forms.Button();
            this.dataGridViewTBYTs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTBYT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteTBYT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DetailLKTBYT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tBYTTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBYTDbDataSet = new MicroMEMSApp.TBYTDbDataSet();
            this.tBYTTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefreshDataGridView = new System.Windows.Forms.Button();
            this.tBYT_TableTableAdapter = new MicroMEMSApp.TBYTDbDataSetTableAdapters.TBYT_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTBYTs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBYTTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBYTDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBYTTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(36, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(311, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Danh Sach Thiet Bi Y Te";
            // 
            // btnAddTBYT
            // 
            this.btnAddTBYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddTBYT.Location = new System.Drawing.Point(42, 76);
            this.btnAddTBYT.Name = "btnAddTBYT";
            this.btnAddTBYT.Size = new System.Drawing.Size(142, 39);
            this.btnAddTBYT.TabIndex = 1;
            this.btnAddTBYT.Text = "Them TBYT";
            this.btnAddTBYT.UseVisualStyleBackColor = true;
            this.btnAddTBYT.Click += new System.EventHandler(this.btnAddTBYT_Click);
            // 
            // dataGridViewTBYTs
            // 
            this.dataGridViewTBYTs.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTBYTs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTBYTs.ColumnHeadersDefaultCellStyle.Font = new Font("arial", 8, FontStyle.Bold);
            this.dataGridViewTBYTs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTBYTs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.UpdateTBYT,
            this.DeleteTBYT,
            this.DetailLKTBYT});
            this.dataGridViewTBYTs.DataSource = this.tBYTTableBindingSource1;
            this.dataGridViewTBYTs.EnableHeadersVisualStyles = false;
            this.dataGridViewTBYTs.Location = new System.Drawing.Point(22, 121);
            this.dataGridViewTBYTs.Name = "dataGridViewTBYTs";
            this.dataGridViewTBYTs.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataGridViewTBYTs.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTBYTs.Size = new System.Drawing.Size(1304, 554);
            this.dataGridViewTBYTs.TabIndex = 2;
            this.dataGridViewTBYTs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTBYTs_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NhomTB";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nhom Thiet Bi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LoaiTB";
            this.dataGridViewTextBoxColumn3.HeaderText = "Loai Thiet Bi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaTB";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ma Thiet Bi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenTB";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ten Thiet Bi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Dvt";
            this.dataGridViewTextBoxColumn6.HeaderText = "Don Vi Tinh";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HangSX";
            this.dataGridViewTextBoxColumn7.HeaderText = "Hang San Xuat";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NuocSX";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nuoc San Xuat";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NamSX";
            this.dataGridViewTextBoxColumn9.HeaderText = "Nam San Xuat";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "GiaTri";
            this.dataGridViewTextBoxColumn10.HeaderText = "Gia Tri";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "SoLanBaoTriMotNam";
            this.dataGridViewTextBoxColumn11.HeaderText = "So Lan Bao Tri Mot Nam";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 50;
            // 
            // UpdateTBYT
            // 
            this.UpdateTBYT.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.UpdateTBYT.DefaultCellStyle = dataGridViewCellStyle2;
            this.UpdateTBYT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateTBYT.HeaderText = "Sua";
            this.UpdateTBYT.Name = "UpdateTBYT";
            this.UpdateTBYT.ReadOnly = true;
            this.UpdateTBYT.Text = "Sua Thiet Bi";
            this.UpdateTBYT.UseColumnTextForButtonValue = true;
            // 
            // DeleteTBYT
            // 
            this.DeleteTBYT.DataPropertyName = "Id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteTBYT.DefaultCellStyle = dataGridViewCellStyle3;
            this.DeleteTBYT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTBYT.HeaderText = "Xoa";
            this.DeleteTBYT.Name = "DeleteTBYT";
            this.DeleteTBYT.ReadOnly = true;
            this.DeleteTBYT.Text = "Xoa Thiet Bi";
            this.DeleteTBYT.UseColumnTextForButtonValue = true;
            // 
            // DetailLKTBYT
            // 
            this.DetailLKTBYT.DataPropertyName = "Id";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DetailLKTBYT.DefaultCellStyle = dataGridViewCellStyle4;
            this.DetailLKTBYT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailLKTBYT.HeaderText = "Chi Tiet Linh Kien";
            this.DetailLKTBYT.Name = "DetailLKTBYT";
            this.DetailLKTBYT.ReadOnly = true;
            this.DetailLKTBYT.Text = "Xem Linh Kien";
            this.DetailLKTBYT.UseColumnTextForButtonValue = true;
            // 
            // tBYTTableBindingSource1
            // 
            this.tBYTTableBindingSource1.DataMember = "TBYT_Table";
            this.tBYTTableBindingSource1.DataSource = this.tBYTDbDataSet;
            // 
            // tBYTDbDataSet
            // 
            this.tBYTDbDataSet.DataSetName = "TBYTDbDataSet";
            this.tBYTDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBYTTableBindingSource
            // 
            this.tBYTTableBindingSource.DataMember = "TBYT_Table";
            // 
            // btnRefreshDataGridView
            // 
            this.btnRefreshDataGridView.Location = new System.Drawing.Point(229, 76);
            this.btnRefreshDataGridView.Name = "btnRefreshDataGridView";
            this.btnRefreshDataGridView.Size = new System.Drawing.Size(212, 39);
            this.btnRefreshDataGridView.TabIndex = 3;
            this.btnRefreshDataGridView.Text = "Refresh Table";
            this.btnRefreshDataGridView.UseVisualStyleBackColor = true;
            this.btnRefreshDataGridView.Click += new System.EventHandler(this.btnRefreshDataGridView_Click);
            // 
            // tBYT_TableTableAdapter
            // 
            this.tBYT_TableTableAdapter.ClearBeforeFill = true;
            // 
            // TBYTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnRefreshDataGridView);
            this.Controls.Add(this.dataGridViewTBYTs);
            this.Controls.Add(this.btnAddTBYT);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "TBYTForm";
            this.Text = "Quan Li Thiet Bi Y Te";
            this.Load += new System.EventHandler(this.TBYTForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTBYTs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBYTTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBYTDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBYTTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnAddTBYT;
        private System.Windows.Forms.DataGridView dataGridViewTBYTs;
        private System.Windows.Forms.Button btnRefreshDataGridView;
        private System.Windows.Forms.BindingSource tBYTTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhomTBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiTBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nuocSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLanBaoTriMotNamDataGridViewTextBoxColumn;
        private TBYTDbDataSet tBYTDbDataSet;
        private System.Windows.Forms.BindingSource tBYTTableBindingSource1;
        private TBYTDbDataSetTableAdapters.TBYT_TableTableAdapter tBYT_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateTBYT;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteTBYT;
        private System.Windows.Forms.DataGridViewButtonColumn DetailLKTBYT;
    }
}

