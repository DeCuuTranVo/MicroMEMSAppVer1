using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroMEMSApp.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Xml.Linq;

    [Table("TBYT_LK")]
    public partial class TBYT_LK
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Ma Linh Kien")]
        public string MaLK { get; set; }

        [Display(Name = "Ten Linh Kien")]
        public string TenLK { get; set; }

        [Display(Name = "Don vi tinh")]
        public string Dvt { get; set; }

        [Display(Name = "So Luong")]
        public int SoLuong { get; set; }

        public int IdTBYT { get; set; }

        public virtual TBYT TBYT { get; set; }
    }
}
