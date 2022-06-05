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
    public partial class FormDanhSachDV : Form
    {
        public static FormDanhSachDV instance;
        public FormDanhSachDV(string username)
        {
            InitializeComponent();
            instance = this;
            if (username == "admin")
                BtnAdd.Enabled = true;
            else BtnAdd.Enabled = false;
            LoadData();
        }

        public void LoadData()
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {

                var bc = from dv in db.DICHVUs
                         select new 
                         {
                             Mã_Dịch_Vụ=dv.MaDV,
                             Tên_Dịch_Vụ=dv.LoaiDV,
                             Đơn_Giá_Dịch_Vụ=dv.DonGiaDV
                         };
                dataGridView1.DataSource = bc.ToList();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormThemDV f = new FormThemDV();
            f.ShowDialog();
        }
    }
}
