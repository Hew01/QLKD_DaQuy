using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Office_12 = Microsoft.Office.Core;
using Excel_12 = Microsoft.Office.Interop.Excel;


namespace NewProject
{
    public partial class FormDichVu : Form
    {
        public static List<DVLIst> dVLists = new List<DVLIst>();
        public static DataGridView dgv;
        public int selection;
        public FormDichVu()
        {
            InitializeComponent();
            dgv = dataGridView1;
            tbSoPhieu.Select();
            tbSoPhieu.Focus();
            BtnAdd.Enabled = false;
            //BtnEdit.Enabled = false;
            //BtnDelete.Enabled = false;
        }

       public void LoadData()
        {
            using(DB_QLKDEntities db=new DB_QLKDEntities())
            {
                int maPDV = Convert.ToInt32(tbSoPhieu.Text);
                var result = from ctpdv in db.CT_PDV
                             join pdv in db.PHIEUDVs on ctpdv.MaPDV equals pdv.MaPDV
                             join dv in db.DICHVUs on ctpdv.MaDV equals dv.MaDV
                             where ctpdv.MaPDV==maPDV
                             select new PhieuDichVu
                             {
                                 Loại_Dịch_Vụ = dv.LoaiDV,
                                 Đơn_Giá_Dịch_Vụ = ctpdv.DonGiaDV.Value,
                                 Đơn_Giá_Được_Tính = ctpdv.DonGiaDuocTinh.Value,
                                 Số_Lượng=ctpdv.SoLuongDV.Value,
                                 Thành_Tiền=ctpdv.ThanhTien.Value,
                                 Trả_Trước=ctpdv.TraTruoc.Value,
                                 Còn_Lại=ctpdv.ConLai.Value,
                                 Ngày_Giao=ctpdv.NgayGiao.Value,
                                 Tình_Trạng=ctpdv.TinhTrang,
                             };

                var tongTien = from c in db.PHIEUDVs
                               where c.MaPDV == maPDV
                               select c.TongTien;
                var tongTienTraTruoc = from c in db.PHIEUDVs
                                       where c.MaPDV == maPDV
                                       select c.TongTienTraTruoc;
                var tongTienConLai = from c in db.PHIEUDVs
                                     where c.MaPDV == maPDV
                                     select c.TongTienConLai;
                tbTongTien.Text = tongTien.First().ToString();
                tbTongTraTruoc.Text = tongTienTraTruoc.First().ToString();
                tbTongConLai.Text = tongTienConLai.First().ToString();

                dgv.DataSource = result.ToList();
            }
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
       
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using(DB_QLKDEntities db=new DB_QLKDEntities())
            {
                int maPDV = Convert.ToInt32(tbSoPhieu.Text);
                string tenKH = tbKhachHang.Text;
                int sdt = Convert.ToInt32(tbSoDienThoai.Text);
                DateTime ngayLapPhieu = dtNgayLapPhieu.Value;
                DateTime ngayGiao = dtNgayGiao.Value;
                int soLuong = Convert.ToInt32(TBSoLuong.Text);
                long traTruoc = Convert.ToInt64(TBTraTruoc.Text);
                int maDV = Convert.ToInt32((from c in db.DICHVUs
                                            where c.LoaiDV == CBLoaiDV.Text
                                            select c.MaDV).First().ToString());
                long donGia= Convert.ToInt64((from c in db.DICHVUs
                                            where c.LoaiDV == CBLoaiDV.Text
                                            select c.DonGiaDV).First().ToString());
                long thanhTien = donGia * soLuong;
                long conLai = (thanhTien - traTruoc) < 0 ? 0 : (thanhTien - traTruoc);
                DB_QLKD.Add_CTPhieuDichVu(maPDV, maDV, soLuong, donGia, thanhTien, traTruoc, conLai, ngayGiao, ngayLapPhieu, tenKH, sdt);
                LoadData();
                MessageBox.Show("Thêm thành công!", "Thông Báo");
                ResetInputBH();
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                if (tbSoPhieu.Text=="" || dgv.RowCount==0)
                    MessageBox.Show("Bạn vẫn chưa điền thông tin!");
                else
                {
                    int maPDV = Convert.ToInt32(tbSoPhieu.Text);
                    string loaiDV = dgv.SelectedCells[0].OwningRow.Cells["Loại_Dịch_Vụ"].Value.ToString();
                    int maDV = Convert.ToInt32((from c in db.DICHVUs
                                                where c.LoaiDV == loaiDV
                                                select c.MaDV).First().ToString());
                    DB_QLKD.Delete_CTPDV(maPDV, maDV);
                    LoadData();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                    ResetInputBH();
                }
            }
                
        }


