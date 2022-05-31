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
    public partial class FormDanhSachPBH : Form
    {
        public FormDanhSachPBH()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {

                var bc = from pbh in db.PHIEUBANHANGs
                         select new
                         {
                             Mã_Phiếu_Bán_Hàng = pbh.MaPBH,
                             //Họ_Tên_Khách_Hàng = pbh.TenKH,
                             Ngày_Lập_Phiếu=pbh.NgayLapPBH,
                             Tổng_Tiền = pbh.TongTien,
                         };
                dataGridView1.DataSource = bc.ToList();
            }
        }
    }
}
