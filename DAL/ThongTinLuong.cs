//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThongTinLuong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinLuong()
        {
            this.BaoHiems = new HashSet<BaoHiem>();
        }
    
        public string MA_LUONG { get; set; }
        public string MA_NV { get; set; }
        public double HS_LUONG { get; set; }
        public double LUONG_CB { get; set; }
        public Nullable<double> PC_CV { get; set; }
        public Nullable<double> PC_AT { get; set; }
        public Nullable<double> PC_DL { get; set; }
        public Nullable<double> PC_CC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoHiem> BaoHiems { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}