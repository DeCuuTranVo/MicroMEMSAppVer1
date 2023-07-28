using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroMEMSApp
{
    public partial class MainCreateUpdateLKTBYTForm : Form
    {
        private bool isEditMode;
        private readonly TBYTDbEntities _tbytDbEntities;
        private readonly MainLKTBYTForm _mainLKTBYTForm;
        public MainCreateUpdateLKTBYTForm(TBYTDbEntities tbytDbEntities, MainLKTBYTForm mainLKTBYTForm)
        {
            InitializeComponent();
            this._tbytDbEntities = tbytDbEntities;
            this._mainLKTBYTForm = mainLKTBYTForm;
            this.isEditMode = false;
            labelTitleMainCreateUpdateLKTBYTForm.Text = "Them Linh Kien Thiet Bi Y Te";
            this.Text = "Them Linh Kien Thiet Bi Y Te";
        }

        public MainCreateUpdateLKTBYTForm(TBYTDbEntities tbytDbEntities, LKTBYT_Table lktbytToUpdate, MainLKTBYTForm mainLKTBYTForm)
        {
            InitializeComponent();
            this._tbytDbEntities = tbytDbEntities;
            this._mainLKTBYTForm = mainLKTBYTForm;
            labelTitleMainCreateUpdateLKTBYTForm.Text = "Sua Linh Kien Thiet Bi Y Te";
            this.Text = "Sua Linh Kien Thiet Bi Y Te";

            if (lktbytToUpdate == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                PopulateFields(lktbytToUpdate);
            }
        }

        private void PopulateFields(LKTBYT_Table lktbytToUpdate)
        {
            labelId.Text = lktbytToUpdate.Id.ToString();
            textBoxMaLK.Text = lktbytToUpdate.MaLK;
            textBoxTenLK.Text = lktbytToUpdate.TenLK;
            textBoxDvt.Text = lktbytToUpdate.Dvt;
            textBoxSoLuong.Text = lktbytToUpdate.SoLuong.ToString();
            //comboBoxTenTB.SelectedValue = lktbytToUpdate.IdTBYT; ???
            //comboBoxTenTB.SelectedItem = lktbytToUpdate.TBYT_Table; ???
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(textBoxMaLK.Text) || string.IsNullOrWhiteSpace(textBoxTenLK.Text)
                    || string.IsNullOrWhiteSpace(textBoxDvt.Text) || string.IsNullOrWhiteSpace(textBoxSoLuong.Text)
                    || string.IsNullOrWhiteSpace(comboBoxTenTB.Text))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter missing data.\n\r";
                    // MessageBox.Show("Please enter missing data.");
                }

                bool convertState = int.TryParse(textBoxSoLuong.Text, out _);
                if (!convertState)
                {
                    isValid = false;
                    errorMessage += "Error: Please enter a number into So Luong field.\n\r";
                }

                string maLK = textBoxMaLK.Text;
                string tenLk = textBoxTenLK.Text;
                string dvt = textBoxDvt.Text;
                int soLuong = Convert.ToInt32(textBoxSoLuong.Text);
                string tenTB = comboBoxTenTB.Text;

                if (isValid == true)
                {
                    var newLKTBYT = new LKTBYT_Table();
                    newLKTBYT.MaLK = maLK;
                    newLKTBYT.TenLK = tenLk;
                    newLKTBYT.Dvt = dvt;
                    newLKTBYT.SoLuong = soLuong;
                    newLKTBYT.IdTBYT = (int)comboBoxTenTB.SelectedValue;

                    _tbytDbEntities.LKTBYT_Table.Add(newLKTBYT);
                    _tbytDbEntities.SaveChanges();

                    MessageBox.Show($"Ma Linh Kien: {maLK}\n\r" +
                                $"Ten Linh Kien: {tenLk}\n\r" +
                                $"Don vi tinh: {dvt}\n\r" +
                                $"So Luong: {soLuong}\n\r" +
                                $"Ten Thiet Bi: {tenTB}\n\r" +
                                $"Them Thiet Bi Thanh Cong");

                    _mainLKTBYTForm.PopulateGrid();
                    Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainCreateUpdateLKTBYTForm_Load(object sender, EventArgs e)
        {
            var lktbyts = _tbytDbEntities.TBYT_Table
                .Select(q => new { Id = q.Id, TenTB = q.TenTB + " - " + q.MaTB})
                .ToList();

            comboBoxTenTB.DisplayMember = "TenTB";
            comboBoxTenTB.ValueMember = "Id";
            comboBoxTenTB.DataSource = lktbyts;
        }
    }
}
