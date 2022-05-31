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
    public partial class FormDanhSachSP : Form
    {
        public FormDanhSachSP()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {

                var bc = from sp in db.SANPHAMs
                         from lsp in db.LOAISPs
                         where lsp.MaLoaiSP == sp.MaLoaiSP
                         select new
                         {
                             Mã_Sản_Phẩm = sp.MaSP,
                             Loại_Sản_Phẩm = sp.MaLoaiSP,
                             Sản_Phẩm = sp.TenSP,
                             Đơn_Vị_Tính=lsp.DONVITINH.LoaiDVT,
                             Đơn_Giá_Bán=sp.DonGiaBan,
                         };
                dataGridView1.DataSource = bc.ToList();
            }
        }
    }
}
