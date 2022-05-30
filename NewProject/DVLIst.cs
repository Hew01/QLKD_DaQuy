using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    public class DVLIst
    {
        string loaiDV, soLuong, traTruoc;
        int dgDV, dgDT, thanhTien, conLai;
        DateTime ngayGiao;

        public string LoaiDV { get => loaiDV; set => loaiDV = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public int DgDV { get => dgDV; set => dgDV = value; }
        public int DgDT { get => dgDT; set => dgDT = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string TraTruoc { get => traTruoc; set => traTruoc = value; }
        public int ConLai { get => conLai; set => conLai = value; }
        public DateTime NgayGiao { get => ngayGiao; set => ngayGiao = value; }
        public DVLIst(string l = "", int dgdv = 0, int dgdt = 0, string sl = "", int tt = 0, string trt = "", int cl = 0, DateTime ng = new DateTime())
        {
            loaiDV = l;
            dgDV = dgdv;
            dgDT = dgdt;
            soLuong = sl;
            thanhTien = tt;
            traTruoc = trt;
            conLai = cl;
            ngayGiao = ng;
        }
        public bool IsValid()
        {
            if ((string.IsNullOrEmpty(LoaiDV))
                || (string.IsNullOrEmpty(SoLuong))
                || (string.IsNullOrEmpty(TraTruoc)))
                return false;
            else return true;
        }
    }
}
