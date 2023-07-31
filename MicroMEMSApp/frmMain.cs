using MicroMEMSApp.Forms;
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
    public partial class frmMain : Form
    {
        private readonly TBYTDbEntities tbytDbEntities;
        public frmMain()
        {
            InitializeComponent();
            tbytDbEntities = new TBYTDbEntities();
        }

        private void quanLiThietBiYTeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "frmTBYT");
            if (!isOpen)
            {
                frmTBYT newFrmTBYT = new frmTBYT();
                newFrmTBYT.MdiParent = this;
                newFrmTBYT.Show();
            }
        }

        private void quanLiLinhKienThietBiYTeToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "MainLKTBYTForm");
            if (!isOpen)
            {
                MainLKTBYTForm newMainLKTBYTForm = new MainLKTBYTForm(tbytDbEntities);
                newMainLKTBYTForm.MdiParent = this;
                newMainLKTBYTForm.Show();
            } 
            
        }
    }
}
