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
    public partial class frmTBYT_LK : Form
    {
        //private List<TBYT_LK> lst = new List<TBYT_LK>();

        private TBYT_Service TBYT_service = new TBYT_Service();
        private TBYT_LK_Service TBYT_LK_service = new TBYT_LK_Service();
        public frmTBYT_LK()
        {
            InitializeComponent();

            // Interface
            this.Text = "Quản Lí Linh Kiện Thiết Bị Y Tế";
            this.lblTitle.Text = "Quản Lí Linh Kiện Thiết Bị Y Tế";
            this.lblTitle.Font = new Font("Arial", 20, FontStyle.Bold);
            this.WindowState = FormWindowState.Maximized;

            this.lblMaLK.Text = "Mã Linh Kiện";
            this.lblTenLK.Text = "Tên Linh Kiện";
            this.lblDvt.Text = "Đơn vị tính";
            this.lblSoLuong.Text = "Số Lượng";
            this.lblTB.Text = "Thiết Bị";

            var lstTBYT = TBYT_service.GetAll();
            //var lst = TBYT_LK_service.GetAll();

            var displayListTBYT = lstTBYT.Select(
                x => new {
                    Id = x.Id,
                    NameTB = x.TenTB + " " + x.MaTB
                }).ToList();

            this.cbxTB.DataSource = displayListTBYT;
            this.cbxTB.DisplayMember = "NameTB";
            this.cbxTB.SelectedIndex = -1;

            // Events
            this.Load += FrmTBYT_LK_Load;


        }

        public void PopulateGrid()
        {
            var lst = TBYT_LK_service.GetAll();

            var displayList = lst.Select(
                x => new {
                    x.Id,
                    x.MaLK,
                    x.TenLK,
                    x.Dvt,
                    x.SoLuong
                }).ToList();


            grd.AutoGenerateColumns = true;
            //grd.DataSource = lst;
            grd.DataSource = displayList;

            grd.Columns["Id"].HeaderText = "Id";
            grd.Columns["MaLK"].HeaderText = "Mã Linh Kiện";
            grd.Columns["TenLK"].HeaderText = "Tên Linh Kiện";
            grd.Columns["Dvt"].HeaderText = "Đơn vị tính";
            grd.Columns["SoLuong"].HeaderText = "Số Lượng";

            grd.Columns["Id"].Visible = false;
            grd.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            grd.DefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Regular);

            grd.Columns["TenLK"].Width = 150;
        }

        public void ClearTextBoxesAndComboBoxes()
        {
            tbxMaLK.Text = "";
            tbxTenLK.Text = "";
            tbxDvt.Text = "";
            tbxSoLuong.Text = "";
            cbxTB.SelectedValue = null;        
        }

        private void FrmTBYT_LK_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
