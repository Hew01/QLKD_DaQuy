using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    public class BHList
    {
        string loaiSP, sanPham, donViTinh, soLuong;
        int donGia, thanhTien;
        public string LoaiSP { get => loaiSP; set => loaiSP = value; }
        public string SanPham { get => sanPham; set => sanPham = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public BHList(string l = "", string s = "", string sl = "", string dvt = "", int dg = 0, int tt = 0)
        {
            loaiSP = l;
            sanPham = s;
            soLuong = sl;
            donViTinh = dvt;
            donGia = dg;
            thanhTien = tt;
        }
        public bool IsValid()
        {
            if ((string.IsNullOrEmpty(LoaiSP))
                || (string.IsNullOrEmpty(SanPham))
                || (string.IsNullOrEmpty(SoLuong)))
                return false;
            else return true;
        }
    }
}