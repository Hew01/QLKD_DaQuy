using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace NewProject
{
    public class CT_PhieuBanHang
    {
        //public int Mã_Phiếu_Bán_Hàng { get; set; }
        public string Sản_Phẩm { get; set; }
        public int Mã_Loại_Sản_Phẩm { get; set; }
        
        public int Số_Lượng { get; set; }
        public string Đơn_Vị_Tính { get; set; }
        public long Đơn_Giá { get; set; }
        public long Thành_Tiền { get; set; }

    }

    public class CT_PhieuMuaHang
    {
        
        public string Sản_Phẩm { get; set; }
        public int Loại_Sản_Phẩm { get; set; }
        public string Nhà_Cung_Cấp { get; set; }
        public int Số_Lượng { get; set; }
        public string Đơn_Vị_Tính { get; set; }
        public long Đơn_Giá { get; set; }
        public long Thành_Tiền { get; set; }
    }
    public class DB_QLKD
    {
        //FormBanHang
        public static void AddCT_PBH(string maPBH, int maSP, int soluong, int donGiaBan, string ngaylapphieu)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                int thanhTien = soluong * donGiaBan;
                if (db.PHIEUBANHANGs.Find(Convert.ToInt32(maPBH)) == null)
                {
                    PHIEUBANHANG pbh = new PHIEUBANHANG
                    {
                        MaPBH = Convert.ToInt32(maPBH),
                        NgayLapPBH = Convert.ToDateTime(ngaylapphieu),
                        TongTien = thanhTien,
                    };
                    db.PHIEUBANHANGs.Add(pbh);
                    CT_PBH ctpbh = new CT_PBH
                    {
                        MaPBH = Convert.ToInt32(maPBH),
                        MaSP = maSP,
                        SoLuong = soluong,
                        DonGiaBan = donGiaBan,
                        ThanhTien = thanhTien,
                    };
                    db.CT_PBH.Add(ctpbh);
                }
                else
                {
                    int mapbh = Convert.ToInt32(maPBH);
                    PHIEUBANHANG p = db.PHIEUBANHANGs.Where(c => c.MaPBH == mapbh).First();

                    CT_PBH ctpbh = new CT_PBH
                    {
                        MaPBH = mapbh,
                        MaSP = maSP,
                        SoLuong = soluong,
                        DonGiaBan = donGiaBan,
                        ThanhTien = thanhTien,
                    };
                    p.TongTien += thanhTien;
                    db.CT_PBH.Add(ctpbh);
                }
                    //SAVE CHANGES
                db.SaveChanges();
            }
        }

        public static void Delete_CTPBH(int maPBH, int maSP)
        {
            using(DB_QLKDEntities db =new DB_QLKDEntities())
            {
                PHIEUBANHANG p = db.PHIEUBANHANGs.Where(c => c.MaPBH == maPBH).First();
                CT_PBH ct = db.CT_PBH.Where(c => c.MaPBH == maPBH && c.MaSP == maSP).First();
                p.TongTien -= ct.ThanhTien;
                db.CT_PBH.Remove(ct);

                //db.PHIEUBANHANGs.Remove(db.PHIEUBANHANGs.Where(c => c.MaPBH == maPBH).First());
                db.SaveChanges();
            }
        }

        public static void Edit_CTPBH(int maPBH, int maSP, int soluong, long donGiaBan, long thanhTien)
        {
            using (DB_QLKDEntities db= new DB_QLKDEntities())
            {
                CT_PBH ctPBH = db.CT_PBH.Where(c => c.MaPBH == maPBH && c.MaSP == maSP).First();
                PHIEUBANHANG pbh = db.PHIEUBANHANGs.Where(c => c.MaPBH == maPBH).First();
                ctPBH.SoLuong = soluong;
                ctPBH.DonGiaBan = donGiaBan;
                pbh.TongTien -= ctPBH.ThanhTien;
                ctPBH.ThanhTien = thanhTien;
                pbh.TongTien += thanhTien;

                db.SaveChanges();
            }
        }

        //FormMuaHang
        public static void addCT_PMH(int maPMH, int maSP, int soLuongMua, int donGiaMua, int thanhTien, DateTime ngayLapPhieu, int NhaCungCap)
        {
            using(DB_QLKDEntities db =new DB_QLKDEntities())
            {
                if (db.PHIEUMUAHANGs.Find(maPMH) == null)
                {
                    PHIEUMUAHANG pmh = new PHIEUMUAHANG
                    {
                        MaPMH = maPMH,
                        NgLapPMH = ngayLapPhieu,
                        MaNCC = NhaCungCap
                    };
                    db.PHIEUMUAHANGs.Add(pmh);
                }
                    CT_PMH ctPMH = new CT_PMH
                    {
                        MaPMH = maPMH,
                        MaSP = maSP,
                        SoLuongMuaVao = soLuongMua,
                        DonGiaMuaVao = donGiaMua,
                        ThanhTien = thanhTien
                    };
                    db.CT_PMH.Add(ctPMH);
                

                db.SaveChanges();
            }
        }

        public static void Delete_CTPMH(int maPMH,int masp)
        {
            using (DB_QLKDEntities db=new DB_QLKDEntities())
            {
                CT_PMH ctPMH = db.CT_PMH.Where(c => c.MaPMH == maPMH && c.MaSP==masp).First();
                PHIEUMUAHANG pmh = db.PHIEUMUAHANGs.Where(c => c.MaPMH == maPMH).First();
                db.CT_PMH.Remove(ctPMH);
                //db.PHIEUMUAHANGs.Remove(pmh);

                db.SaveChanges();
            }
        }

        public static void Edit_CTPMH(int maPMH, int masp, int maNCC, int soLuong, int donGia, int thanhTien)
        {
            using (DB_QLKDEntities db =new DB_QLKDEntities())
            {
                PHIEUMUAHANG pmh = db.PHIEUMUAHANGs.Where(c => c.MaPMH == maPMH).First();
                CT_PMH ctPMH = db.CT_PMH.Where(c => c.MaPMH == maPMH).First();

                //pmh.MaPMH = maPMH;
                pmh.MaNCC = maNCC;
                //ctPMH.MaPMH = maPMH;
                ctPMH.SoLuongMuaVao = soLuong;
                ctPMH.DonGiaMuaVao = donGia;
                ctPMH.ThanhTien = thanhTien;

                db.SaveChanges();
            }
        }
    }

    
}
