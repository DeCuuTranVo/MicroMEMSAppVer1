//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MicroMEMSApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class LKTBYT_Table
    {
        public int Id { get; set; }
        public string MaLK { get; set; }
        public string TenLK { get; set; }
        public string Dvt { get; set; }
        public int SoLuong { get; set; }
        public int IdTBYT { get; set; }
    
        public virtual TBYT_Table TBYT_Table { get; set; }
    }
}
