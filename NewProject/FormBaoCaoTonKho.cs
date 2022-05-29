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
    public partial class FormBaoCaoTonKho : Form
    {
        public FormBaoCaoTonKho()
        {
            InitializeComponent();
        }

        public void LoadData(int thang, int year)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                var bc = from c in db.BAOCAOTONs
                         from d in db.SANPHAMs
                         from e in db.LOAISPs
                         where c.MaSP == d.MaSP && d.MaLoaiSP == e.MaLoaiSP && c.Thang==thang && c.Nam==year
                         select new
                         {
                             Sản_Phẩm = d.TenSP,
                             Tồn_Đầu = c.TonDau,
                             Số_Lượng_Bán_Ra = c.SLBanRa,
                             Số_Lượng_Mua_Vào = c.SLMuaVao,
                             Tồn_Cuối = c.TonCuoi,
                             Đơn_Vị_Tính = e.DONVITINH.LoaiDVT,
                         };
                dataGridView1.DataSource = bc.ToList();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                int month = dateTimePicker1.Value.Month;
                int year = dateTimePicker1.Value.Year;
                DateTime date = dateTimePicker1.Value;
                DB_QLKD.AutoGenerate_BaoCaoTon(date);
                LoadData(month, year);
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Thông Báo");
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
            oSheet.Name = "BaoCaoTonKho";

            //Tạo tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("C1", "D1");

            head.MergeCells = true;

            head.Value2 = "Báo Cáo Tồn Kho";

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
                if (j == 3 || j == 2) oRange.ColumnWidth = 22;
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



            // Ngày
            Microsoft.Office.Interop.Excel.Range Ngay = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[2, 1];
            Ngay.Value2 = "Tháng :";
            Ngay.Font.Bold = true;
            Ngay.Font.Name = "Time New Roman";
            Ngay.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range NgayText = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[2, 2];
            NgayText.Value2 = dateTimePicker1.Text;
            NgayText.Font.Bold = true;
            NgayText.Font.Name = "Time New Roman";
            NgayText.Font.Size = "13";


            oBook = null;
            oExcel_12.Quit();
            oExcel_12 = null;
            GC.Collect();
        }
       
        private void btnInBaoCaoTonKho_Click(object sender, EventArgs e)
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
