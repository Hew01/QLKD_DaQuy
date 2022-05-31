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
    public partial class FormDanhSachPMH : Form
    {
        public FormDanhSachPMH()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {

                var bc = from pmh in db.PHIEUMUAHANGs
                         join ncc in db.NHACUNGCAPs on pmh.MaNCC equals ncc.MaNCC
                         join ctpmh in db.CT_PMH on pmh.MaPMH equals ctpmh.MaPMH
                         select new
                         {
                             Mã_Phiếu_Bán_Hàng = pmh.MaPMH,
                             //Họ_Tên_Khách_Hàng = pmh.TenKH,
                             Nhà_Cung_Cấp = ncc.TenNCC,
                             Địa_Chỉ = ncc.DiaChiNCC,
                             Số_Điện_Thoại_NCC = ncc.SDTNCC,
                             Ngày_Lập_Phiếu = pmh.NgLapPMH, 
                             Thành_Tiền = ctpmh.ThanhTien,
                             
                         };
                dataGridView1.DataSource = bc.ToList();
            }
        }
    }
}
