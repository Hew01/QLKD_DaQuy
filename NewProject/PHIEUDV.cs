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
    
    public partial class PHIEUDV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUDV()
        {
            this.CT_PDV = new HashSet<CT_PDV>();
        }
    
        public int MaPDV { get; set; }
        public Nullable<System.DateTime> NgayLapPDV { get; set; }
        public string TenKH { get; set; }
        public Nullable<int> SDTKH { get; set; }
        public Nullable<long> TongTien { get; set; }
        public Nullable<long> TongTienTraTruoc { get; set; }
        public Nullable<long> TongTienConLai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PDV> CT_PDV { get; set; }
    }
}