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
        public int Mã_Phiếu_Bán_Hàng { get; set; }
        public int Mã_Loại_Sản_Phẩm { get; set; }
        public string Sản_Phẩm { get; set; }
        public int Số_Lượng { get; set; }
        public string Đơn_Vị_Tính { get; set; }
        public long Đơn_Giá { get; set; }
        public long Thành_Tiền { get; set; }

    }
    public class DB_QLKD
    {

        public static void AddCT_PBH(string maPBH, int maSP, int soluong, int donGiaBan, string ngaylapphieu)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                int thanhTien = soluong * donGiaBan;

                //ADD TO PBH TABLE
                PHIEUBANHANG pbh = new PHIEUBANHANG
                {
                    MaPBH = Convert.ToInt32(maPBH),
                    NgayLapPBH = Convert.ToDateTime(ngaylapphieu),
                    TongTien = thanhTien,

                };
                db.PHIEUBANHANGs.Add(pbh);

                //ADD TO CT_PBH TABLE
                CT_PBH ctpbh = new CT_PBH
                {
                    MaPBH = Convert.ToInt32(maPBH),
                    MaSP = maSP,
                    SoLuong = soluong,
                    DonGiaBan = donGiaBan,
                    ThanhTien = thanhTien,
                };
                db.CT_PBH.Add(ctpbh);

                //SAVE CHANGES
                db.SaveChanges();
            }
        }

        public static void Delete_CTPBH(int maPBH)
        {
            using(DB_QLKDEntities db =new DB_QLKDEntities())
            {
                db.CT_PBH.Remove(db.CT_PBH.Where(c => c.MaPBH == maPBH).First());
                db.PHIEUBANHANGs.Remove(db.PHIEUBANHANGs.Where(c => c.MaPBH == maPBH).First());
                db.SaveChanges();
            }
        }

        public static void Edit_CTPBH(int maPBH, int maSP, int soluong, long donGiaBan, long thanhTien)
        {
            using (DB_QLKDEntities db= new DB_QLKDEntities())
            {
                CT_PBH ctPBH = db.CT_PBH.Where(c => c.MaPBH == maPBH).First();
                PHIEUBANHANG pbh = db.PHIEUBANHANGs.Where(c => c.MaPBH == maPBH).First();

                ctPBH.MaSP = maSP;
                ctPBH.SoLuong = soluong;
                ctPBH.DonGiaBan = donGiaBan;
                ctPBH.ThanhTien = thanhTien;
                pbh.TongTien = thanhTien;

                db.SaveChanges();
            }
        }
    }

    
}
