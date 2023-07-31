using MicroMEMSApp.Entities;
using MicroMEMSApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroMEMSApp.Forms
{
    public partial class frmTBYT : Form
    {
        private List<TBYT> lst = new List<TBYT>();
        private TBYT_Service service = new TBYT_Service();
        public frmTBYT()
        {
            InitializeComponent();
            Load += FrmTBYT_Load;
            grd.KeyDown += Grd_KeyDown;
            grd.CellDoubleClick += Grd_CellDoubleClick;
        }

        private void Grd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int  nId = (int) grd.Rows[e.RowIndex].Cells[0].Value;
            service.Delete(nId);
        }

        private void Grd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete | e.Control)
            {
                
            }
        }

        private void FrmTBYT_Load(object sender, EventArgs e)
        {
            lst = service.GetAll();
            grd.AutoGenerateColumns = true;
            grd.DataSource = lst;
        }

        
    }
}
