using MicroMEMSApp.Entities;
using MicroMEMSApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            // Interface
            this.Text = "Quan Li Thiet Bi Y Te";
            this.lblTitle.Text = "Quan Li Thiet Bi Y Te";
            this.lblTitle.Font = new Font("Arial", 20, FontStyle.Bold);
            this.WindowState = FormWindowState.Maximized;

            this.lblNhomTB.Text = "Nhom Thiet Bi";
            this.lblLoaiTB.Text = "Loai Thiet Bi";
            this.lblMaTB.Text = "Ma Thiet Bi";
            this.lblTenTB.Text = "Ten Thiet Bi";
            this.lblDvt.Text = "Don vi tinh";
            this.lblHangSX.Text = "Hang San Xuat";
            this.lblNuocSX.Text = "Nuoc San Xuat";
            this.lblNamSX.Text = "Nam San Xuat";
            this.lblGiaTri.Text = "Gia Tri";
            this.lblSoLanBaoTriMotNam.Text = "So Lan Bao Tri Mot Nam";           

            // Events
            this.Load += FrmTBYT_Load;
            this.grd.CellClick += Grd_CellClick;
            this.btnClear.Click += BtnClear_Click;
            this.btnCreate.Click += BtnCreate_Click;
            this.btnUpdate.Click += BtnUpdate_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnSearch.Click += BtnSearch_Click;
            this.btnClearSearch.Click += BtnClearSearch_Click;
        }

        private void BtnClearSearch_Click(object sender, EventArgs e)
        {
            this.tbxSearch.Text = "";
            PopulateGrid();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string tenTB = tbxSearch.Text;
            List<TBYT> searchList = service.Search(tenTB);
            //MessageBox.Show(searchList.Count.ToString());
            PopulateGrid(searchList);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int index = grd.CurrentCell.RowIndex;
                var id = (int)grd.Rows[index].Cells["Id"].Value;

                TBYT tbytToUpdate = new TBYT();

                tbytToUpdate.Id = id;
                tbytToUpdate.NhomTB = tbxNhomTB.Text;
                tbytToUpdate.LoaiTB = tbxLoaiTB.Text;
                tbytToUpdate.MaTB = tbxMaTB.Text;
                tbytToUpdate.TenTB = tbxTenTB.Text;
                tbytToUpdate.Dvt = tbxDvt.Text;

                tbytToUpdate.HangSX = tbxHangSX.Text;
                tbytToUpdate.NuocSX = tbxNuocSX.Text;
                tbytToUpdate.NamSX = Convert.ToInt32(tbxNamSX.Text);
                tbytToUpdate.GiaTri = Convert.ToInt32(tbxGiaTri.Text);
                tbytToUpdate.SoLanBaoTriMotNam = Convert.ToInt32(tbxSoLanBaoTriMotNam.Text);

                service.Update(tbytToUpdate);

                PopulateGrid();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = grd.CurrentCell.RowIndex;
                var id = (int)grd.Rows[index].Cells["Id"].Value;

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?",
                        "Delete",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    service.Delete(id);
                }
                PopulateGrid();
                ClearTextBoxes();
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                TBYT newTBYT = new TBYT();
                newTBYT.NhomTB = tbxNhomTB.Text;
                newTBYT.LoaiTB = tbxLoaiTB.Text;
                newTBYT.MaTB = tbxMaTB.Text;
                newTBYT.TenTB = tbxTenTB.Text;
                newTBYT.Dvt = tbxDvt.Text;
                newTBYT.HangSX = tbxHangSX.Text;
                newTBYT.NuocSX = tbxNuocSX.Text;
                newTBYT.NamSX = Convert.ToInt32(tbxNamSX.Text);
                newTBYT.GiaTri = Convert.ToInt32(tbxGiaTri.Text);
                newTBYT.SoLanBaoTriMotNam = Convert.ToInt32(tbxSoLanBaoTriMotNam.Text);

                service.AddNew(newTBYT);
                PopulateGrid();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        public void PopulateGrid()
        {
            var lst = service.GetAll();

            var displayList = lst.Select(
                x => new {
                    x.Id,
                    x.NhomTB,
                    x.LoaiTB,
                    x.MaTB,
                    x.TenTB,
                    x.Dvt,
                    x.HangSX,
                    x.NuocSX,
                    x.NamSX,
                    x.GiaTri,
                    x.SoLanBaoTriMotNam
                }).ToList();


            grd.AutoGenerateColumns = true;
            //grd.DataSource = lst;
            grd.DataSource = displayList;

            grd.Columns["NhomTB"].HeaderText = "Nhom Thiet Bi";
            grd.Columns["LoaiTB"].HeaderText = "Loai Thiet Bi";
            grd.Columns["MaTB"].HeaderText = "Ma Thiet Bi";
            grd.Columns["TenTB"].HeaderText = "Ten Thiet Bi";
            grd.Columns["Dvt"].HeaderText = "Đơn vị tính";
            grd.Columns["HangSX"].HeaderText = "Hãng Sản Xuất";
            grd.Columns["NuocSX"].HeaderText = "Nước Sản Xuất";
            grd.Columns["NamSX"].HeaderText = "Năm Sản Xuất";
            grd.Columns["GiaTri"].HeaderText = "Giá Trị";
            grd.Columns["SoLanBaoTriMotNam"].HeaderText = "Số Lần Bảo Trì Một Năm";

            grd.Columns["Id"].Visible = false;
            grd.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            grd.DefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Regular);

            grd.Columns["SoLanBaoTriMotNam"].Width = 150;
        }

        public void PopulateGrid(List<TBYT> tbytList)
        {
            var displayList = tbytList.Select(
                x => new {
                    x.Id,
                    x.NhomTB,
                    x.LoaiTB,
                    x.MaTB,
                    x.TenTB,
                    x.Dvt,
                    x.HangSX,
                    x.NuocSX,
                    x.NamSX,
                    x.GiaTri,
                    x.SoLanBaoTriMotNam
                }).ToList();


            grd.AutoGenerateColumns = true;
            //grd.DataSource = lst;
            grd.DataSource = displayList;

            grd.Columns["NhomTB"].HeaderText = "Nhom Thiet Bi";
            grd.Columns["LoaiTB"].HeaderText = "Loai Thiet Bi";
            grd.Columns["MaTB"].HeaderText = "Ma Thiet Bi";
            grd.Columns["TenTB"].HeaderText = "Ten Thiet Bi";
            grd.Columns["Dvt"].HeaderText = "Đơn vị tính";
            grd.Columns["HangSX"].HeaderText = "Hãng Sản Xuất";
            grd.Columns["NuocSX"].HeaderText = "Nước Sản Xuất";
            grd.Columns["NamSX"].HeaderText = "Năm Sản Xuất";
            grd.Columns["GiaTri"].HeaderText = "Giá Trị";
            grd.Columns["SoLanBaoTriMotNam"].HeaderText = "Số Lần Bảo Trì Một Năm";

            grd.Columns["Id"].Visible = false;
            grd.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            grd.DefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Regular);

            grd.Columns["SoLanBaoTriMotNam"].Width = 150;
        }
        public void ClearTextBoxes()
        {
            tbxNhomTB.Text = "";
            tbxLoaiTB.Text = "";
            tbxMaTB.Text = "";
            tbxTenTB.Text = "";
            tbxDvt.Text = "";

            tbxHangSX.Text = "";
            tbxNuocSX.Text = "";
            tbxNamSX.Text = "";
            tbxGiaTri.Text = "";
            tbxSoLanBaoTriMotNam.Text = "";       
        }



        private void Grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int nId = (int)grd.Rows[e.RowIndex].Cells[0].Value;

            DataGridViewRow row = grd.Rows[e.RowIndex];
            tbxNhomTB.Text = row.Cells["NhomTB"].Value.ToString(); 
            tbxLoaiTB.Text = row.Cells["LoaiTB"].Value.ToString();
            tbxMaTB.Text = row.Cells["MaTB"].Value.ToString();
            tbxTenTB.Text = row.Cells["TenTB"].Value.ToString();
            tbxDvt.Text = row.Cells["Dvt"].Value.ToString();

            tbxHangSX.Text = row.Cells["HangSX"].Value.ToString();
            tbxNuocSX.Text = row.Cells["NuocSX"].Value.ToString();
            tbxNamSX.Text = row.Cells["NamSX"].Value.ToString();
            tbxGiaTri.Text = row.Cells["GiaTri"].Value.ToString();
            tbxSoLanBaoTriMotNam.Text = row.Cells["SoLanBaoTriMotNam"].Value.ToString();
        }

        private void FrmTBYT_Load(object sender, EventArgs e)
        {
            PopulateGrid();
            ClearTextBoxes();
        }
    }
}
