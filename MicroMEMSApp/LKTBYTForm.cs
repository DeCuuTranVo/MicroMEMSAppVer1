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
    public partial class LKTBYTForm : Form
    {
        private readonly TBYTDbEntities tbytDbEntities;
        private readonly int idTBYTParent;
        private TBYT_Table tbytParent;
        public LKTBYTForm(TBYTDbEntities tbytDbEntities, int idTBYTParent)
        {
            InitializeComponent();
            this.tbytDbEntities = tbytDbEntities;
            this.idTBYTParent = idTBYTParent;
            this.tbytParent = this.tbytDbEntities.TBYT_Table.Find(this.idTBYTParent);
        }

        public void LoadLKTBYTData()
        {
            /*
            var query =
                from t1 in tbytDbEntities.LKTBYT_Table
                join t2 in tbytDbEntities.TBYT_Table on t1.IdTBYT equals t2.Id
                where t2.Id == idTBYTParent
                select new { t1.Id, t1.MaLK, t1.TenLK, t1.Dvt, t1.SoLuong, TenTB = t1.TBYT_Table.TenTB}// t2.TenTB}
                ;
            */

            var query =
                from t1 in tbytDbEntities.LKTBYT_Table
                where t1.IdTBYT == idTBYTParent
                select new { t1.Id, t1.MaLK, t1.TenLK, t1.Dvt, t1.SoLuong, TenTB = t1.TBYT_Table.TenTB };

            dataGridViewLKTBYTs.DataSource = query.ToList();
            //dataGridViewLKTBYTs.DataSource = tbytDbEntities.LKTBYT_Table.ToList();
        }

        private void LKTBYTForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tBYTDbDataSet1.LKTBYT_Table' table. You can move, or remove it, as needed.
            this.lKTBYT_TableTableAdapter.Fill(this.tBYTDbDataSet1.LKTBYT_Table);
            // TODO: This line of code loads data into the 'tBYTDbDataSet.LKTBYT_Table' table. You can move, or remove it, as needed.
            //this.lKTBYT_TableTableAdapter.Fill(this.tBYTDbDataSet.LKTBYT_Table);

            this.textBoxNhomTB.Text = tbytParent.NhomTB.ToString();
            this.textBoxLoaiTB.Text = tbytParent.LoaiTB.ToString();
            this.textBoxMaTB.Text = tbytParent.MaTB.ToString();
            this.textBoxTenTB.Text = tbytParent.TenTB.ToString();

            LoadLKTBYTData();
        }

        private void btnCreateLKTBYT_Click(object sender, EventArgs e)
        {
            LKTBYTCreateForm newLKTBYTCreateForm = new LKTBYTCreateForm(tbytDbEntities, this.idTBYTParent);
            var dr = newLKTBYTCreateForm.ShowDialog(); 
            if (dr == DialogResult.OK)
            {
                LoadLKTBYTData();
            }
           
        }

        private void dataGridViewLKTBYTs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.RowIndex > -1)
            {
                // Avoid choosing header
                if (dataGridViewLKTBYTs.Columns[e.ColumnIndex].Name == "UpdateLKTBYTColumn")
                {
                    
                    // get the row index of the cell clicked
                    var rowIndex = e.RowIndex;

                    // specify 0, if the Id is in the first Column else in place of 0 e.ColumnIndex
                    int idLKTBYTUpdate = Convert.ToInt32(dataGridViewLKTBYTs.Rows[e.RowIndex].Cells[0].Value);

                    // Create a new form
                    LKTBYTUpdateForm newLKTBYTUpdateForm = new LKTBYTUpdateForm(tbytDbEntities, idLKTBYTUpdate);
                    DialogResult drUpdateLKTBYT = newLKTBYTUpdateForm.ShowDialog();
                    if (drUpdateLKTBYT == DialogResult.OK)
                    {
                        LoadLKTBYTData();
                    }

                    //MessageBox.Show($"Update Record {idTBYTUpdate}");
                }
                else if (dataGridViewLKTBYTs.Columns[e.ColumnIndex].Name == "DeleteLKTBYTColumn") // Delete Function
                {                    
                    // get the row index of the cell clicked
                    var rowIndex = e.RowIndex;

                    // specify 0, if the Id is in the first Column else in place of 0 e.ColumnIndex
                    int idLKTBYT = Convert.ToInt32(dataGridViewLKTBYTs.Rows[e.RowIndex].Cells[0].Value);

                    // get the tbyt record to be deleted
                    LKTBYT_Table lktbytRemove = tbytDbEntities.LKTBYT_Table.Where(p => p.Id == idLKTBYT).SingleOrDefault();

                    DialogResult drDeleteTBYT = MessageBox.Show($"Delete the Record of {lktbytRemove.TenLK.Trim()} at id {lktbytRemove.Id}", "Delete Confirmation", MessageBoxButtons.OKCancel);
                    if (drDeleteTBYT == DialogResult.OK)
                    {
                        // remove the record
                        tbytDbEntities.LKTBYT_Table.Remove(lktbytRemove);
                        tbytDbEntities.SaveChanges();

                        // LoadTBYTData();
                        LoadLKTBYTData();
                    }            
                }
            }
        }
    }
}
