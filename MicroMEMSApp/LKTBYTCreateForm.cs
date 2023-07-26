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
    public partial class LKTBYTCreateForm : Form
    {
        private readonly TBYTDbEntities tbytDbEntities;
        private readonly int idTBYTParent;
        private TBYT_Table tbytParent;
        public LKTBYTCreateForm(TBYTDbEntities tbytDbEntities, int idTBYTParent)
        {
            InitializeComponent();
            this.tbytDbEntities = tbytDbEntities;
            this.idTBYTParent = idTBYTParent;
            this.tbytParent = this.tbytDbEntities.TBYT_Table.Find(this.idTBYTParent);
        }

        private void LKTBYTCreateForm_Load(object sender, EventArgs e)
        {
            this.textBoxTBYTParent.Text = tbytParent.TenTB;
        }

        private void btnSubmitCreateLKTBYT_Click(object sender, EventArgs e)
        {
            string maLK = textBoxMaLK.Text;
            string tenLK = textBoxTenLK.Text;
            string dvt = textBoxDvt.Text;
            string soLuong = textBoxSoLuong.Text;

            LKTBYT_Table newLKTBYT = new LKTBYT_Table();
            newLKTBYT.MaLK = maLK;
            newLKTBYT.TenLK = tenLK;
            newLKTBYT.Dvt = dvt;

            if (Int32.TryParse(soLuong, out int intSoLuong))
            {
                newLKTBYT.SoLuong = intSoLuong;
            }
            else
            {
                MessageBox.Show($"Int32.TryParse could not parse '{soLuong}' to an int.");
            }

            newLKTBYT.IdTBYT = this.idTBYTParent;

            tbytDbEntities.LKTBYT_Table.Add(newLKTBYT);
            tbytDbEntities.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
