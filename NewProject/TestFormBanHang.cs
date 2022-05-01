using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProject
{
    public partial class TestFormBanHang : Form
    {
        DB_QLKDEntities db = new DB_QLKDEntities();
        public TestFormBanHang()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var result = from c in db.CT_PBH
                         join e in db.PHIEUBANHANGs on c.MaPBH equals e.MaPBH
                         join t in db.SANPHAMs on c.MaSP equals t.MaSP
                         join k in db.LOAISPs on t.MaLoaiSP equals k.MaLoaiSP
                         join q in db.DONVITINHs on k.MaDVT equals q.MaDVT
                         select new
                         {
                             MaPBH = c.MaPBH,
                             LoaiSP = k.MaLoaiSP,
                             SanPham = t.TenSP,
                             SoLuong = c.SoLuong,
                             DonViTinh = q.LoaiDVT,
                             DonGia = c.DonGiaBan,
                             ThanhTien = c.ThanhTien
                         };

            //var result = from sp in db.SANPHAMs
            //             join lsp in db.LOAISPs on sp.MaLoaiSP equals lsp.MaLoaiSP
            //             select new
            //             {
            //                 MaSanPham=sp.MaSP,
            //                 MaLoaiSanPham=lsp.MaLoaiSP,
            //                 TenSanPham=sp.TenSP,
            //                 DonViTinh=lsp.MaDVT
            //             };

            dataGridViewTest.DataSource= result.ToList();
        }
    }
}
