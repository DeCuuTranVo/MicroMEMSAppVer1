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
    public partial class LKTBYTUpdateForm : Form
    {
        private readonly TBYTDbEntities tbytDbEntities;
        private readonly int IdLKTBYTUpdate;
        private readonly int IdTBYTParent;
        private LKTBYT_Table lktbytUpdate;
        private TBYT_Table tbytParent;
        public LKTBYTUpdateForm(TBYTDbEntities tbytDbEntities, int idLKTBYTUpdate)
        {
            InitializeComponent();
            this.tbytDbEntities = tbytDbEntities;
            this.IdLKTBYTUpdate = idLKTBYTUpdate;
            this.lktbytUpdate = this.tbytDbEntities.LKTBYT_Table.Find(this.IdLKTBYTUpdate);
            this.IdTBYTParent = lktbytUpdate.IdTBYT;
            this.tbytParent = this.tbytDbEntities.TBYT_Table.Find(this.IdTBYTParent);
        }

        private void textBoxMaLK_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LKTBYTUpdateForm_Load(object sender, EventArgs e)
        {
            this.textBoxMaLK.Text = lktbytUpdate.MaLK.ToString();
            this.textBoxTenLK.Text = lktbytUpdate.TenLK.ToString();
            this.textBoxDvt.Text = lktbytUpdate.Dvt.ToString();
            this.textBoxSoLuong.Text = lktbytUpdate.SoLuong.ToString();
            this.textBoxTenTB.Text = this.tbytParent.TenTB.ToString();
        }

        private void btnSubmitUpdateLKTBYT_Click(object sender, EventArgs e)
        {
            this.lktbytUpdate.MaLK = this.textBoxMaLK.Text;
            this.lktbytUpdate.TenLK = this.textBoxTenLK.Text;
            this.lktbytUpdate.Dvt = this.textBoxDvt.Text;

            string soLuong = this.textBoxSoLuong.Text;
            if (Int32.TryParse(soLuong, out int intSoLuong))
            {
                lktbytUpdate.SoLuong = intSoLuong;
            }
            else
            {
                MessageBox.Show($"Int32.TryParse could not parse '{soLuong}' to an int.");
            }
            tbytDbEntities.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
