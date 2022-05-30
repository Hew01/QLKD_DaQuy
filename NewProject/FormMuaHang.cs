using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Office_12 = Microsoft.Office.Core;
using Excel_12 = Microsoft.Office.Interop.Excel;


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

        //Xuất data vào gird
        public void LoadData()
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                int maPMH = Convert.ToInt32(tbSoPhieu.Text);
                var result = from lsp in db.LOAISPs
                             join sp in db.SANPHAMs on lsp.MaLoaiSP equals sp.MaLoaiSP
                             join ctpmh in db.CT_PMH on sp.MaSP equals ctpmh.MaSP
                             join pmh in db.PHIEUMUAHANGs on ctpmh.MaPMH equals pmh.MaPMH
                             join ncc in db.NHACUNGCAPs on pmh.MaNCC equals ncc.MaNCC
                             where pmh.MaPMH == maPMH
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

                dataGridView1.DataSource = result.ToList();
                dataGridView1.AutoResizeColumns();
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
            if (string.IsNullOrEmpty(cbNhaCungCap.Text))
                return false;
            else return true;
        }
        private void BtnAdd_Visible()
        {
            if (/*IsSPMuaValid() &&*/ (IsCustomerInfoValid()))
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

        //Xóa sản phẩm trong phiếu
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
        private void ExportDataGridViewTo_Excel12(DataGridView myDataGridViewQuantity)
        {

            Excel_12.Application oExcel_12 = null; //Excel_12 Application 

            Excel_12.Workbook oBook = null; // Excel_12 Workbook 

            Excel_12.Sheets oSheetsColl = null; // Excel_12 Worksheets collection 

            Excel_12.Worksheet oSheet = null; // Excel_12 Worksheet 

            Excel_12.Range oRange = null; // Cell or Range in worksheet 

            Object oMissing = System.Reflection.Missing.Value;


            // Create an instance of Excel_12. 

            oExcel_12 = new Excel_12.Application();


            // Make Excel_12 visible to the user. 

            oExcel_12.Visible = true;


            // Set the UserControl property so Excel_12 won't shut down. 

            oExcel_12.UserControl = true;

            // System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US"); 

            //object file = File_Name;

            //object missing = System.Reflection.Missing.Value;



            // Add a workbook. 

            oBook = oExcel_12.Workbooks.Add(oMissing);

            // Get worksheets collection 

            oSheetsColl = oExcel_12.Worksheets;

            // Get Worksheet "Sheet1" 

            oSheet = (Excel_12.Worksheet)oSheetsColl.get_Item("Sheet1");
            oSheet.Name = "PhieuMuaHang";

            //Tạo tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("D1", "F1");

            head.MergeCells = true;

            head.Value2 = "Phiếu Mua Hàng";

            head.Font.Bold = true;

            head.Font.Name = "Time New Roman";

            head.Font.Size = "18";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Export titles 

            for (int j = 0; j < myDataGridViewQuantity.Columns.Count; j++)
            {

                oRange = (Excel_12.Range)oSheet.Cells[4, j + 1];
                oRange.Font.Size = "12";
                oRange.Font.Name = "Time New Roman";
                if (j >= 0) oRange.ColumnWidth = 13.5;
                if (j == 1) oRange.ColumnWidth = 22;
                if (j == 2) oRange.ColumnWidth = 22;
                oRange.Value2 = myDataGridViewQuantity.Columns[j].HeaderText;

            }

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A4", "G4");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[5, 1];

            // Export data 

            for (int i = 0; i < myDataGridViewQuantity.Rows.Count; i++)
            {

                for (int j = 0; j < myDataGridViewQuantity.Columns.Count; j++)
                {
                    oRange = (Excel_12.Range)oSheet.Cells[i + 5, j + 1];
                    oRange.Value2 = myDataGridViewQuantity[j, i].Value;
                    oRange.Font.Size = "12";
                    oRange.Font.Name = "Time New Roman";

                }

            }

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[4 + myDataGridViewQuantity.Rows.Count, myDataGridViewQuantity.Columns.Count];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột STT

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[5 + myDataGridViewQuantity.Rows.Count, 2];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tổng tiền

            Microsoft.Office.Interop.Excel.Range TongTien = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[6 + myDataGridViewQuantity.Rows.Count, 2];
            TongTien.MergeCells = true;

            TongTien.Value2 = "TỔNG TIỀN:";

            TongTien.Font.Bold = true;

            TongTien.Font.Name = "Time New Roman";

            TongTien.Font.Size = "13";

            TongTien.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range TongTienText = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[6 + myDataGridViewQuantity.Rows.Count, 3];
            TongTienText.Value2 = LbSumMoney.Text;
            TongTienText.Font.Bold = true;
            TongTienText.Font.Name = "Time New Roman";
            TongTienText.Font.Size = "13";

            // Ngày
            Microsoft.Office.Interop.Excel.Range Ngay = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[2, 1];
            Ngay.Value2 = "Ngày :";
            Ngay.Font.Bold = true;
            Ngay.Font.Name = "Time New Roman";
            Ngay.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range NgayText = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[2, 2];
            NgayText.Value2 = pmh_DateTime.Text;
            NgayText.Font.Bold = true;
            NgayText.Font.Name = "Time New Roman";
            NgayText.Font.Size = "13";

            // Tên khách hàng

            Microsoft.Office.Interop.Excel.Range Ten = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[1, 1];
            Ten.Value2 = "Tên NCC :";
            Ten.Font.Bold = true;
            Ten.Font.Name = "Time New Roman";
            Ten.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range TenText = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[1, 2];
            TenText.Value2 = cbNhaCungCap.Text;
            TenText.Font.Bold = true;
            TenText.Font.Name = "Time New Roman";
            TenText.Font.Size = "13";

            oBook = null;
            oExcel_12.Quit();
            oExcel_12 = null;
            GC.Collect();
        }
        private void btnInPhieuMuaHang_Click(object sender, EventArgs e)
        {
            try
            {
                ExportDataGridViewTo_Excel12(dataGridView1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
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

