using MicroMEMSApp.Data;
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
    public partial class TBYTForm : Form
    {
        private readonly TBYTDbEntities tbytDbEntities;
        public TBYTForm(TBYTDbEntities tbytDbEntities)
        {
            InitializeComponent();
            this.tbytDbEntities = tbytDbEntities;

            //dataGridViewTBYTs.CellClick += DataGridViewTBYTs_CellClick;
        }

        public void LoadTBYTData()
        {
            dataGridViewTBYTs.DataSource = tbytDbEntities.TBYT_Table.ToList();
        }


        private void btnAddTBYT_Click(object sender, EventArgs e)
        {
            TBYTCreateForm newTBYTAddForm = new TBYTCreateForm(tbytDbEntities);
            if (newTBYTAddForm.ShowDialog() == DialogResult.OK)
            {
                LoadTBYTData();
            }
                //this.Hide();
        }

        private void TBYTForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tBYTDbDataSet.TBYT_Table' table. You can move, or remove it, as needed.
            this.tBYT_TableTableAdapter.Fill(this.tBYTDbDataSet.TBYT_Table);
            // TODO: This line of code loads data into the 'tBYTDbDataSet.TBYT_Table' table. You can move, or remove it, as needed.
            //this.tBYT_TableTableAdapter.Fill(this.tBYTDbDataSet.TBYT_Table);
            LoadTBYTData();

            // Format datagridview header cells
            //this.dataGridViewTBYTs.EnableHeadersVisualStyles = false;
            //this.dataGridViewTBYTs.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            //this.dataGridViewTBYTs.ColumnHeadersDefaultCellStyle.Font = new Font("arial", 8, FontStyle.Bold);

        }

        private void dataGridViewTBYTs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.RowIndex > -1)
            {
                // Avoid choosing header
                if (dataGridViewTBYTs.Columns[e.ColumnIndex].Name == "UpdateTBYT")
                {
                    // get the row index of the cell clicked
                    var rowIndex = e.RowIndex;

                    // specify 0, if the Id is in the first Column else in place of 0 e.ColumnIndex
                    int idTBYTUpdate = Convert.ToInt32(dataGridViewTBYTs.Rows[e.RowIndex].Cells[0].Value);

                    // Create a new form
                    TBYTUpdateForm newTBYTUpdateForm = new TBYTUpdateForm(tbytDbEntities, idTBYTUpdate);
                    DialogResult drUpdateTBYT = newTBYTUpdateForm.ShowDialog();
                    if (drUpdateTBYT == DialogResult.OK)
                    {
                        LoadTBYTData();
                    }
                    //MessageBox.Show($"Update Record {idTBYTUpdate}");
                }
                else if (dataGridViewTBYTs.Columns[e.ColumnIndex].Name == "DeleteTBYT") // Delete Function
                {
                    // get the row index of the cell clicked
                    var rowIndex = e.RowIndex;

                    // specify 0, if the Id is in the first Column else in place of 0 e.ColumnIndex
                    int idTBYT = Convert.ToInt32(dataGridViewTBYTs.Rows[e.RowIndex].Cells[0].Value);

                    // get the tbyt record to be deleted
                    TBYT_Table tbytRemove = tbytDbEntities.TBYT_Table.Where(p => p.Id == idTBYT).SingleOrDefault();

                    DialogResult drDeleteTBYT = MessageBox.Show($"Delete the Record of {tbytRemove.TenTB} at id {tbytRemove.Id}", "Delete Confirmation", MessageBoxButtons.OKCancel);
                    if (drDeleteTBYT == DialogResult.OK)
                    {
                        // remove the record
                        tbytDbEntities.TBYT_Table.Remove(tbytRemove);
                        tbytDbEntities.SaveChanges();

                        // LoadTBYTData();
                        LoadTBYTData();
                    }
                }
                else if (dataGridViewTBYTs.Columns[e.ColumnIndex].Name == "DetailLKTBYT")
                {
                    // get the row index of the cell clicked
                    var rowIndex = e.RowIndex;

                    // specify 0, if the Id is in the first Column else in place of 0 e.ColumnIndex
                    int idTBYT = Convert.ToInt32(dataGridViewTBYTs.Rows[e.RowIndex].Cells[0].Value);

                    // Create a new form
                    LKTBYTForm newLKTBYTForm = new LKTBYTForm(this.tbytDbEntities, idTBYT); // tbytDbEntities, idTBYTUpdate
                    newLKTBYTForm.ShowDialog();
                    //TBYTUpdateForm newTBYTUpdateForm = new TBYTUpdateForm(tbytDbEntities, idTBYTUpdate);
                    //MessageBox.Show("Xem Chi Tiet Linh Kien");
                }
            }
        }

        private void btnRefreshDataGridView_Click(object sender, EventArgs e)
        {
            LoadTBYTData();
        }
    }
}
