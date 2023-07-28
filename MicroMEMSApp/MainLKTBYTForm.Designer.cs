namespace MicroMEMSApp
{
    partial class MainLKTBYTForm
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
            this.dataGridViewLKTBYT = new System.Windows.Forms.DataGridView();
            this.btnCreateLKTBYT = new System.Windows.Forms.Button();
            this.btnUpdateLKTBYT = new System.Windows.Forms.Button();
            this.btnDeleteLKTBYT = new System.Windows.Forms.Button();
            this.labelTitleLKTBYT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLKTBYT)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLKTBYT
            // 
            this.dataGridViewLKTBYT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLKTBYT.Location = new System.Drawing.Point(35, 87);
            this.dataGridViewLKTBYT.Name = "dataGridViewLKTBYT";
            this.dataGridViewLKTBYT.Size = new System.Drawing.Size(900, 356);
            this.dataGridViewLKTBYT.TabIndex = 0;
            // 
            // btnCreateLKTBYT
            // 
            this.btnCreateLKTBYT.Location = new System.Drawing.Point(35, 449);
            this.btnCreateLKTBYT.Name = "btnCreateLKTBYT";
            this.btnCreateLKTBYT.Size = new System.Drawing.Size(148, 35);
            this.btnCreateLKTBYT.TabIndex = 1;
            this.btnCreateLKTBYT.Text = "Them Linh Kien ";
            this.btnCreateLKTBYT.UseVisualStyleBackColor = true;
            this.btnCreateLKTBYT.Click += new System.EventHandler(this.btnCreateLKTBYT_Click);
            // 
            // btnUpdateLKTBYT
            // 
            this.btnUpdateLKTBYT.Location = new System.Drawing.Point(414, 449);
            this.btnUpdateLKTBYT.Name = "btnUpdateLKTBYT";
            this.btnUpdateLKTBYT.Size = new System.Drawing.Size(148, 35);
            this.btnUpdateLKTBYT.TabIndex = 1;
            this.btnUpdateLKTBYT.Text = "Sua Linh Kien";
            this.btnUpdateLKTBYT.UseVisualStyleBackColor = true;
            this.btnUpdateLKTBYT.Click += new System.EventHandler(this.btnUpdateLKTBYT_Click);
            // 
            // btnDeleteLKTBYT
            // 
            this.btnDeleteLKTBYT.Location = new System.Drawing.Point(787, 449);
            this.btnDeleteLKTBYT.Name = "btnDeleteLKTBYT";
            this.btnDeleteLKTBYT.Size = new System.Drawing.Size(148, 35);
            this.btnDeleteLKTBYT.TabIndex = 1;
            this.btnDeleteLKTBYT.Text = "Xoa Linh Kien";
            this.btnDeleteLKTBYT.UseVisualStyleBackColor = true;
            this.btnDeleteLKTBYT.Click += new System.EventHandler(this.btnDeleteLKTBYT_Click);
            // 
            // labelTitleLKTBYT
            // 
            this.labelTitleLKTBYT.AutoSize = true;
            this.labelTitleLKTBYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTitleLKTBYT.Location = new System.Drawing.Point(258, 9);
            this.labelTitleLKTBYT.Name = "labelTitleLKTBYT";
            this.labelTitleLKTBYT.Size = new System.Drawing.Size(451, 31);
            this.labelTitleLKTBYT.TabIndex = 2;
            this.labelTitleLKTBYT.Text = "Danh Muc Linh Kien Thiet Bi Y Te";
            // 
            // MainLKTBYTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 531);
            this.Controls.Add(this.labelTitleLKTBYT);
            this.Controls.Add(this.btnDeleteLKTBYT);
            this.Controls.Add(this.btnUpdateLKTBYT);
            this.Controls.Add(this.btnCreateLKTBYT);
            this.Controls.Add(this.dataGridViewLKTBYT);
            this.Name = "MainLKTBYTForm";
            this.Text = "Quan Li Linh Kien Thiet Bi Y Te";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainLKTBYTForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLKTBYT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLKTBYT;
        private System.Windows.Forms.Button btnCreateLKTBYT;
        private System.Windows.Forms.Button btnUpdateLKTBYT;
        private System.Windows.Forms.Button btnDeleteLKTBYT;
        private System.Windows.Forms.Label labelTitleLKTBYT;
    }
}