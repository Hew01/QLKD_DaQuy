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
            //BtnEdit.Enabled = false;
            //BtnDelete.Enabled = false;
            value = 0;
            /*LoadData();*/ // Xuất data vào grid view
        }

        public void LoadData() 
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
        //private bool IsEmptyCell(DataGridViewRow row)
        //{
        //    for (int i = 0; i < row.Cells.Count; i++)
        //    {
        //        if (row.Cells[i].Value == null
        //            || row.Cells[i].Value == DBNull.Value
        //            || String.IsNullOrWhiteSpace(row.Cells[i].Value.ToString()))
        //            return true;
        //    }
        //    return false;
        //}
        private bool IsTBValid()
        {
            if ((CBSanPham.Text != "") &&
                (CBLoaiSP.Text != "") &&
                (!(string.IsNullOrEmpty(TBSoLuong.Text))))
                return true;
            else return false;
        }
        private void BtnAdd_Visible()
        {
            if (IsTBValid())
                BtnAdd.Enabled = true;
            else BtnAdd.Enabled = false;
        }
        //private void ResetInputBH()
        //{
        //    CBLoaiSP.SelectedIndex = -1;
        //    CBSanPham.SelectedIndex = -1;
        //    TBSoLuong.Text = "";
        //}
        //private void AdjustItem()
        //{
        //    string lsp = CBLoaiSP.SelectedItem.ToString();
        //    string sp = CBSanPham.SelectedItem.ToString();
        //    string sl = TBSoLuong.Text.ToString();
        //    string dvt = "";
        //    int dg = 0, tt;
        //    switch (lsp)
        //    {
        //        //thêm vào dựa trên SQL về dvt, dg
        //        case "a":
        //            dvt = "Chiếc";
        //            dg = 1;
        //            break;
        //        default:
        //            break;
        //    }
        //    tt = int.Parse(sl) * dg;
        //    value += tt;
        //    bHLists.Add(new BHList(lsp, sp, sl, dvt, dg, tt));
        //    LbSumMoney.Text = $"{value} đồng";
        //}
        //private static void AddItemToDGV()
        //{
        //    for (int i = 0; i < bHLists.Count; i++)
        //        dgv.Rows.Add((i + 1).ToString(),
        //            bHLists[i].LoaiSP,
        //            bHLists[i].SanPham,
        //            bHLists[i].SoLuong,
        //            bHLists[i].DonViTinh,
        //            bHLists[i].DonGia,
        //            bHLists[i].ThanhTien);
        //}
        //private void DeleteItem()
        //{

        //    foreach (DataGridViewRow row in dgv.SelectedRows)
        //    {
        //        if (!(IsEmptyCell(row)))
        //        {
        //            int tt = int.Parse(row.Cells[6].Value.ToString());
        //            value -= tt;
        //            LbSumMoney.Text = $"{value} đồng";
        //            dgv.Rows.RemoveAt(row.Index);
        //            bHLists.RemoveAt(selection);
        //        }
        //    }
        //}
        //private void EditItem()
        //{
        //    foreach (DataGridViewRow row in dgv.SelectedRows)
        //    {
        //        if (!(IsEmptyCell(row)))
        //        {
        //            string dvt, lsp, sp, sl;
        //            int dg, tt;
        //            lsp = CBLoaiSP.SelectedItem.ToString();
        //            sp = CBSanPham.SelectedItem.ToString();
        //            sl = TBSoLuong.Text.ToString();
        //            dvt = "";

        //            //insert SQL về dvt và dg here


        //            tt = int.Parse(row.Cells[6].Value.ToString());
        //            value -= tt;
        //            dg = 1;                 //gắn giá trị tạm, ở đây phải dùng SQL để thay đổi giá trị dg và dvt
        //            tt = dg * int.Parse(sl);

        //            //Edit ở dgv
        //            row.Cells[1].Value = CBLoaiSP.SelectedItem.ToString();
        //            row.Cells[2].Value = CBSanPham.SelectedItem.ToString();
        //            row.Cells[3].Value = TBSoLuong.Text.ToString();

        //            //row.Cells[4].Value - dvt
        //            //row.Cells[5].Value - dg

        //            value += tt;
        //            row.Cells[6].Value = tt.ToString();
        //            LbSumMoney.Text = $"{value} đồng";

        //            //Edit ở ListBH
        //            bHLists[selection].LoaiSP = lsp;
        //            bHLists[selection].SanPham = sp;
        //            bHLists[selection].SoLuong = sl;
        //            bHLists[selection].DonViTinh = dvt;
        //            bHLists[selection].DonGia = dg;
        //            bHLists[selection].ThanhTien = tt;
        //        }
        //    }
        //}
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string maPBH = TB_IDPBH.Text;
            string tenKH = TB_TenKH.Text;
            string ngayLapPhieu = TB_NgayLapPhieu.Text;
            int loaiSP = Convert.ToInt32(CBLoaiSP.Text);
            var msp = from c in db.SANPHAMs
                       where c.TenSP == CBSanPham.Text
                       select c.MaSP;
            int masp = Convert.ToInt32(msp.First());
            int soluong = Convert.ToInt32(TBSoLuong.Text);

            var donGiaMuaVao = from c in db.SANPHAMs
                               where c.MaSP==masp
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
            
        }



        private void BtnDelete_Click(object sender, EventArgs e)
        {
               
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Bạn vẫn chưa điền thông tin!");
            else
            {
                BtnDelete.Enabled = true;
                int maPBH = Convert.ToInt32(TB_IDPBH.Text);
                string tenSP = dgv.SelectedCells[0].OwningRow.Cells["Sản_Phẩm"].Value.ToString();
                int maSP = Convert.ToInt32((from c in db.SANPHAMs
                                           where c.TenSP == tenSP
                                           select c.MaSP).First().ToString());

                //DeleteItem();
                DB_QLKD.Delete_CTPBH(maPBH,maSP);
                LoadData();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                //ResetInputBH();
                //dgv.ClearSelection();
                //BtnDelete.Enabled = false;
                //BtnEdit.Enabled = false;

            }
        }

        private void TBSoLuong_TextChanged(object sender, EventArgs e)
        {
            BtnAdd_Visible();
        }

        //private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        //{
        //    bool dk = false;
        //    foreach (DataGridViewRow row in dgv.SelectedRows)
        //    {
        //        if (!(IsEmptyCell(row)))
        //        {
        //            CBLoaiSP.Text = row.Cells[1].Value.ToString();
        //            CBSanPham.Text = row.Cells[2].Value.ToString();
        //            TBSoLuong.Text = row.Cells[3].Value.ToString();
        //            dk = true;
        //        }
        //    }
        //    selection = dgv.CurrentCell.RowIndex;
        //    if (dk)
        //    {
        //        BtnEdit.Enabled = true;
        //        BtnDelete.Enabled = true;
        //    }
        //}

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
            //int maLSP = Convert.ToInt32(CBLoaiSP.Text.ToString());
            //var sanpham = from sp in db.SANPHAMs
            //              where sp.MaLoaiSP==maLSP
            //              select sp.TenSP;
            //if(sanpham.Any())
            //{
            //    CBSanPham.DataSource = sanpham.ToList();
            //}
            //else
            //{
            //    MessageBox.Show("Xin hãy chọn loại sản phẩm trước", "Thông Báo");
            //}
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int maPBH = Convert.ToInt32(TB_IDPBH.Text);
            string tenSP = dgv.SelectedCells[0].OwningRow.Cells["Sản_Phẩm"].Value.ToString();
            int maLoaiSP= Convert.ToInt32(dgv.SelectedCells[0].OwningRow.Cells["Mã_Loại_Sản_Phẩm"].Value.ToString());
            int soLuong= Convert.ToInt32(dgv.SelectedCells[0].OwningRow.Cells["Số_Lượng"].Value.ToString());
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
            //ResetInputBH();
            //dgv.ClearSelection();
            //BtnEdit.Enabled = false;
            //BtnDelete.Enabled = false;

        }
    }
}
