using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroMEMSApp.Data
{
    // Data object for TBYT: Thiet Bi Y Te
    /*
        NhomTB (Nhom thiet bi)
		LoaiTB (Loai thiet bi)
		MaTB_GUID (Ma thiet bi)
		TenTB (Ten thiet bi)
		Dvt (Don vi tinh)
		HangSX (Hang san xuat)
		NuocSX (Nuoc san xuat)
		NamSX (Nam san xuat)
		GiaTri (Gia Tri)
		SoLanBaoTriMotNam (So lan bao tri mot nam)
     */
    public class TBYT
    {
		public int IdTB { get; set; }
        public string NhomTB { get; set; }
		public string LoaiTB { get; set; }
		public string MaTB { get; set; } //GUID
		public string TenTB {get; set; }
		public string Dvt {get; set; }
		public string HangSX { get; set; }
		public string NuocSX { get; set; }
		public int NamSX {get; set; }
		public int	GiaTri { get; set; }
		public int SoLanBaoTriMotNam { get; set; }
    }
}
