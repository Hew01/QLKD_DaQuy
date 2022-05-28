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
    public partial class FormDanhSachPhieuDichVu : Form
    {
        public FormDanhSachPhieuDichVu()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            using (DB_QLKDEntities db =new DB_QLKDEntities())
            {
                
                var bc = from pdv in db.PHIEUDVs
                         select new
                         {
                             Mã_Phiếu_Dịch_Vụ=pdv.MaPDV,
                             Họ_Tên_Khách_Hàng=pdv.TenKH,
                             Số_Điện_Thoại=pdv.SDTKH,
                             Tổng_Tiền_Trả_Trước=pdv.TongTienTraTruoc,
                             Tổng_Tiền_Còn_Lại=pdv.TongTienConLai,
                             Tổng_Tiền=pdv.TongTien,
                             //Tinh_Trạng=tinhTrang
                         };
                dataGridView1.DataSource = bc.ToList();
            }
        }
    }
}
