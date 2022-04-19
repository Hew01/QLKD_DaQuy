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
    public partial class FormDichVu : Form
    {
        public static List<DVLIst> dVLists = new List<DVLIst>();
        public static DataGridView dgv;
        public int valueSum, valuePaid, valueRemain, selection;
        public FormDichVu()
        {
            InitializeComponent();
            dgv = dataGridView1;
            tbSoPhieu.Select();
            tbSoPhieu.Focus();
            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            valueSum = 0;
            valuePaid = 0;
            valueRemain = 0;
        }

        private void FormDichVu_Load(object sender, EventArgs e)
        {
            //dataGridView properties:
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ColumnHeadersHeight = this.dataGridView1.ColumnHeadersHeight * 2;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            this.dataGridView1.CellPainting += new DataGridViewCellPaintingEventHandler(dataGridView1_CellPainting);
            this.dataGridView1.Paint += new PaintEventHandler(dataGridView1_Paint);
            this.dataGridView1.Scroll += new ScrollEventHandler(dataGridView1_Scroll);
            this.dataGridView1.ColumnWidthChanged += new DataGridViewColumnEventHandler(dataGridView1_ColumnWidthChanged);
        }
        //Khởi tạo dgv để có merge cells
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            //gắn 2 ô header lại với nhau
            Rectangle r1 = dataGridView1.GetCellDisplayRectangle(6, -1, true);
            int w2 = dataGridView1.GetCellDisplayRectangle(7, -1, true).Width;

            r1.X += 1;
            r1.Y += 1;
            r1.Width = r1.Width + w2 - 2;
            r1.Height = r1.Height / 2 - 2;
            e.Graphics.FillRectangle(new SolidBrush(dataGridView1.ColumnHeadersDefaultCellStyle.BackColor), r1);

            //format cho header mới merged
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("Thanh toán", dataGridView1.ColumnHeadersDefaultCellStyle.Font,
                new SolidBrush(dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor), r1, format);

        }

        //Các thuộc tính cho dgv để thuận tiện cho việc merge:

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle rtHeader = dataGridView1.DisplayRectangle;
            rtHeader.Height = dataGridView1.ColumnHeadersHeight / 2;
            dataGridView1.Invalidate(rtHeader);
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                Rectangle r2 = e.CellBounds;
                r2.Y += e.CellBounds.Height / 2;
                r2.Height = e.CellBounds.Height / 2;
                e.PaintBackground(r2, true);
                e.PaintContent(r2);
                e.Handled = true;
            }
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle rtHeader = dataGridView1.DisplayRectangle;
            rtHeader.Height = dataGridView1.ColumnHeadersHeight / 2;
            dataGridView1.Invalidate(rtHeader);
        }

        //Xử lí dgv
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
            if (!(string.IsNullOrEmpty(TBTraTruoc.Text)) &&
                (CBLoaiDV.SelectedIndex != -1) &&
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
            CBLoaiDV.SelectedIndex = -1;
            TBTraTruoc.Text = "";
            TBSoLuong.Text = "";
        }
        private void UpdateValueSum()
        {
            tbTongTien.Text = $"{valueSum} đồng";
            tbTongTraTruoc.Text = $"{valuePaid} đồng";
            tbTongConLai.Text = $"{valueRemain} đồng";
        }
        private void AdjustItem()
        {
            string ldv = CBLoaiDV.SelectedItem.ToString();
            string trt = TBTraTruoc.Text.ToString();
            string sl = TBSoLuong.Text.ToString();
            int dgdv = 0, dgdt = 0, tt, cl;
            DateTime dt = dtNgayGiao.Value;
            switch (ldv)
            {
                //thêm vào dựa trên SQL về dgdv, dgtt
                case "a":
                    dgdv = 1;
                    dgdt = 2;
                    break;
                case "b":
                    dgdv = 2;
                    dgdt = 1;
                    break;
                default:
                    break;
            }
            tt = int.Parse(sl) * dgdt;
            cl = tt - int.Parse(trt);
            valueSum += tt;
            valuePaid += int.Parse(trt);
            valueRemain += cl;
            dVLists.Add(new DVLIst(ldv, dgdv, dgdt, sl, tt, trt, cl, dt));
            UpdateValueSum();
        }
        private static void AddItemToDGV()
        {
            for (int i = 0; i < dVLists.Count; i++)
                dgv.Rows.Add((i + 1).ToString(),
                    dVLists[i].LoaiDV,
                    dVLists[i].DgDV,
                    dVLists[i].DgDT,
                    dVLists[i].SoLuong,
                    dVLists[i].ThanhTien,
                    dVLists[i].TraTruoc,
                    dVLists[i].ConLai,
                    dVLists[i].NgayGiao);
        }
        private void DeleteItem()
        {
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                if (!(IsEmptyCell(row)))
                {
                    int tt = int.Parse(row.Cells[5].Value.ToString());
                    int trt = int.Parse(row.Cells[6].Value.ToString());
                    int cl = int.Parse(row.Cells[7].Value.ToString());
                    valueSum -= tt;
                    valuePaid -= trt;
                    valueRemain -= cl;
                    UpdateValueSum();
                    dgv.Rows.RemoveAt(row.Index);
                    dVLists.RemoveAt(selection);
                }
            }
        }
        private void EditItem()
        {
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                if (!(IsEmptyCell(row)))
                {
                    string ldv, trt, sl;
                    int dgdv, dgdt, tt, cl;
                    DateTime dt;
                    ldv = CBLoaiDV.SelectedItem.ToString();
                    sl = TBSoLuong.Text.ToString();
                    dt = dtNgayGiao.Value;

                    //insert SQL về dgdt và dgdv here, ở đây đang gán giá trị tạm
                    dgdt = 1;
                    dgdv = 1;

                    //Trừ các value cũ
                    tt = int.Parse(row.Cells[5].Value.ToString());
                    trt = row.Cells[6].Value.ToString();
                    cl = int.Parse(row.Cells[7].Value.ToString());

                    valueSum -= tt;
                    valuePaid -= int.Parse(trt);
                    valueRemain -= cl;

                    //Thêm giá trị value mới
                    tt = dgdt * int.Parse(sl);
                    trt = TBTraTruoc.Text.ToString();
                    cl = tt - int.Parse(trt);

                    //Edit ở dgv
                    row.Cells[1].Value = CBLoaiDV.SelectedItem.ToString();
                    //row.Cells[2].Value = dgdv;
                    //row.Cells[3].Value = dgdt;
                    row.Cells[4].Value = TBSoLuong.Text.ToString();
                    row.Cells[5].Value = tt;
                    row.Cells[6].Value = trt;
                    row.Cells[7].Value = cl;
                    row.Cells[8].Value = dt;
                    UpdateValueSum();

                    //Edit ở ListBH
                    dVLists[selection].LoaiDV = ldv;
                    dVLists[selection].SoLuong = sl;
                    dVLists[selection].DgDT = dgdt;
                    dVLists[selection].DgDV = dgdv;
                    dVLists[selection].ThanhTien = tt;
                    dVLists[selection].TraTruoc = trt;
                    dVLists[selection].ConLai = cl;
                    dVLists[selection].NgayGiao = dt;
                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool validSoLuong = int.TryParse(TBSoLuong.Text, out _);
            bool validTraTruoc = int.TryParse(TBTraTruoc.Text, out _);
            if ((validSoLuong) && (validTraTruoc))
            {
                AdjustItem();
                dgv.Rows.Clear();
                AddItemToDGV();
            }
            else
                MessageBox.Show("Dữ liệu nhập không hợp lệ!");
            BtnAdd.Enabled = false;
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

        private void CBLoaiDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnAdd_Visible();
        }

        private void TBTraTruoc_TextChanged(object sender, EventArgs e)
        {
            BtnAdd_Visible();
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
                    CBLoaiDV.Text = row.Cells[1].Value.ToString();
                    TBTraTruoc.Text = row.Cells[6].Value.ToString();
                    TBSoLuong.Text = row.Cells[4].Value.ToString();
                }
            }
            selection = dgv.CurrentCell.RowIndex;
            if (dk)
            {
                BtnEdit.Enabled = true;
                BtnDelete.Enabled = true;
            }
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