        private void TBTraTruoc_TextChanged(object sender, EventArgs e)
        {
            BtnAdd_Visible();
        }

        private void CBLoaiDV_DropDown(object sender, EventArgs e)
        {
            using(DB_QLKDEntities db=new DB_QLKDEntities())
            {
                var loaiSP = from c in db.DICHVUs
                             select c.LoaiDV;
                CBLoaiDV.DataSource = loaiSP.ToList();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(tbSoPhieu.Text=="")
            {
                 MessageBox.Show("Bạn chưa nhập mã phiếu!", "Thông Báo");
            }
            else
            {
                LoadData();
            }
        }

        

        private void TBSoLuong_TextChanged(object sender, EventArgs e)
        {
            BtnAdd_Visible();
        }

  
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                int maPDV = Convert.ToInt32(tbSoPhieu.Text);
                string loaiDV = dgv.SelectedCells[0].OwningRow.Cells["Loại_Dịch_Vụ"].Value.ToString();
                long donGiaDV = Convert.ToInt64(dgv.SelectedCells[0].OwningRow.Cells["Đơn_Giá_Dịch_Vụ"].Value.ToString());
                int donGiaTinh = Convert.ToInt32(dgv.SelectedCells[0].OwningRow.Cells["Đơn_Giá_Được_Tính"].Value.ToString());
                int soLuong = Convert.ToInt32(dgv.SelectedCells[0].OwningRow.Cells["Số_Lượng"].Value.ToString());
                long thanhTien = Convert.ToInt64(dgv.SelectedCells[0].OwningRow.Cells["Thành_Tiền"].Value.ToString());
                long traTruoc = Convert.ToInt64(dgv.SelectedCells[0].OwningRow.Cells["Trả_Trước"].Value.ToString());
                long conLai = Convert.ToInt64(dgv.SelectedCells[0].OwningRow.Cells["Còn_Lại"].Value.ToString());
                string tinhTrang = dgv.SelectedCells[0].OwningRow.Cells["Tình_Trạng"].Value.ToString();
                DateTime ngayGiao = Convert.ToDateTime(dgv.SelectedCells[0].OwningRow.Cells["Ngày_Giao"].Value.ToString());
                int maDV = Convert.ToInt32((from c in db.DICHVUs
                                            where c.LoaiDV == loaiDV
                                            select c.MaDV).First().ToString());
                DB_QLKD.Edit_CTPDV(maPDV, maDV, soLuong, traTruoc, ngayGiao, tinhTrang);
                LoadData();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
                ResetInputBH();
            }
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
            oSheet.Name = "PhieuDichVu";

            //Tạo tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("D1", "F1");

            head.MergeCells = true;

            head.Value2 = "Phiếu Dịch Vụ";

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
                if (j == 0) oRange.ColumnWidth = 22;
                if (j == 1) oRange.ColumnWidth = 22;
                if (j == 2) oRange.ColumnWidth = 22;
                oRange.Value2 = myDataGridViewQuantity.Columns[j].HeaderText;

            }

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A4", "I4");

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


            // Ngày
            Microsoft.Office.Interop.Excel.Range Ngay = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[2, 1];
            Ngay.Value2 = "Ngày :";
            Ngay.Font.Bold = true;
            Ngay.Font.Name = "Time New Roman";
            Ngay.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range NgayText = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[2, 2];
            NgayText.Value2 = dtNgayLapPhieu.Text;
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
            TenText.Value2 = tbKhachHang.Text;
            TenText.Font.Bold = true;
            TenText.Font.Name = "Time New Roman";
            TenText.Font.Size = "13";

            oBook = null;
            oExcel_12.Quit();
            oExcel_12 = null;
            GC.Collect();
        }
        private void btnInPhieuDichVu_Click(object sender, EventArgs e)
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

    }
}