
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
    
public partial class LOAISP
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public LOAISP()
    {

        this.SANPHAMs = new HashSet<SANPHAM>();

    }


    public int MaLoaiSP { get; set; }

    public int MaDVT { get; set; }

    public Nullable<int> PhanTramLoiNhuan { get; set; }



    public virtual DONVITINH DONVITINH { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<SANPHAM> SANPHAMs { get; set; }

}

}
