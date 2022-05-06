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
            //BtnEdit.Enabled = false;
            //BtnDelete.Enabled = false;
            value = 0;
            //LoadData();
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
                             //Mã_Phiếu_Mua_Hàng = pmh.MaPMH,
                             //Ngày_Lập_Phiếu = pmh.NgLapPMH,
                             Loại_Sản_Phẩm = lsp.MaLoaiSP,
                             Sản_Phẩm = sp.TenSP,
                             Nhà_Cung_Cấp = ncc.TenNCC,
                             Số_Lượng = ctpmh.SoLuongMuaVao.Value,
                             Đơn_Vị_Tính = lsp.DONVITINH.LoaiDVT,
                             Đơn_Giá = ctpmh.DonGiaMuaVao.Value,
                             Thành_Tiền = ctpmh.ThanhTien.Value,

                         };



            dataGridView1.DataSource = result.ToList();
            dataGridView1.AutoResizeColumns();
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
            if ((CBSanPham.SelectedIndex != -1) &&
                (CBLoaiSP.SelectedIndex != -1) &&
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
            //bool valid = int.TryParse(TBSoLuong.Text, out int value);
            //if (valid)
            //{
            //    AdjustItem();
            //    dgv.Rows.Clear();
            //    AddItemToDGV();
            //}
            //else
            //    MessageBox.Show("Số lượng không hợp lệ!");
            //BtnAdd.Enabled = false;
            //BtnEdit.Enabled = false;
            //BtnDelete.Enabled = false;
            //ResetInputBH();

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
            LoadData();
            MessageBox.Show("Thêm thành công", "Thông Báo");
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
                int masp=Convert.ToInt32((from c in db.SANPHAMs
                                         where c.TenSP==tenSP
                                         select c.MaSP).First().ToString());
                DB_QLKD.Delete_CTPMH(maPBH, masp);
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //EditItem();
            //MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
            //ResetInputBH();
            //dgv.ClearSelection();
            //BtnEdit.Enabled = false;
            //BtnDelete.Enabled = false;

            int maPMH = Convert.ToInt32(tbSoPhieu.Text);
            string tenSP = dgv.SelectedCells[0].OwningRow.Cells["Sản_Phẩm"].Value.ToString();
            string tenNCC = dgv.SelectedCells[0].OwningRow.Cells["Nhà_Cung_Cấp"].Value.ToString();
            int soLuong = Convert.ToInt32(dgv.SelectedCells[0].OwningRow.Cells["Số_Lượng"].Value.ToString());

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
            int thanhTien = donGia * soLuong;

            DB_QLKD.Edit_CTPMH(maPMH, maSP, maNCC, soLuong, donGia, thanhTien);
            LoadData();
            MessageBox.Show("Sửa thành công", "Thông Báo");

        }
    }
}

