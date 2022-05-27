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
                             Sản_Phẩm = t.TenSP,
                             Mã_Loại_Sản_Phẩm = k.MaLoaiSP,
                             Số_Lượng = c.SoLuong.Value,
                             Đơn_Vị_Tính = q.LoaiDVT,
                             Đơn_Giá = c.DonGiaBan.Value,
                             Thành_Tiền = c.ThanhTien.Value

                         };
            dgv.DataSource = result.ToList();
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (TB_IDPBH.Text == "")
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
            oSheet.Name = "PhieuBanHang";
            
            //Tạo tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("D1", "F1");

            head.MergeCells = true;

            head.Value2 = "Phiếu Bán Hàng";

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
                oRange.Value2 = myDataGridViewQuantity.Columns[j].HeaderText;

            }

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A4", "F4");

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
            TongTienText.Value2 = LbSumMoney.Text ;
            TongTienText.Font.Bold = true;
            TongTienText.Font.Name = "Time New Roman";
            TongTienText.Font.Size = "13";

            // Ngày
            Microsoft.Office.Interop.Excel.Range Ngay = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[2, 1] ;
            Ngay.Value2 = "Ngày :";
            Ngay.Font.Bold = true;
            Ngay.Font.Name = "Time New Roman";
            Ngay.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range NgayText = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[2, 2];
            NgayText.Value2 = pbh_DateTime.Text;
            NgayText.Font.Bold = true;
            NgayText.Font.Name = "Time New Roman";
            NgayText.Font.Size = "13";

            // Tên khách hàng

            Microsoft.Office.Interop.Excel.Range Ten = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[1, 1];
            Ten.Value2 = "Tên KH :";
            Ten.Font.Bold = true;
            Ten.Font.Name = "Time New Roman";
            Ten.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range TenText = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[1, 2];
            TenText.Value2 = TB_TenKH.Text;
            TenText.Font.Bold = true;
            TenText.Font.Name = "Time New Roman";
            TenText.Font.Size = "13";

            oBook = null;
            oExcel_12.Quit();
            oExcel_12 = null;
            GC.Collect();
        }
        private void btnIn_Click(object sender, EventArgs e)
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

        private void LbSumMoney_Click(object sender, EventArgs e)
        {

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
