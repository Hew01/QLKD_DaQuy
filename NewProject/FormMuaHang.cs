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
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            value = 0;
            LoadData();
        }

        public void LoadData()
        {
            var result = from lsp in db.LOAISPs
                         join sp in db.SANPHAMs on lsp.MaLoaiSP equals sp.MaLoaiSP
                         join ctpmh in db.CT_PMH on sp.MaSP equals ctpmh.MaSP
                         join pmh in db.PHIEUMUAHANGs on ctpmh.MaPMH equals pmh.MaPMH
                         join ncc in db.NHACUNGCAPs on pmh.MaNCC equals ncc.MaNCC
                         select new
                         {
                             MaPhieuMuaHang=pmh.MaPMH,
                             LoaiSanPham=lsp.MaLoaiSP,
                             SanPham=sp.TenSP,
                             NhaCungCap=ncc.TenNCC,
                             Soluong=ctpmh.SoLuongMuaVao,
                             DonViTinh=lsp.DONVITINH.LoaiDVT,
                             DonGia=ctpmh.DonGiaMuaVao,
                             ThanhTien=ctpmh.ThanhTien
                         };
            dataGridView1.DataSource = result.ToList();
            dataGridView1.AutoResizeColumns();
        }
        private bool IsEmptyCell(DataGridViewRow row)
        {
            for (int i = 0; i < row.Cells.Count; i++)
            {
                if (row.Cells[i].Value == null
                    || row.Cells[i].Value == DBNull.Value
                    || String.IsNullOrWhiteSpace(row.Cells[i].Value.ToString()))
                    return true;
            }
            return false;
        }
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
        private void ResetInputBH()
        {
            CBLoaiSP.SelectedIndex = -1;
            CBSanPham.SelectedIndex = -1;
            TBSoLuong.Text = "";
        }
        private void AdjustItem()
        {
            string lsp = CBLoaiSP.SelectedItem.ToString();
            string sp = CBSanPham.SelectedItem.ToString();
            string sl = TBSoLuong.Text.ToString();
            string dvt = "";
            int dg = 0, tt;
            switch (lsp)
            {
                //thêm vào dựa trên SQL về dvt, dg
                case "a":
                    dvt = "Chiếc";
                    dg = 1;
                    break;
                default:
                    break;
            }
            tt = int.Parse(sl) * dg;
            value += tt;
            bHLists.Add(new BHList(lsp, sp, sl, dvt, dg, tt));
            LbSumMoney.Text = $"{value} đồng";
        }
        private static void AddItemToDGV()
        {
            for (int i = 0; i < bHLists.Count; i++)
                dgv.Rows.Add((i + 1).ToString(),
                    bHLists[i].LoaiSP,
                    bHLists[i].SanPham,
                    bHLists[i].SoLuong,
                    bHLists[i].DonViTinh,
                    bHLists[i].DonGia,
                    bHLists[i].ThanhTien);
        }
        private void DeleteItem()
        {
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                if (!(IsEmptyCell(row)))
                {
                    int tt = int.Parse(row.Cells[6].Value.ToString());
                    value -= tt;
                    LbSumMoney.Text = $"{value} đồng";
                    dgv.Rows.RemoveAt(row.Index);
                    bHLists.RemoveAt(selection);
                }
            }
        }
        private void EditItem()
        {
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                if (!(IsEmptyCell(row)))
                {
                    string dvt, lsp, sp, sl;
                    int dg, tt;
                    lsp = CBLoaiSP.SelectedItem.ToString();
                    sp = CBSanPham.SelectedItem.ToString();
                    sl = TBSoLuong.Text.ToString();
                    dvt = "";

                    //insert SQL về dvt và dg here

                    tt = int.Parse(row.Cells[6].Value.ToString());
                    value -= tt;
                    dg = 1;                 //gắn giá trị tạm, ở đây phải dùng SQL để thay đổi giá trị dg và dvt
                    tt = dg * int.Parse(sl);

                    //Edit ở dgv
                    row.Cells[1].Value = CBLoaiSP.SelectedItem.ToString();
                    row.Cells[2].Value = CBSanPham.SelectedItem.ToString();
                    row.Cells[3].Value = TBSoLuong.Text.ToString();

                    //row.Cells[4].Value - dvt
                    //row.Cells[5].Value - dg

                    value += tt;
                    row.Cells[6].Value = tt.ToString();
                    LbSumMoney.Text = $"{value} đồng";

                    //Edit ở ListBH
                    bHLists[selection].LoaiSP = lsp;
                    bHLists[selection].SanPham = sp;
                    bHLists[selection].SoLuong = sl;
                    bHLists[selection].DonViTinh = dvt;
                    bHLists[selection].DonGia = dg;
                    bHLists[selection].ThanhTien = tt;
                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool valid = int.TryParse(TBSoLuong.Text, out int value);
            if (valid)
            {
                AdjustItem();
                dgv.Rows.Clear();
                AddItemToDGV();
            }
            else
                MessageBox.Show("Số lượng không hợp lệ!");
            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            ResetInputBH();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Bạn vẫn chưa điền thông tin!");
            else

            {
                DeleteItem();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                ResetInputBH();
                dgv.ClearSelection();
                BtnDelete.Enabled = false;
                BtnEdit.Enabled = false;

            }
        }

        

        private void TBSoLuong_TextChanged(object sender, EventArgs e)
        {
            BtnAdd_Visible();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            bool dk = false;
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                if (!(IsEmptyCell(row)))
                {
                    CBLoaiSP.Text = row.Cells[1].Value.ToString();
                    CBSanPham.Text = row.Cells[2].Value.ToString();
                    TBSoLuong.Text = row.Cells[3].Value.ToString();
                }
            }
            selection = dgv.CurrentCell.RowIndex;
            if (dk)
            {
                BtnEdit.Enabled = true;
                BtnDelete.Enabled = true;
            }
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
            var sp = from c in db.SANPHAMs
                      select c.TenSP;
            CBSanPham.DataSource = sp.ToList();
        }

        private void CBNhaCungCap_DropDown(object sender, EventArgs e)
        {
            BtnAdd_Visible();
            var ncc = from c in db.NHACUNGCAPs
                      select c.TenNCC;
            cbNhaCungCap.DataSource = ncc.ToList();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditItem();
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
            ResetInputBH();
            dgv.ClearSelection();
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;

        }
    }
}

