using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

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
    public class PhieuDichVu
    {
        public string Loại_Dịch_Vụ { get; set; }
        public long Đơn_Giá_Dịch_Vụ { get; set; }
        public long Đơn_Giá_Được_Tính { get; set; }
        public int Số_Lượng { get; set; }
        public long Thành_Tiền { get; set; }
        public long Trả_Trước { get; set; }
        public long Còn_Lại { get; set; }
        public DateTime Ngày_Giao { get; set; }
        public string Tình_Trạng { get; set; }
    }
    public class DB_QLKD
    {
        public static string currentUser = "";
        public static int TonDau(int masp, DateTime date)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                int tondau = 0;
                int thang, nam;
                if (date.Month == 1)
                {
                    thang = 12;
                    nam = date.Year - 1;
                }
                else
                {
                    thang = date.Month - 1;
                    nam = date.Year;
                }

                if (db.BAOCAOTONs.Find(date.Month, date.Year, masp) == null)
                {
                    return 0;
                }
                else
                {
                    var a = from c in db.BAOCAOTONs
                            where c.Thang == thang && c.Nam == nam && c.MaSP == masp
                            select c.TonCuoi;
                    tondau = a.First().Value;
                    return tondau;
                }
            }
        }
        public static bool CheckSoLuong(int sl, int masp)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                var soluong = from c in db.SANPHAMs
                              where c.MaSP == masp
                              select c.SoLuongTon;
                if (sl > soluong.First().Value)
                {
                    MessageBox.Show("Không đủ số lượng trong kho", "Thông báo");
                    return false;
                }
                else return true;
            }
        }

        public static void ChangeQuantity(int sl, int masp)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                var sanpham = db.SANPHAMs.Where(c => c.MaSP == masp).First();
                sanpham.SoLuongTon += sl;
                db.SaveChanges();
            }
        }

        public static void ChangeStored_SLBanRa(int sl, int masp, DateTime date)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                if (db.BAOCAOTONs.Find(date.Month, date.Year, masp) == null)
                {
                    var dvt = from c in db.LOAISPs
                              join d in db.SANPHAMs on c.MaLoaiSP equals d.MaLoaiSP
                              where d.MaSP == masp
                              select c.MaDVT;
                    int madvt = Convert.ToInt32(dvt.First().ToString());
                    BAOCAOTON a = new BAOCAOTON
                    {
                        Thang = date.Month,
                        Nam = date.Year,
                        SLBanRa = sl,
                        SLMuaVao = 0,
                        MaSP = masp,
                        MaDVT = madvt,
                        TonDau = TonDau(masp, date)
                    };
                    db.BAOCAOTONs.Add(a);
                }
                else
                {
                    var bc = db.BAOCAOTONs.Where(c => c.MaSP == masp && c.Thang == date.Month && c.Nam == date.Year).First();
                    bc.SLBanRa += sl;
                }
                db.SaveChanges();
            }
        }

        public static void ChangeStored_SLMuaVao(int sl, int masp, DateTime date)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                if (db.BAOCAOTONs.Find(date.Month, date.Year, masp) == null)
                {
                    var dvt = from c in db.LOAISPs
                              join d in db.SANPHAMs on c.MaLoaiSP equals d.MaLoaiSP
                              where d.MaSP == masp
                              select c.MaDVT;
                    int madvt = Convert.ToInt32(dvt.First().ToString());
                    BAOCAOTON a = new BAOCAOTON
                    {
                        Thang = date.Month,
                        Nam = date.Year,
                        SLMuaVao = sl,
                        SLBanRa = 0,
                        MaSP = masp,
                        MaDVT = madvt,
                        TonDau = TonDau(masp, date)
                    };
                    db.BAOCAOTONs.Add(a);
                }
                else
                {
                    var bc = db.BAOCAOTONs.Where(c => c.MaSP == masp && c.Thang == date.Month && c.Nam == date.Year).First();
                    bc.SLMuaVao += sl;
                }
                db.SaveChanges();
            }
        }

        public static void AutoGenerate_BaoCaoTon(DateTime date)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                var masp = from c in db.SANPHAMs
                           select c.MaSP;
                foreach (var i in masp)
                {
                    if (db.BAOCAOTONs.Find(date.Month, date.Year, i) == null)
                    {
                        var dvt = from c in db.LOAISPs
                                  join d in db.SANPHAMs on c.MaLoaiSP equals d.MaLoaiSP
                                  where d.MaSP == i
                                  select c.MaDVT;
                        int madvt = Convert.ToInt32(dvt.First().ToString());
                        BAOCAOTON a = new BAOCAOTON
                        {
                            Thang = date.Month,
                            Nam = date.Year,
                            SLMuaVao = 0,
                            SLBanRa = 0,
                            MaSP = i,
                            MaDVT = madvt,
                            TonDau = TonDau(i, date),
                        };
                        if (TonDau(i, date) == 0) a.TonCuoi = 0;
                        db.BAOCAOTONs.Add(a);
                    }
                }
                db.SaveChanges();
            }
        }
        //FormBanHang
        public static void AddCT_PBH(string maPBH, int maSP, int soluong, int donGiaBan, DateTime ngaylapphieu)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                if (!CheckSoLuong(soluong, maSP)) return;
                int thanhTien = soluong * donGiaBan;
                if (db.PHIEUBANHANGs.Find(Convert.ToInt32(maPBH)) == null)
                {
                    PHIEUBANHANG pbh = new PHIEUBANHANG
                    {
                        MaPBH = Convert.ToInt32(maPBH),
                        NgayLapPBH = ngaylapphieu,
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
                //Thay đổi số lượng trong kho và báo cáo tồn
                ChangeQuantity(-soluong, maSP);
                ChangeStored_SLBanRa(soluong, maSP, ngaylapphieu);

                    //SAVE CHANGES
                db.SaveChanges();
                MessageBox.Show("Thêm thành công", "Thông Báo");
            }
        }

        public static void Delete_CTPBH(int maPBH, int maSP)
        {
            using(DB_QLKDEntities db =new DB_QLKDEntities())
            {
                PHIEUBANHANG p = db.PHIEUBANHANGs.Where(c => c.MaPBH == maPBH).First();
                CT_PBH ct = db.CT_PBH.Where(c => c.MaPBH == maPBH && c.MaSP == maSP).First();
                p.TongTien -= ct.ThanhTien;

                ChangeQuantity(ct.SoLuong.Value, maSP);
                ChangeStored_SLBanRa(-ct.SoLuong.Value, maSP, p.NgayLapPBH.Value);

                db.CT_PBH.Remove(ct);
                db.SaveChanges();
            }
        }

        public static void Edit_CTPBH(int maPBH, int maSP, int soluong, long donGiaBan, long thanhTien)
        {
            using (DB_QLKDEntities db= new DB_QLKDEntities())
            {
                CT_PBH ctPBH = db.CT_PBH.Where(c => c.MaPBH == maPBH && c.MaSP == maSP).First();
                PHIEUBANHANG pbh = db.PHIEUBANHANGs.Where(c => c.MaPBH == maPBH).First();
                if (CheckSoLuong(soluong - ctPBH.SoLuong.Value, maSP) == true)
                {
                    ChangeStored_SLBanRa(soluong - ctPBH.SoLuong.Value, maSP, pbh.NgayLapPBH.Value);
                    ChangeQuantity(ctPBH.SoLuong.Value, maSP);
                    ChangeQuantity(-soluong, maSP);
                }
                ctPBH.SoLuong = soluong;
                ctPBH.DonGiaBan = donGiaBan;
                pbh.TongTien -= ctPBH.ThanhTien;
                ctPBH.ThanhTien = thanhTien;
                pbh.TongTien += thanhTien;

                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
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

                ChangeStored_SLMuaVao(soLuongMua, maSP, ngayLapPhieu);
                ChangeQuantity(soLuongMua, maSP);

                db.SaveChanges();
                MessageBox.Show("Thêm thành công", "Thông Báo");
            }
        }

        public static void Delete_CTPMH(int maPMH,int masp)
        {
            using (DB_QLKDEntities db=new DB_QLKDEntities())
            {
                CT_PMH ctPMH = db.CT_PMH.Where(c => c.MaPMH == maPMH && c.MaSP==masp).First();
                PHIEUMUAHANG pmh = db.PHIEUMUAHANGs.Where(c => c.MaPMH == maPMH).First();

                ChangeQuantity(-ctPMH.SoLuongMuaVao.Value, masp);
                ChangeStored_SLMuaVao(-ctPMH.SoLuongMuaVao.Value, masp, pmh.NgLapPMH.Value);
                
                db.CT_PMH.Remove(ctPMH);
                db.SaveChanges();
            }
        }

        public static void Edit_CTPMH(int maPMH, int masp, int maNCC, int soLuong, int donGia, int thanhTien)
        {
            using (DB_QLKDEntities db =new DB_QLKDEntities())
            {
                PHIEUMUAHANG pmh = db.PHIEUMUAHANGs.Where(c => c.MaPMH == maPMH).First();
                CT_PMH ctPMH = db.CT_PMH.Where(c => c.MaPMH == maPMH).First();
                ChangeStored_SLMuaVao(soLuong - ctPMH.SoLuongMuaVao.Value, masp, pmh.NgLapPMH.Value);
                ChangeQuantity(-ctPMH.SoLuongMuaVao.Value, masp);
                ChangeQuantity(soLuong, masp);
                pmh.MaNCC = maNCC;
                ctPMH.SoLuongMuaVao = soLuong;
                ctPMH.DonGiaMuaVao = donGia;
                ctPMH.ThanhTien = thanhTien;

                db.SaveChanges();
            }
        }
        public static void Add_CTPhieuDichVu(int maPDV, int maDV, int soLuong, long donGia, long thanhTien, long traTruoc, long conLai, DateTime ngayGiao, DateTime ngayLapPhieu, string tenKH, int sdt)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                if (db.PHIEUDVs.Find(maPDV) == null)
                {
                    PHIEUDV pdv = new PHIEUDV
                    {
                        MaPDV = maPDV,
                        TenKH = tenKH,
                        NgayLapPDV = ngayLapPhieu,
                        SDTKH = sdt,
                        TongTien = 0,
                        TongTienConLai = 0,
                        TongTienTraTruoc = 0,
                    };
                    db.PHIEUDVs.Add(pdv);
                    db.SaveChanges();
                }
                long donGiaTinh = donGia;
                CT_PDV ctpdv = new CT_PDV
                {
                    MaPDV = maPDV,
                    MaDV = maDV,
                    SoLuongDV = soLuong,
                    DonGiaDV = donGia,
                    ChiPhiRiengDV = 0,
                    DonGiaDuocTinh = donGiaTinh,
                    ThanhTien = thanhTien,
                    MaTT = 0,
                    NgayGiao = ngayGiao,
                    TraTruoc = traTruoc,
                    ConLai = conLai,
                    TinhTrang = "Chưa Giao",
                };
                db.CT_PDV.Add(ctpdv);
                PHIEUDV a = db.PHIEUDVs.Where(c => c.MaPDV == maPDV).First();
                a.TongTien += thanhTien;
                a.TongTienTraTruoc += traTruoc;
                a.TongTienConLai += conLai;
                db.SaveChanges();
            }
        }
        public static void Delete_CTPDV(int maPDV, int maDV)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                CT_PDV ct = db.CT_PDV.Where(c => c.MaDV == maDV && c.MaPDV == maPDV).First();
                db.CT_PDV.Remove(ct);
                db.SaveChanges();
            }
        }

        public static void Edit_CTPDV(int maPDV, int maDV, int soLuong, long traTruoc, DateTime ngayGiao, string tinhTrang)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                PHIEUDV pdv = db.PHIEUDVs.Where(c => c.MaPDV == maPDV).First();
                CT_PDV ctpdv = db.CT_PDV.Where(c => c.MaPDV == maPDV && c.MaDV == maDV).First();
                long donGia = Convert.ToInt64((from d in db.DICHVUs
                                               where d.MaDV == maDV
                                               select d.DonGiaDV).First().ToString());
                long thanhTien = soLuong * donGia;
                int maTT = 0;
                if (tinhTrang == "Đã Giao")
                {
                    maTT = 1;
                }
                else maTT = 0;

                ctpdv.SoLuongDV = soLuong;

                ctpdv.MaTT = maTT;
                ctpdv.TinhTrang = tinhTrang;
                ctpdv.NgayGiao = ngayGiao;
                long tong = Convert.ToInt64((from c in db.PHIEUDVs
                                             where c.MaPDV == maPDV
                                             select c.TongTien).First().ToString());
                long tongTien = tong - ctpdv.ThanhTien.Value;
                tongTien += thanhTien;
                ctpdv.ThanhTien = thanhTien;
                pdv.TongTien = tongTien;

                long sum = Convert.ToInt64((from c in db.PHIEUDVs
                                            where c.MaPDV == maPDV
                                            select c.TongTienTraTruoc).First().ToString());
                long tongTienTraTruoc = sum - ctpdv.TraTruoc.Value;
                tongTienTraTruoc += traTruoc;
                ctpdv.TraTruoc = traTruoc;
                pdv.TongTienTraTruoc = tongTienTraTruoc;

                long tongCL = Convert.ToInt64((from c in db.PHIEUDVs
                                               where c.MaPDV == maPDV
                                               select c.TongTienConLai).First().ToString());
                long tongTienConLai = tong - ctpdv.ConLai.Value;
                if (tinhTrang == "Đã Giao")
                {
                    ctpdv.ConLai = 0;
                    tongTienConLai = tongTien;
                }
                else if (tinhTrang == "Chưa Giao")
                {
                    ctpdv.ConLai = thanhTien - traTruoc;
                    tongTienConLai = tongTien - tongTienTraTruoc;
                }
                pdv.TongTienConLai = tongTienConLai;
                db.SaveChanges();
            }
        }
        public static void ChangeUserPassword(string user,string newpass)
        {
            using(DB_QLKDEntities db =new DB_QLKDEntities())
            {
                var u = db.LOGINs.Where(c => c.USERNAME == user).First();
                u.PWD = newpass;
                db.SaveChanges();
            }
        }
    }

    
}
