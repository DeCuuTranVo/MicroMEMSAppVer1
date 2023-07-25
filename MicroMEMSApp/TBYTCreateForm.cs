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
    public partial class TBYTCreateForm : Form
    {
        private readonly TBYTDbEntities tbytDbEntities;
        public TBYTCreateForm(TBYTDbEntities tbytDbEntities)
        {
            InitializeComponent();
            this.tbytDbEntities = tbytDbEntities;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitCreateTBYT_Click(object sender, EventArgs e)
        {
            string nhomTB = textBoxNhomTB.Text;
            string loaiTB = textBoxLoaiTB.Text;
            string maTB = textBoxMaTB.Text;
            string tenTB = textBoxTenTB.Text;

            string dvt = textBoxDvt.Text;
            string hangSX = textBoxHangSX.Text;
            string nuocSX = textBoxNuocSX.Text;
            string namSX = textBoxNamSX.Text;

            string giaTri = textBoxGiaTri.Text;
            string soLanBaoTriMotNam = textBoxSoLanBaoTriMotNam.Text;

            TBYT_Table newTBYT = new TBYT_Table();
            newTBYT.NhomTB = nhomTB;
            newTBYT.LoaiTB = loaiTB;
            newTBYT.MaTB = maTB;
            newTBYT.TenTB = tenTB;

            newTBYT.Dvt = dvt;
            newTBYT.HangSX = hangSX;
            newTBYT.NuocSX = nuocSX;

            if (Int32.TryParse(namSX, out int intNamSX))
            {
                newTBYT.NamSX = intNamSX;
            }
            else
            {
                MessageBox.Show($"Int32.TryParse could not parse '{namSX}' to an int.");
            }

            if (Int32.TryParse(giaTri, out int intGiaTri))
            {
                newTBYT.GiaTri = intGiaTri;
            }
            else
            {
                MessageBox.Show($"Int32.TryParse could not parse '{giaTri}' to an int.");
            }

            if (Int32.TryParse(soLanBaoTriMotNam, out int intSoLanBaoTriMotNam))
            {
                newTBYT.SoLanBaoTriMotNam = intSoLanBaoTriMotNam;
            }
            else
            {
                MessageBox.Show($"Int32.TryParse could not parse '{soLanBaoTriMotNam}' to an int.");
            }

            // Save record to database
            tbytDbEntities.TBYT_Table.Add(newTBYT);
            tbytDbEntities.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();

            //MessageBox.Show(newTBYT.NhomTB + " " + newTBYT.LoaiTB + " " + newTBYT.MaTB
            //    + " " + newTBYT.Dvt + " " + newTBYT.HangSX + " " + newTBYT.NuocSX
            //    + " " + newTBYT.NamSX + " " + newTBYT.GiaTri + " " + newTBYT.SoLanBaoTriMotNam);
        }

        private void labelNamSX_Click(object sender, EventArgs e)
        {

        }

        private void TBYTCreateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            /*
            DialogResult dr = MessageBox.Show("Form Close Confirmation?", "Form Close Title", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            } 
            */
        }
    }
}
