using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace TisaSoft.Entities
{
    [Table(Global.tblLoaiTB)]
    public class LoaiTB
    {
        [Key]
        public int idltb { get; set; }

        public int idntb { get; set; } = 0;
        [ForeignKey("idntb")]
        public virtual NhomTB nhomtb { get; set; }

        [MaxLength(250), Required(ErrorMessage = "Bạn phải nhập Tên loại thiết bị !")]
        [Index(nameof(ten), IsUnique = true)]
        public string ten { get; set; }

        [MaxLength(20)]
        public string dvt { get; set; } = "Cái";

        [MaxLength(50)]
        public string hangsx { get; set; } = string.Empty;

        [MaxLength(50)]
        public string model { get; set; } = string.Empty;

        public int idkp { get; set; } = 0;

        public string usercreate { get; set; } = string.Empty;
        public DateTime datecreate { get; set; } = DateTime.Now;
        public bool isactive { get; set; } = true;
    }

}
*/