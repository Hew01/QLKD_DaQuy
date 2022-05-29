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
    public partial class FormThongTinTaiKhoan : Form
    {
        public FormThongTinTaiKhoan()
        {
            InitializeComponent();
            LoadAccountInfo();
        }

        public void LoadAccountInfo()
        {
            using(DB_QLKDEntities db=new DB_QLKDEntities())
            {
                var user = db.LOGINs.Where(c => c.USERNAME == DB_QLKD.currentUser).First();
                tbHoTen.Text = user.USERNAME;
                tbVaiTro.Text = user.ROLE;
            }
        }
        public void ResetInput()
        {
            tbMatKhauHienTai.Text = "";
            tbMatKhauMoi.Text = "";
            tbNhapLaiMatKhauMoi.Text = "";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            using(DB_QLKDEntities db =new DB_QLKDEntities())
            {
                var user = db.LOGINs.Where(c => c.USERNAME == DB_QLKD.currentUser).First();
                if(user.PWD==tbMatKhauHienTai.Text)
                {
                    if(tbMatKhauMoi.Text==tbNhapLaiMatKhauMoi.Text)
                    {
                        DB_QLKD.ChangeUserPassword(DB_QLKD.currentUser, tbNhapLaiMatKhauMoi.Text);
                        MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo");
                        ResetInput();
                    }
                    else
                    {
                        MessageBox.Show("Xin hãy nhập lại mật khẩu chính xác", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại không chính xác !", "Thông báo");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
