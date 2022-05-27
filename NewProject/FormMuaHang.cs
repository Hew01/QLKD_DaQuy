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
    public partial class FormMuaHang : Form
    {
        public static List<BHList> bHLists = new List<BHList>();
        public static DataGridView dgv;
        public int value, selection;
        DB_QLKDEntities db = new DB_QLKDEntities();
        public FormMuaHang()
        {
            InitializeComponent();
            dgv = dataGridView1;
            tbSoPhieu.Select();
            tbSoPhieu.Focus();
            BtnAdd.Enabled = false;
            value = 0;
        }

        public void LoadData()
        {
            int maPMH = Convert.ToInt32(tbSoPhieu.Text);
            var result = from lsp in db.LOAISPs
                         join sp in db.SANPHAMs on lsp.MaLoaiSP equals sp.MaLoaiSP
                         join ctpmh in db.CT_PMH on sp.MaSP equals ctpmh.MaSP
                         join pmh in db.PHIEUMUAHANGs on ctpmh.MaPMH equals pmh.MaPMH
                         join ncc in db.NHACUNGCAPs on pmh.MaNCC equals ncc.MaNCC
                         where pmh.MaPMH==maPMH
                         select new CT_PhieuMuaHang
                         {
                             Loại_Sản_Phẩm = lsp.MaLoaiSP,
                             Sản_Phẩm = sp.TenSP,
                             Nhà_Cung_Cấp = ncc.TenNCC,
                             Số_Lượng = ctpmh.SoLuongMuaVao.Value,
                             Đơn_Vị_Tính = lsp.DONVITINH.LoaiDVT,
                             Đơn_Giá = ctpmh.DonGiaMuaVao.Value,
                             Thành_Tiền = ctpmh.ThanhTien.Value,

                         };
            dgv.DataSource = result.ToList();
            dgv.AutoResizeColumns();
        }
        private bool IsSPMuaValid()
        {
            if ((CBSanPham.Text != "") &&
                (CBLoaiSP.Text != "") &&
                (!(string.IsNullOrEmpty(TBSoLuong.Text))))
                return true;
            else return false;
        }
        private bool IsCustomerInfoValid()
        {
            if (string.IsNullOrEmpty(cbNhaCungCap.Text))
                return false;
            else return true;
        }
        private void BtnAdd_Visible()
        {
            if (IsSPMuaValid() && (IsCustomerInfoValid()))
                BtnAdd.Enabled = true;
            else BtnAdd.Enabled = false;
        }
        private void ResetInputBH()
        {
            CBLoaiSP.SelectedIndex = -1;
            CBSanPham.SelectedIndex = -1;
            TBSoLuong.Text = "";
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int maPMH = Convert.ToInt32(tbSoPhieu.Text);
            DateTime ngayLapPhieu= pmh_DateTime.Value;
            string nhaCungCap = cbNhaCungCap.Text;
            int maLoaiSP = Convert.ToInt32(CBLoaiSP.Text);
            string tenSP = CBSanPham.Text;
            int soLuong = Convert.ToInt32(TBSoLuong.Text);

            var ncc = from c in db.NHACUNGCAPs
                      where c.TenNCC == nhaCungCap
                      select c.MaNCC;
            var sp = from c in db.SANPHAMs
                     where c.TenSP == tenSP
                     select c.MaSP;
            
            int maSP = Convert.ToInt32(sp.First().ToString());
            var donGia = from c in db.SANPHAMs
                         where c.MaSP == maSP
                         select c.DonGiaMuaVao;
            int maNCC = Convert.ToInt32(ncc.First().ToString());
            int donGiaMua = Convert.ToInt32(donGia.First().ToString());
            int thanhTien = donGiaMua * soLuong;

            DB_QLKD.addCT_PMH(maPMH, maSP, soLuong, donGiaMua, thanhTien, ngayLapPhieu, maNCC);
            db.SaveChanges();
            LoadData();
            MessageBox.Show("Thêm thành công", "Thông Báo");
            value += thanhTien;
            LbSumMoney.Text = $"{value} đồng";
            ResetInputBH();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Bạn vẫn chưa điền thông tin!");
            else
            {
                //DeleteItem();
                int maPBH = Convert.ToInt32(tbSoPhieu.Text);
                string tenSP = dgv.SelectedCells[0].OwningRow.Cells["Sản_Phẩm"].Value.ToString();
                int ThanhTien = Convert.ToInt32(dgv.SelectedCells[0].OwningRow.Cells["Thành_Tiền"].Value);
                int masp=Convert.ToInt32((from c in db.SANPHAMs
                                         where c.TenSP==tenSP
                                         select c.MaSP).First().ToString());
                DB_QLKD.Delete_CTPMH(maPBH, masp);
                LoadData();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                ResetInputBH();
                value -= ThanhTien;
                LbSumMoney.Text = $"{value} đồng";
            }
        }
        private void TBSoLuong_TextChanged(object sender, EventArgs e)
        {
            BtnAdd_Visible();
        }
        private void CBLoaiSP_DropDown(object sender, EventArgs e)
        {
            BtnAdd_Visible();
            var lsp = from c in db.LOAISPs
                      select c.MaLoaiSP;
            CBLoaiSP.DataSource = lsp.ToList();
        }

        private void CBSanPham_DropDown(object sender, EventArgs e)
        {
            BtnAdd_Visible();
            if (CBLoaiSP.Text == "")
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

        private void CBNhaCungCap_DropDown(object sender, EventArgs e)
        {
            BtnAdd_Visible();
            var ncc = from c in db.NHACUNGCAPs
                      select c.TenNCC;
            cbNhaCungCap.DataSource = ncc.ToList();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(tbSoPhieu.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập số phiếu", "Thông Báo");
            }
            else
            {
                LoadData();
            }
        }

        private void tbSoPhieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void CBLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBSanPham.SelectedIndex = -1;
            TBSoLuong.Text = "";
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int maPMH = Convert.ToInt32(tbSoPhieu.Text);
            string tenSP = dgv.SelectedCells[0].OwningRow.Cells["Sản_Phẩm"].Value.ToString();
            string tenNCC = dgv.SelectedCells[0].OwningRow.Cells["Nhà_Cung_Cấp"].Value.ToString();
            int soLuong = Convert.ToInt32(dgv.SelectedCells[0].OwningRow.Cells["Số_Lượng"].Value.ToString());
            int ThanhTien = Convert.ToInt32(dgv.SelectedCells[0].OwningRow.Cells["Thành_Tiền"].Value);
            value -= ThanhTien;
            int maSP = Convert.ToInt32((from c in db.SANPHAMs
                                        where c.TenSP == tenSP
                                        select c.MaSP).First().ToString());
            int maNCC = Convert.ToInt32((from c in db.NHACUNGCAPs
                                         where c.TenNCC == tenNCC
                                         select c.MaNCC).First().ToString());
            int donGiaMua = Convert.ToInt32((from c in db.SANPHAMs
                                             where c.MaSP == maSP
                                             select c.DonGiaMuaVao).First().ToString());
            int donGia = donGiaMua;
            ThanhTien = donGia * soLuong;
            value += ThanhTien;
            DB_QLKD.Edit_CTPMH(maPMH, maSP, maNCC, soLuong, donGia, ThanhTien);
            LoadData();
            MessageBox.Show("Sửa thành công", "Thông Báo");
            ResetInputBH();
            LbSumMoney.Text = $"{value} đồng";
        }
    }
}

