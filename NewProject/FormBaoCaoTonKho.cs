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
                LoadData(month, year);
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Thông Báo");
            }
        }
    }
}
