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
    public partial class FormThemSP : Form
    {
        public FormThemSP()
        {
            InitializeComponent();
        }
        private void TB_IDPBH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        public void ResetInput()
        {
            cbLoaiSP.Text = "";
            tbSanPham.Text = "";
            donGiaBan.Text = "";
            donGiaMua.Text = "";
        }

        private void BtnThemSP_Click(object sender, EventArgs e)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                string tenSP = tbSanPham.Text;
                int loaiSP = Convert.ToInt32(cbLoaiSP.Text);
                long giaBan = Convert.ToInt64(donGiaBan.Text);
                long giaMua = Convert.ToInt64(donGiaMua.Text);


                //tạo sp mới
                SANPHAM sp = new SANPHAM();
                sp.TenSP = tenSP;
                sp.MaLoaiSP = loaiSP;
                sp.DonGiaBan = giaBan;
                sp.DonGiaMuaVao = giaMua;
                sp.SoLuongTon = 0;

                db.SANPHAMs.Add(sp);
                db.SaveChanges();
                MessageBox.Show("Thêm sản phẩm thành công !", "Thông báo");
                ResetInput();
                FormDanhSachSP.instance.LoadData();
                FormDanhSachSP.instance.Show();
                this.Close();
            }
        }

        private void cbLoaiSP_DropDown(object sender, EventArgs e)
        {
            using(DB_QLKDEntities db =new DB_QLKDEntities())
            {
                var lsp = from c in db.LOAISPs
                          select c.MaLoaiSP;
                cbLoaiSP.DataSource = lsp.ToList();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
