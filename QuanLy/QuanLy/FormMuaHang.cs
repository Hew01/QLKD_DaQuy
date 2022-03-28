using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class FormMuaHang : Form
    {
        public static List<BHList> bHLists = new List<BHList>();
        public static DataGridView dgv;
        public int value;
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
        private void AddItem(int i)
        {
            string lsp = FormMuaHang.bHLists[i].LoaiSP;
            string sp = FormMuaHang.bHLists[i].SanPham;
            string dvt = FormMuaHang.bHLists[i].DonViTinh;
            switch (lsp)
            {
                //thêm vào dựa trên SQL
                default:
                    break;
            }
            int sl = int.Parse(FormMuaHang.bHLists[i].SoLuong);
            int dg = FormMuaHang.bHLists[i].DonGia;
            int tt = FormMuaHang.bHLists[i].ThanhTien;
            //int id = FormMuaHang.bHLists[i].ID;
            //Đơn giá cũng dựa trên SQL
            tt = sl * dg;
            value += tt;
            LbSumMoney.Text = $"{value.ToString()} đồng";
            FormMuaHang.dgv.Rows.Add((i + 1).ToString(), lsp, sp, sl, dvt, dg, tt);
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool valid = int.TryParse(TBSoLuong.Text, out int value);
            if (valid)
            {
                FormMuaHang.bHLists.Add(new BHList(
                    CBLoaiSP.SelectedItem.ToString(),
                    CBSanPham.SelectedItem.ToString(),
                    TBSoLuong.Text.ToString()));
                FormMuaHang.dgv.Rows.Clear();
                for (int i = 0; i < FormMuaHang.bHLists.Count; i++)
                    AddItem(i);
            }
            else
                MessageBox.Show("Số lượng không hợp lệ!");
            BtnAdd.Enabled = false;
            ResetInputBH();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Bạn vẫn chưa điền thông tin!");
            else
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    int tt = int.Parse(row.Cells[6].Value.ToString());
                    value -= tt;
                    LbSumMoney.Text = $"{value.ToString()} đồng";
                    dgv.Rows.RemoveAt(row.Index);
                }
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                ResetInputBH();
                dgv.ClearSelection();
                BtnDelete.Enabled = false;
                BtnEdit.Enabled = false;

            }
        }

        private void CBLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnAdd_Visible();
        }

        private void CBSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnAdd_Visible();
        }

        private void TBSoLuong_TextChanged(object sender, EventArgs e)
        {
            BtnAdd_Visible();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                CBLoaiSP.Text = row.Cells[1].Value.ToString();
                CBSanPham.Text = row.Cells[2].Value.ToString();
                TBSoLuong.Text = row.Cells[3].Value.ToString();
            }
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                string dvt;
                int sl, dg, tt;
                sl = int.Parse(TBSoLuong.Text.ToString());
                tt = int.Parse(row.Cells[6].Value.ToString());
                value -= tt;
                dg = 1;                 //gắn giá trị tạm
                row.Cells[1].Value = CBLoaiSP.SelectedItem.ToString();
                row.Cells[2].Value = CBSanPham.SelectedItem.ToString();
                row.Cells[3].Value = TBSoLuong.Text.ToString();

                //row.Cells[4].Value - dvt
                //row.Cells[5].Value - dg

                tt = dg * sl;
                value += tt;
                row.Cells[6].Value = tt.ToString();
                LbSumMoney.Text = $"{value.ToString()} đồng";
            }
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
            ResetInputBH();
            dgv.ClearSelection();
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;

        }
    }
} 

