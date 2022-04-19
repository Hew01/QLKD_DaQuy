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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLapPhieuBanHang_Click(object sender, EventArgs e)
        {
            FormBanHang f= new FormBanHang();
            f.ShowDialog();

        }

        private void btnLapPhieuMuaHang_Click(object sender, EventArgs e)
        {
            FormMuaHang f= new FormMuaHang();
            f.ShowDialog();
        }

        private void btnLapPhieuDichVu_Click(object sender, EventArgs e)
        {
            FormDichVu f= new FormDichVu();
            f.ShowDialog();
        }

        private void btnBaoCaoTonKho_Click(object sender, EventArgs e)
        {
            FormBaoCaoTonKho f=new FormBaoCaoTonKho();
            f.ShowDialog();
        }

        private void btnDanhSachPhieuDichVu_Click(object sender, EventArgs e)
        {
            FormDanhSachPhieuDichVu f=new FormDanhSachPhieuDichVu();
            f.ShowDialog();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinTaiKhoan f=new FormThongTinTaiKhoan();
            f.ShowDialog();
        }
    }
}
