//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            this.BAOCAOTONs = new HashSet<BAOCAOTON>();
            this.CT_PMH = new HashSet<CT_PMH>();
        }
    
        public int MaSP { get; set; }
        public int MaLoaiSP { get; set; }
        public Nullable<long> DonGiaBan { get; set; }
        public Nullable<long> DonGiaMuaVao { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
        public string TenSP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAOCAOTON> BAOCAOTONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PMH> CT_PMH { get; set; }
        public virtual LOAISP LOAISP { get; set; }
    }
}