using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroMEMSApp
{
    public partial class MainLKTBYTForm : Form
    {
        private readonly TBYTDbEntities _tbytDbEntities;
        public MainLKTBYTForm(TBYTDbEntities tbytDbEntities)
        {
            InitializeComponent();
            this._tbytDbEntities = tbytDbEntities;
        }

        private void MainLKTBYTForm_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void PopulateGrid()
        {
            var lktbyts = _tbytDbEntities.LKTBYT_Table.Select(q => new
            {
                Id = q.Id,
                MaLK = q.MaLK,
                TenLK = q.TenLK,
                Dvt = q.Dvt,
                SoLuong = q.SoLuong,
                TenTB = q.TBYT_Table.TenTB
            }).ToList();

            dataGridViewLKTBYT.DataSource = lktbyts;
            dataGridViewLKTBYT.Columns["MaLK"].HeaderText = "Ma Linh Kien";
            dataGridViewLKTBYT.Columns["TenLK"].HeaderText = "Ten Linh Kien";
            dataGridViewLKTBYT.Columns["Dvt"].HeaderText = "Don vi tinh";
            dataGridViewLKTBYT.Columns["SoLuong"].HeaderText = "So Luong";
            dataGridViewLKTBYT.Columns["TenTB"].HeaderText = "Ten Thiet Bi";

            dataGridViewLKTBYT.Columns["Id"].Visible = false;
            dataGridViewLKTBYT.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewLKTBYT.DefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Regular);
            dataGridViewLKTBYT.Columns["MaLK"].Width = 150;
            dataGridViewLKTBYT.Columns["TenLK"].Width = 150;
            dataGridViewLKTBYT.Columns["Dvt"].Width = 150;
            dataGridViewLKTBYT.Columns["SoLuong"].Width = 150;
            dataGridViewLKTBYT.Columns["TenTB"].Width = 150;
        }

        private void btnCreateLKTBYT_Click(object sender, EventArgs e)
        {
            MainCreateUpdateLKTBYTForm newMainCreateUpdateLKTBYTForm = new MainCreateUpdateLKTBYTForm(_tbytDbEntities, this);
            newMainCreateUpdateLKTBYTForm.MdiParent = this.MdiParent;
            newMainCreateUpdateLKTBYTForm.Show();
        }

        private void btnUpdateLKTBYT_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)dataGridViewLKTBYT.SelectedRows[0].Cells["Id"].Value;

                // query database for record
                var lktbytToUpdate = _tbytDbEntities.LKTBYT_Table.FirstOrDefault(q => q.Id == id);

                // launch MainCreateUpdateLKTBYTForm window with data
                var newMainCreateUpdateLKTBYTForm = new MainCreateUpdateLKTBYTForm(_tbytDbEntities, lktbytToUpdate, this);
                newMainCreateUpdateLKTBYTForm.MdiParent = this.MdiParent;
                newMainCreateUpdateLKTBYTForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void btnDeleteLKTBYT_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)dataGridViewLKTBYT.SelectedRows[0].Cells["Id"].Value;

                // query database for record
                var lktbytToRemove = _tbytDbEntities.LKTBYT_Table.FirstOrDefault(q => q.Id == id);

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?",
                    "Delete",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //delete Vehicle from Table
                    _tbytDbEntities.LKTBYT_Table.Remove(lktbytToRemove);
                    _tbytDbEntities.SaveChanges();
                }
                PopulateGrid();
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
