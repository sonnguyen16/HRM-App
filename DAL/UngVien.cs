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
    
    public partial class UngVien
    {
        public byte[] Hinh_Anh { get; set; }
        public string MA_UV { get; set; }
        public string Ho_Ten { get; set; }
        public string Gioi_Tinh { get; set; }
        public System.DateTime Ngay_Sinh { get; set; }
        public string Dia_Chi { get; set; }
        public string Dan_Toc { get; set; }
        public string So_CCCD { get; set; }
        public string So_Dt { get; set; }
        public string Email { get; set; }
        public string Hon_Nhan { get; set; }
        public string MA_CVUT { get; set; }
        public string MA_PBUT { get; set; }
    
        public virtual ChucVu ChucVu { get; set; }
        public virtual PhongBan PhongBan { get; set; }
    }
}
