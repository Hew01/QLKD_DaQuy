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
    public partial class FormThemDV : Form
    {
        public FormThemDV()
        {
            InitializeComponent();
        }
        private void TB_IDPBH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        public void ResetInput()
        {
            tbDichVu.Text = "";
            donGia.Text = "";
        }

        private void BtnThemDV_Click(object sender, EventArgs e)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                string tenDV = tbDichVu.Text;
                long gia = Convert.ToInt64(donGia.Text);

                //tạo sp mới
                DICHVU dv = new DICHVU();
                dv.LoaiDV = tenDV;
                dv.DonGiaDV = gia;

                db.DICHVUs.Add(dv);
                db.SaveChanges();
                MessageBox.Show("Thêm dịch vụ thành công !", "Thông báo");
                ResetInput();
                FormDanhSachDV.instance.LoadData();
                FormDanhSachDV.instance.Show();
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
