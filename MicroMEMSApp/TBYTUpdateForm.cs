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
    public partial class TBYTUpdateForm : Form
    {
        private readonly TBYTDbEntities tbytDbEntities;
        private readonly int IdTBYTUpdate;
        private TBYT_Table tbytUpdate;

        public TBYTUpdateForm(TBYTDbEntities tbytDbEntities, int idTBYTUpdate)
        {
            InitializeComponent();
            this.tbytDbEntities = tbytDbEntities;
            this.IdTBYTUpdate = idTBYTUpdate;
            this.tbytUpdate = this.tbytDbEntities.TBYT_Table.Find(this.IdTBYTUpdate);
        }

        private void TBYTUpdateForm_Load(object sender, EventArgs e)
        {
            // Get TBYT record from id     
            this.textBoxNhomTB.Text = tbytUpdate.NhomTB.ToString();
            this.textBoxLoaiTB.Text = tbytUpdate.LoaiTB.ToString();
            this.textBoxMaTB.Text = tbytUpdate.MaTB.ToString();
            this.textBoxTenTB.Text = tbytUpdate.TenTB.ToString();
            this.textBoxDvt.Text = tbytUpdate.Dvt.ToString();
            this.textBoxHangSX.Text = tbytUpdate.HangSX.ToString();
            this.textBoxNuocSX.Text = tbytUpdate.NuocSX.ToString();
            this.textBoxNamSX.Text = tbytUpdate.NamSX.ToString();
            this.textBoxGiaTri.Text = tbytUpdate.GiaTri.ToString();
            this.textBoxSoLanBaoTriMotNam.Text = tbytUpdate.SoLanBaoTriMotNam.ToString();
        }

        private void btnSubmitUpdateTBYT_Click(object sender, EventArgs e)
        {
            this.tbytUpdate.NhomTB = this.textBoxNhomTB.Text;
            this.tbytUpdate.LoaiTB = this.textBoxLoaiTB.Text;
            this.tbytUpdate.MaTB = this.textBoxMaTB.Text;
            this.tbytUpdate.TenTB = this.textBoxTenTB.Text;

            this.tbytUpdate.Dvt = this.textBoxDvt.Text;
            this.tbytUpdate.HangSX = this.textBoxHangSX.Text;
            this.tbytUpdate.NuocSX = this.textBoxNuocSX.Text;

            if (Int32.TryParse(this.textBoxNamSX.Text, out int intNamSX))
            {
                this.tbytUpdate.NamSX = intNamSX;
            }
            else
            {
                MessageBox.Show($"Int32.TryParse could not parse '{this.textBoxNamSX.Text}' to an int.");
            }

            if (Int32.TryParse(this.textBoxGiaTri.Text, out int intGiaTri))
            {
                this.tbytUpdate.GiaTri = intGiaTri;
            }
            else
            {
                MessageBox.Show($"Int32.TryParse could not parse '{this.textBoxGiaTri.Text}' to an int.");
            }

            if (Int32.TryParse(this.textBoxSoLanBaoTriMotNam.Text, out int intSoLanBaoTriMotNam))
            {
                this.tbytUpdate.SoLanBaoTriMotNam = intSoLanBaoTriMotNam;
            }
            else
            {
                MessageBox.Show($"Int32.TryParse could not parse '{this.textBoxSoLanBaoTriMotNam.Text}' to an int.");
            }

            // Save changes to database
            tbytDbEntities.SaveChanges();
            this.Close();
        }

        private void TBYTUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
