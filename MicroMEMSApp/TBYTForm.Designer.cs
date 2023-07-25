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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnAddTBYT = new System.Windows.Forms.Button();
            this.dataGridViewTBYTs = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomTBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiTBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuocSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLanBaoTriMotNamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTBYT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteTBYT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DetailLKTBYT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tBYTTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBYTDbDataSet = new MicroMEMSApp.TBYTDbDataSet();
            this.btnRefreshDataGridView = new System.Windows.Forms.Button();
            this.tBYT_TableTableAdapter = new MicroMEMSApp.TBYTDbDataSetTableAdapters.TBYT_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTBYTs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBYTTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBYTDbDataSet)).BeginInit();
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTBYTs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTBYTs.ColumnHeadersDefaultCellStyle.Font = new Font("arial", 8, FontStyle.Regular);

            this.dataGridViewTBYTs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTBYTs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nhomTBDataGridViewTextBoxColumn,
            this.loaiTBDataGridViewTextBoxColumn,
            this.maTBDataGridViewTextBoxColumn,
            this.tenTBDataGridViewTextBoxColumn,
            this.dvtDataGridViewTextBoxColumn,
            this.hangSXDataGridViewTextBoxColumn,
            this.nuocSXDataGridViewTextBoxColumn,
            this.namSXDataGridViewTextBoxColumn,
            this.giaTriDataGridViewTextBoxColumn,
            this.soLanBaoTriMotNamDataGridViewTextBoxColumn,
            this.UpdateTBYT,
            this.DeleteTBYT,
            this.DetailLKTBYT});
            this.dataGridViewTBYTs.DataSource = this.tBYTTableBindingSource;
            this.dataGridViewTBYTs.EnableHeadersVisualStyles = false;
            this.dataGridViewTBYTs.Location = new System.Drawing.Point(22, 121);
            this.dataGridViewTBYTs.Name = "dataGridViewTBYTs";
            this.dataGridViewTBYTs.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataGridViewTBYTs.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTBYTs.Size = new System.Drawing.Size(1222, 554);
            this.dataGridViewTBYTs.TabIndex = 2;
            this.dataGridViewTBYTs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTBYTs_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nhomTBDataGridViewTextBoxColumn
            // 
            this.nhomTBDataGridViewTextBoxColumn.DataPropertyName = "NhomTB";
            this.nhomTBDataGridViewTextBoxColumn.HeaderText = "NhomTB";
            this.nhomTBDataGridViewTextBoxColumn.Name = "nhomTBDataGridViewTextBoxColumn";
            this.nhomTBDataGridViewTextBoxColumn.Width = 80;
            // 
            // loaiTBDataGridViewTextBoxColumn
            // 
            this.loaiTBDataGridViewTextBoxColumn.DataPropertyName = "LoaiTB";
            this.loaiTBDataGridViewTextBoxColumn.HeaderText = "LoaiTB";
            this.loaiTBDataGridViewTextBoxColumn.Name = "loaiTBDataGridViewTextBoxColumn";
            this.loaiTBDataGridViewTextBoxColumn.Width = 80;
            // 
            // maTBDataGridViewTextBoxColumn
            // 
            this.maTBDataGridViewTextBoxColumn.DataPropertyName = "MaTB";
            this.maTBDataGridViewTextBoxColumn.HeaderText = "MaTB";
            this.maTBDataGridViewTextBoxColumn.Name = "maTBDataGridViewTextBoxColumn";
            this.maTBDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenTBDataGridViewTextBoxColumn
            // 
            this.tenTBDataGridViewTextBoxColumn.DataPropertyName = "TenTB";
            this.tenTBDataGridViewTextBoxColumn.HeaderText = "TenTB";
            this.tenTBDataGridViewTextBoxColumn.Name = "tenTBDataGridViewTextBoxColumn";
            this.tenTBDataGridViewTextBoxColumn.Width = 80;
            // 
            // dvtDataGridViewTextBoxColumn
            // 
            this.dvtDataGridViewTextBoxColumn.DataPropertyName = "Dvt";
            this.dvtDataGridViewTextBoxColumn.HeaderText = "Dvt";
            this.dvtDataGridViewTextBoxColumn.Name = "dvtDataGridViewTextBoxColumn";
            this.dvtDataGridViewTextBoxColumn.Width = 80;
            // 
            // hangSXDataGridViewTextBoxColumn
            // 
            this.hangSXDataGridViewTextBoxColumn.DataPropertyName = "HangSX";
            this.hangSXDataGridViewTextBoxColumn.HeaderText = "HangSX";
            this.hangSXDataGridViewTextBoxColumn.Name = "hangSXDataGridViewTextBoxColumn";
            this.hangSXDataGridViewTextBoxColumn.Width = 80;
            // 
            // nuocSXDataGridViewTextBoxColumn
            // 
            this.nuocSXDataGridViewTextBoxColumn.DataPropertyName = "NuocSX";
            this.nuocSXDataGridViewTextBoxColumn.HeaderText = "NuocSX";
            this.nuocSXDataGridViewTextBoxColumn.Name = "nuocSXDataGridViewTextBoxColumn";
            this.nuocSXDataGridViewTextBoxColumn.Width = 80;
            // 
            // namSXDataGridViewTextBoxColumn
            // 
            this.namSXDataGridViewTextBoxColumn.DataPropertyName = "NamSX";
            this.namSXDataGridViewTextBoxColumn.HeaderText = "NamSX";
            this.namSXDataGridViewTextBoxColumn.Name = "namSXDataGridViewTextBoxColumn";
            this.namSXDataGridViewTextBoxColumn.Width = 80;
            // 
            // giaTriDataGridViewTextBoxColumn
            // 
            this.giaTriDataGridViewTextBoxColumn.DataPropertyName = "GiaTri";
            this.giaTriDataGridViewTextBoxColumn.HeaderText = "GiaTri";
            this.giaTriDataGridViewTextBoxColumn.Name = "giaTriDataGridViewTextBoxColumn";
            this.giaTriDataGridViewTextBoxColumn.Width = 80;
            // 
            // soLanBaoTriMotNamDataGridViewTextBoxColumn
            // 
            this.soLanBaoTriMotNamDataGridViewTextBoxColumn.DataPropertyName = "SoLanBaoTriMotNam";
            this.soLanBaoTriMotNamDataGridViewTextBoxColumn.HeaderText = "SoLanBaoTriMotNam";
            this.soLanBaoTriMotNamDataGridViewTextBoxColumn.Name = "soLanBaoTriMotNamDataGridViewTextBoxColumn";
            this.soLanBaoTriMotNamDataGridViewTextBoxColumn.Width = 150;
            // 
            // UpdateTBYT
            // 
            this.UpdateTBYT.DataPropertyName = "Id";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.UpdateTBYT.DefaultCellStyle = dataGridViewCellStyle7;
            this.UpdateTBYT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateTBYT.HeaderText = "Update";
            this.UpdateTBYT.Name = "UpdateTBYT";
            this.UpdateTBYT.ReadOnly = true;
            this.UpdateTBYT.Text = "Update Record";
            this.UpdateTBYT.UseColumnTextForButtonValue = true;
            // 
            // DeleteTBYT
            // 
            this.DeleteTBYT.DataPropertyName = "Id";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteTBYT.DefaultCellStyle = dataGridViewCellStyle8;
            this.DeleteTBYT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTBYT.HeaderText = "Delete";
            this.DeleteTBYT.Name = "DeleteTBYT";
            this.DeleteTBYT.ReadOnly = true;
            this.DeleteTBYT.Text = "Delete Record";
            this.DeleteTBYT.UseColumnTextForButtonValue = true;
            // 
            // DetailLKTBYT
            // 
            this.DetailLKTBYT.DataPropertyName = "Id";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DetailLKTBYT.DefaultCellStyle = dataGridViewCellStyle9;
            this.DetailLKTBYT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailLKTBYT.HeaderText = "Chi Tiet Linh Kien";
            this.DetailLKTBYT.Name = "DetailLKTBYT";
            this.DetailLKTBYT.ReadOnly = true;
            this.DetailLKTBYT.Text = "Xem Linh Kien";
            this.DetailLKTBYT.UseColumnTextForButtonValue = true;
            // 
            // tBYTTableBindingSource
            // 
            this.tBYTTableBindingSource.DataMember = "TBYT_Table";
            this.tBYTTableBindingSource.DataSource = this.tBYTDbDataSet;
            // 
            // tBYTDbDataSet
            // 
            this.tBYTDbDataSet.DataSetName = "TBYTDbDataSet";
            this.tBYTDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            ((System.ComponentModel.ISupportInitialize)(this.tBYTTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBYTDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnAddTBYT;
        private System.Windows.Forms.DataGridView dataGridViewTBYTs;
        private System.Windows.Forms.Button btnRefreshDataGridView;
        private TBYTDbDataSet tBYTDbDataSet;
        private System.Windows.Forms.BindingSource tBYTTableBindingSource;
        private TBYTDbDataSetTableAdapters.TBYT_TableTableAdapter tBYT_TableTableAdapter;
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
        private System.Windows.Forms.DataGridViewButtonColumn UpdateTBYT;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteTBYT;
        private System.Windows.Forms.DataGridViewButtonColumn DetailLKTBYT;
    }
}

