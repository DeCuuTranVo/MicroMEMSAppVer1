using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroMEMSApp.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LKTBYT_Table")]
    public partial class TBYT_LK
    {
        public int Id { get; set; }
        public string MaLK { get; set; }
        public string TenLK { get; set; }
        public string Dvt { get; set; }
        public int SoLuong { get; set; }
        public int IdTBYT { get; set; }

        public virtual TBYT TBYT { get; set; }
    }
}
