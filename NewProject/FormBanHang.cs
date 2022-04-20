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
    public partial class FormBanHang : Form
    {
        DB_QLKDEntities db = new DB_QLKDEntities();
        public static List<BHList> bHLists = new List<BHList>();
        public static DataGridView dgv;
        public int value, selection;
        public FormBanHang()
        {
            InitializeComponent();
            dgv = dataGridView1;
            TB_IDPBH.Select();
            TB_IDPBH.Focus();
            BtnAdd.Enabled = false;
            value = 0;
        }

        //Xuất data vào grid
        public void LoadData() 
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                int mapbh = Convert.ToInt32(TB_IDPBH.Text);
                var result = from c in db.CT_PBH
                             join e in db.PHIEUBANHANGs on c.MaPBH equals e.MaPBH
                             join t in db.SANPHAMs on c.MaSP equals t.MaSP
                             join k in db.LOAISPs on t.MaLoaiSP equals k.MaLoaiSP
                             join q in db.DONVITINHs on k.MaDVT equals q.MaDVT
                             where c.MaPBH == mapbh
                             select new CT_PhieuBanHang
                             {
                                 //Mã_Phiếu_Bán_Hàng = e.MaPBH,
                                 Sản_Phẩm = t.TenSP,
                                 Mã_Loại_Sản_Phẩm = k.MaLoaiSP,
                                 Số_Lượng = c.SoLuong.Value,
                                 Đơn_Vị_Tính = q.LoaiDVT,
                                 Đơn_Giá = c.DonGiaBan.Value,
                                 Thành_Tiền = c.ThanhTien.Value
                             };

                dgv.DataSource = result.ToList();
            }
        }
        
        private bool IsTBValid()
        {
            if ((CBSanPham.Text != "") &&
                (CBLoaiSP.Text != "") &&
                (!(string.IsNullOrEmpty(TBSoLuong.Text))))
                return true;
            else return false;
        }
        private bool IsCustomerInfoValid()
        {
            if (string.IsNullOrEmpty(TB_TenKH.Text))
                return false;
            else return true;
        }
        private void BtnAdd_Visible()
        {
            if ((IsSPMuaValid()) && (IsCustomerInfoValid()))
                BtnAdd.Enabled = true;
            else BtnAdd.Enabled = false;
        }

        private void ResetInputBH()
        {
            CBLoaiSP.SelectedIndex = -1;
            CBSanPham.SelectedIndex = -1;
            TBSoLuong.Text = "";
        }
        private void AdjustSumMoney(int mapbh)
        {
            
            var sum = (from p in db.PHIEUBANHANGs
                      where p.MaPBH == mapbh
                      select p.TongTien).First();
            LbSumMoney.Text = $"{sum} đồng";
        }    
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string maPBH = TB_IDPBH.Text;
            string tenKH = TB_TenKH.Text;
            string ngayLapPhieu = pbh_DateTime.Text;
            int loaiSP = Convert.ToInt32(CBLoaiSP.Text);
            var msp = from c in db.SANPHAMs
                where c.TenSP == CBSanPham.Text
                select c.MaSP;
            int masp = Convert.ToInt32(msp.First());
            int soluong = Convert.ToInt32(TBSoLuong.Text);
            var donGiaMuaVao = from c in db.SANPHAMs
                where c.MaSP == masp
                select c.DonGiaMuaVao;
            var loiNhuan = from c in db.LOAISPs
                where c.MaLoaiSP == loaiSP
                select c.PhanTramLoiNhuan;
            double profit = Convert.ToDouble(loiNhuan.First().ToString()) / 100;
            int donGiaMua = Convert.ToInt32(donGiaMuaVao.First().ToString());
            int donGiaBan = Convert.ToInt32(donGiaMua + (donGiaMua * profit));
            
            DB_QLKD.AddCT_PBH(maPBH, masp, soluong, donGiaBan, ngayLapPhieu);
            db.SaveChanges();
            LoadData();
            MessageBox.Show("Thêm thành công", "Thông Báo");
            AdjustSumMoney(Convert.ToInt32(maPBH));
            ResetInputBH();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int maPBH = Convert.ToInt32(TB_IDPBH.Text);
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Bạn vẫn chưa điền thông tin!");
            else
            {
                int mapbh = Convert.ToInt32((from d in db.PHIEUBANHANGs
                                             where d.MaPBH == maPBH
                                             select d.MaPBH).First());
                string tenSP = dgv.SelectedCells[0].OwningRow.Cells["Sản_Phẩm"].Value.ToString();
                int maSP = Convert.ToInt32((from c in db.SANPHAMs
                                           where c.TenSP == tenSP
                                            select c.MaSP).First());
                DB_QLKD.Delete_CTPBH(mapbh, maSP);
                LoadData();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                ResetInputBH();
                AdjustSumMoney(mapbh);
            }
        }

        private void TBSoLuong_TextChanged(object sender, EventArgs e)
        {
            BtnAdd_Visible();
        }

        private void CBLoaiSP_DropDown(object sender, EventArgs e)
        {
            BtnAdd_Visible();
            var loaisp = from c in db.LOAISPs
                         select c.MaLoaiSP;
            CBLoaiSP.DataSource = loaisp.ToList();
        }

        private void CBSanPham_DropDown(object sender, EventArgs e)
        {
            BtnAdd_Visible();
            if(CBLoaiSP.Text=="")
            {
                MessageBox.Show("Xin hãy chọn loại sản phẩm trước", "Thông Báo");
            }
            else
            {
                int maLSP = Convert.ToInt32(CBLoaiSP.Text);
                var sanpham = from sp in db.SANPHAMs
                              where sp.MaLoaiSP == maLSP
                              select sp.TenSP;
                CBSanPham.DataSource = sanpham.ToList();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(TB_IDPBH.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu cần xem", "Thông Báo");
            }
            else
            {
                LoadData();
            }
        }

        private void CBLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBSanPham.SelectedIndex = -1;
            TBSoLuong.Text = "";
        }

        private void TB_IDPBH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int maPBH = Convert.ToInt32(TB_IDPBH.Text);

            string tenSP = dgv.SelectedCells[0].OwningRow.Cells["Sản_Phẩm"].Value.ToString();
            int maLoaiSP = Convert.ToInt32(dgv.SelectedCells[0].OwningRow.Cells["Mã_Loại_Sản_Phẩm"].Value.ToString());
            int soLuong = Convert.ToInt32(dgv.SelectedCells[0].OwningRow.Cells["Số_Lượng"].Value.ToString());
            var msp = from c in db.SANPHAMs
                      where c.TenSP == tenSP
                      select c.MaSP;
            int masp = Convert.ToInt32(msp.First());
            var donGiaMuaVao = from c in db.SANPHAMs
                               where c.MaSP == masp
                               select c.DonGiaMuaVao;
            var loiNhuan = from c in db.LOAISPs
                           where c.MaLoaiSP == maLoaiSP
                           select c.PhanTramLoiNhuan;

            double profit = Convert.ToDouble(loiNhuan.First().ToString()) / 100;
            int donGiaMua = Convert.ToInt32(donGiaMuaVao.First().ToString());
            int donGiaBan = Convert.ToInt32(donGiaMua + (donGiaMua * profit));
            int thanhTien = soLuong * donGiaBan;
            DB_QLKD.Edit_CTPBH(maPBH, masp, soLuong, donGiaBan, thanhTien);
            LoadData();
            //EditItem();
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
            ResetInputBH();
            AdjustSumMoney(maPBH);
        }
    }
}
